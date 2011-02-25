using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using Vertimas.Classes;
using System.Reflection;
using Vertimas.Translation;
using Vertimas.Enums;
using CSCL;

namespace Vertimas
{
    public partial class FormMain : Form
    {
        private string rootPath;
        private Dictionary<string, ResourceHolder> resources;
        private ResourceHolder currentResource;
		private FilterMode filterMode=FilterMode.ShowAll;
		private List<string> recentProjects;

        public FormMain()
        {
            InitializeComponent();

            resources = new Dictionary<string, ResourceHolder>();
            labelTitle.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

			folderDialog.SelectedPath=Common.Options.GetElementAsString("xml.Options.Paths.LastOpenedPath");
            folderDialog.Description = Translate.FolderDialogDescription;

			if(folderDialog.ShowDialog()==DialogResult.OK)
			{
				OpenFolder(folderDialog.SelectedPath);
			}
        }

		private void OpenFolder(string folder)
		{
			if(!CanClose())
			{
				return;
			}

			Common.Options.WriteElement("xml.Options.Paths.LastOpenedPath", folder);

			if(recentProjects.Contains(folder))
			{
				recentProjects.Remove(folder);
			}

			recentProjects.Insert(0, folder);
			rootPath=folder;

			FindResxFiles(rootPath);

			tvFolderStructure.Nodes.Clear();
			foreach(ResourceHolder resource in resources.Values)
			{
				BuildTreeView(resource);
			}

			tvFolderStructure.ExpandAll();
		}

		private void BuildTreeView(ResourceHolder resource)
		{
			TreeNode parentNode=null;
			string[] topFolders=resource.DisplayFolder.Split(new char[] {'\\'}, StringSplitOptions.RemoveEmptyEntries);

			foreach(string subFolder in topFolders)
			{
				TreeNodeCollection searchNodes=parentNode==null?tvFolderStructure.Nodes:parentNode.Nodes;
				bool found=false;

				foreach(TreeNode treeNode in searchNodes)
				{
					if(treeNode.Tag is PathHolder&&(treeNode.Tag as PathHolder).Id.Equals(subFolder, StringComparison.InvariantCultureIgnoreCase))
					{
						found=true;
						parentNode=treeNode;
						break;
					}
				}

				if(!found)
				{
					TreeNode pathTreeNode=new TreeNode("["+subFolder+"]");
					PathHolder pathHolder=new PathHolder();
					pathHolder.Id=subFolder;
					pathTreeNode.Tag=pathHolder;
					searchNodes.Add(pathTreeNode);

					parentNode=pathTreeNode;
				}
			}

			TreeNode leafNode=new TreeNode(resource.Id);
			leafNode.Tag=resource;
			parentNode.Nodes.Add(leafNode);
		}

        private void FindResxFiles(string folder)
        {
            string displayFolder = "";

			if(folder.StartsWith(rootPath, StringComparison.InvariantCultureIgnoreCase))
			{
				FileInfo root=new FileInfo(rootPath.Trim('\\','/'));
				displayFolder=root.Name+folder.Substring(rootPath.Length);
			}

			displayFolder.TrimStart('\\', '/');

            string[] files = Directory.GetFiles(folder, "*.resx");

            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                string filenameNoExt = Path.GetFileNameWithoutExtension(file);
                string[] fileParts = filenameNoExt.Split('.');

				if(fileParts.Length==0)
				{
					continue;
				}

                string language = "";

				if(fileParts[fileParts.Length-1].Length==5&&fileParts[fileParts.Length-1][2]=='-')
				{
					language=fileParts[fileParts.Length-1];
				}
				else if(fileParts[fileParts.Length-1].Length==2)
				{
					language=fileParts[fileParts.Length-1];
				}
				if(!string.IsNullOrEmpty(language))
				{
					filenameNoExt=Path.GetFileNameWithoutExtension(filenameNoExt);
				}

                ResourceHolder resourceHolder;
                string key = (displayFolder + "\\" + filenameNoExt).ToLower();

                if (!resources.TryGetValue(key, out resourceHolder))
                {
                    resourceHolder = new ResourceHolder();
                    resourceHolder.DisplayFolder = displayFolder;

					if(string.IsNullOrEmpty(language))
					{
						resourceHolder.Filename=file;
					}

                    resourceHolder.Id = filenameNoExt;

                    resources.Add(key, resourceHolder);
                }

				if(!string.IsNullOrEmpty(language))
				{
					if(!resourceHolder.Languages.ContainsKey(language.ToLower()))
					{
						LanguageHolder languageHolder=new LanguageHolder();
						languageHolder.Filename=file;
						languageHolder.Id=language;
						resourceHolder.Languages.Add(language.ToLower(), languageHolder);
					}
				}
				else
				{
					resourceHolder.Filename=file;
				}
            }

            string[] subfolders = Directory.GetDirectories(folder);
            foreach (string subfolder in subfolders)
            {
                FindResxFiles(subfolder);
            }
        }

        private void OpenResource(ResourceHolder resource)
        {
            labelTitle.Text = resource.Id;
            checkedListBoxLanguages.Items.Clear();

            foreach (LanguageHolder languageHolder in resource.Languages.Values)
            {
                checkedListBoxLanguages.Items.Add(languageHolder, true);
            }

			dgwResourceData.DataSource=resource.StringsTable;

			dgwResourceData.Columns["Comment"].Visible=false;
			dgwResourceData.Columns["Translated"].Visible=false;
			dgwResourceData.Columns["Error"].Visible=false;

            ApplyFilterCondition();
        }

        private void checkedListBoxLanguages_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LanguageHolder languageHolder = checkedListBoxLanguages.Items[e.Index] as LanguageHolder;
            if (languageHolder == null)
                return;

			if(dgwResourceData==null)
			{
				// Not populated yet
				return;
			}

			if(dgwResourceData.Columns.Contains(languageHolder.Id))
			{
				dgwResourceData.Columns[languageHolder.Id].Visible=e.NewValue==CheckState.Checked;
			}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save
            foreach (ResourceHolder resource in resources.Values)
            {
                try
                {
					if(!resource.IsDirty)
					{
						continue;
					}

                    resource.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Translate.ExceptionWhileSaving + resource.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

		private void RefreshStatusbar()
		{
			//Count
			int visibleCount=0;

			for(int rowCounter=0; rowCounter<dgwResourceData.Rows.Count; rowCounter++)
			{
				if(dgwResourceData.Rows[rowCounter].Visible) visibleCount++;
			}

			tslEntryCount.Text=String.Format(Translate.EntryCount, dgwResourceData.Rows.Count, visibleCount);
		}

		private void ApplyFilterCondition()
		{
			if(dgwResourceData==null)
			{
				return;
			}

			#region Farben
			for(int rowCounter=0; rowCounter<dgwResourceData.Rows.Count; rowCounter++)
			{
				//Farbe
				bool cellValue=false;

				if(dgwResourceData.Rows[rowCounter].Cells["Error"].Value!=null)
				{
					cellValue=(bool)dgwResourceData.Rows[rowCounter].Cells["Error"].Value;
				}

				if(cellValue==true)
				{
					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.Red;
					dgwResourceData.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
				else
				{
					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.White;
					dgwResourceData.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}

				//Translated
				bool translated=true;

				for(int i=0; i<dgwResourceData.Rows[rowCounter].Cells.Count; i++)
				{
					DataGridViewCell cell=dgwResourceData.Rows[rowCounter].Cells[i];

					if(dgwResourceData.Columns[i].HeaderText=="Translated") continue;
					if(dgwResourceData.Columns[i].HeaderText=="Error") continue;
					if(dgwResourceData.Columns[i].HeaderText=="Comment") continue;

					if(cell.ValueType==typeof(string))
					{
						if(cell.Value is DBNull)
						{
							translated=false;
							break;
						}

						string val=(string)cell.Value;

						if(val=="")
						{
							translated=false;
							break;
						}
					}
				}

				if(translated)
				{
					dgwResourceData.Rows[rowCounter].Cells["Translated"].Value=true;

					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.White;
					dgwResourceData.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
				else
				{
					dgwResourceData.Rows[rowCounter].Cells["Translated"].Value=false;

					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.Yellow;
					dgwResourceData.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
			}

			
			#endregion

			#region Filter
			//Ersten Sichtbaren Entry suchen
			int firstVisibleEntry=-1;

			for(int rowCounter=0; rowCounter<dgwResourceData.Rows.Count; rowCounter++)
			{
				bool Translated=false;

				if(dgwResourceData.Rows[rowCounter].Cells["Translated"].Value!=null)
				{
					Translated=(bool)dgwResourceData.Rows[rowCounter].Cells["Translated"].Value;
				}

				bool found=false;

				switch(filterMode)
				{
					case FilterMode.ShowAll:
						{
							firstVisibleEntry=rowCounter;
							found=true;
							break;
						}
					case FilterMode.HideTranslated:
						{
							if(Translated==false)
							{
								firstVisibleEntry=rowCounter;
								found=true;
							}

							break;
						}
					case FilterMode.HideNonTranslated:
						{
							if(Translated==true)
							{
								firstVisibleEntry=rowCounter;
								found=true;
								break;
							}

							break;
						}
				}

				if(found) break;
			}

			if(firstVisibleEntry==-1)
			{
				RefreshStatusbar();
				return;
			}

			try
			{
				dgwResourceData.Rows[firstVisibleEntry].Visible=true;
				dgwResourceData.CurrentCell=dgwResourceData.Rows[firstVisibleEntry].Cells[0];
			}
			catch
			{
				RefreshStatusbar();
				return;
			}

			for(int rowCounter=0; rowCounter<dgwResourceData.Rows.Count; rowCounter++)
			{
				bool Translated=false;

				if(dgwResourceData.Rows[rowCounter].Cells["Translated"].Value!=null)
				{
					Translated=(bool)dgwResourceData.Rows[rowCounter].Cells["Translated"].Value;
				}

				switch(filterMode)
				{
					case FilterMode.ShowAll:
						{
							dgwResourceData.Rows[rowCounter].Visible=true;
							break;
						}
					case FilterMode.HideTranslated:
						{
							if(Translated)
							{
								dgwResourceData.Rows[rowCounter].Visible=false;
							}
							else
							{
								dgwResourceData.Rows[rowCounter].Visible=true;
							}

							break;
						}
					case FilterMode.HideNonTranslated:
						{
							if(Translated)
							{
								dgwResourceData.Rows[rowCounter].Visible=true;
							}
							else
							{
								dgwResourceData.Rows[rowCounter].Visible=false;
							}

							break;
						}
				}
			}
			#endregion

			RefreshStatusbar();
		}

        /// <summary>
        /// Check and prompt for save
        /// </summary>
        /// <returns>True if we can safely close</returns>
        private bool CanClose()
        {
            bool isDirty = false;
            foreach (ResourceHolder resource in resources.Values)
            {
                if (resource.IsDirty)
                {
                    isDirty = true;
                    break;
                }
            }

            if (isDirty)
            {
				switch(MessageBox.Show(Translate.WouldYouSaveYourUnsavedFiles, Translate.SaveFiles, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case System.Windows.Forms.DialogResult.Yes:
						{
							saveToolStripMenuItem_Click(null, null);
							return true;
						}
					case System.Windows.Forms.DialogResult.No:
						{
							return true;
						}
					case System.Windows.Forms.DialogResult.Cancel:
						{
							return false;
						}
					default:
						{
							throw new NotImplementedException();
						}
				}
            }

            return true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
			//Recent projects
			string recentProjectsJoined="";
			int count=0;

			foreach(string i in recentProjects)
			{
				recentProjectsJoined+=i+"|";
				count++;
				if(count==5) break;
			}

			Common.Options.WriteElement("xml.Options.Paths.RecentProjects", recentProjectsJoined);

			//Save options
			Common.Options.Save();

			//Check non saved data
			if(!CanClose())
			{
				e.Cancel=true;
			}
        }

        private void addNewKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if(currentResource==null)
			{
				return;
			}

            using (FormAddKey form = new FormAddKey(currentResource))
            {
                DialogResult result = form.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    currentResource.AddString(form.Key, form.NeutralValue, form.DefaultValue); //Add key
                }
            }
        }

        private void deleteKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if(currentResource==null||dgwResourceData.RowCount==0)
			{
				return;
			}

			if(MessageBox.Show(Translate.AreYouSureYouWantToDeleteTheCurrentKey, Translate.DeleteKey, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes)
			{
				DataGridViewRow dataRow=dgwResourceData.Rows[dgwResourceData.SelectedCells[0].RowIndex]; //Determinate selected row
				dgwResourceData.Rows.Remove(dataRow); //Remove row
				RefreshStatusbar();
			}
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if(!CanClose())
			{
				return;
			}

            tvFolderStructure.Nodes.Clear();
            checkedListBoxLanguages.Items.Clear();

			resources=new Dictionary<string, ResourceHolder>();

			dgwResourceData.DataSource=null;
			dgwResourceData.Columns.Clear();
			dgwResourceData.Rows.Clear();
            
			labelTitle.Visible = false;

            currentResource = null;
        }

        private void SelectResource()
        {
            TreeNode selectedTreeNode = tvFolderStructure.SelectedNode;

			if(selectedTreeNode==null)
			{
				return;
			}

			if(selectedTreeNode.Tag is PathHolder)
			{
				return;
			}

			if(!(selectedTreeNode.Tag is ResourceHolder))
			{
				return; // Shouldn't happen
			}

            ResourceHolder resource = selectedTreeNode.Tag as ResourceHolder;

            OpenResource(resource);
            currentResource = resource;
            labelTitle.Visible = true;
        }

        private void treeViewResx_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectResource();
		}

		private void gridResourcesStrings_DataSourceChanged(object sender, EventArgs e)
		{
			ApplyFilterCondition();
		}

		private void gridResourcesStrings_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			ApplyFilterCondition();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			//Write version number in title
			Assembly InstAssembly=Assembly.GetExecutingAssembly();
			Text+=" " + InstAssembly.GetName().Version.ToString();

			//Init
			recentProjects=new List<string>();

			//Create options folder if not exists
			if(FileSystem.ExistsDirectory(Common.OptionsDirectory)==false)
			{
				FileSystem.CreateDirectory(Common.OptionsDirectory, true);
			}

			//Options
			bool ExitsConfig=FileSystem.ExistsFile(Common.OptionsXmlFilename);

			Common.Options=new XmlData(Common.OptionsXmlFilename);
			if(!ExitsConfig) Common.Options.AddRoot("xml");

			//Load options
			string recentsProjectsJoined=Common.Options.GetElementAsString("xml.Options.Paths.RecentProjects");
			string[] splited=recentsProjectsJoined.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

			foreach(string entry in splited)
			{
				recentProjects.Add(entry);
			}
		}

		private void recentProjectsOpen_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item=(ToolStripMenuItem)sender;
			OpenFolder(item.Text);
		}

		private void menuStrip_MenuActivate(object sender, EventArgs e)
		{
			//Activate/Deactivate
			if(currentResource==null)
			{
				//File
				saveToolStripMenuItem.Enabled=false;

				//Language
				addNewLanguageToolStripMenuItem.Enabled=false;

				//Keys
				addNewKeyToolStripMenuItem.Enabled=false;
				deleteKeyToolStripMenuItem.Enabled=false;
			}
			else
			{
				//File
				saveToolStripMenuItem.Enabled=true;

				//Language
				addNewLanguageToolStripMenuItem.Enabled=true;

				//Keys
				addNewKeyToolStripMenuItem.Enabled=true;
				deleteKeyToolStripMenuItem.Enabled=true;
			}

			//File
			recentProjectsToolStripMenuItem.DropDownItems.Clear();

			foreach(string i in recentProjects)
			{
				ToolStripItem item=recentProjectsToolStripMenuItem.DropDownItems.Add(i);
				item.Click+=recentProjectsOpen_Click;
			}

			//View
			switch(filterMode)
			{
				case FilterMode.ShowAll:
					{
						showAllToolStripMenuItem.Checked=true;
						hideTranslatedToolStripMenuItem.Checked=false;
						hideNontranslatedToolStripMenuItem.Checked=false;
						break;
					}
				case FilterMode.HideTranslated:
					{
						showAllToolStripMenuItem.Checked=false;
						hideTranslatedToolStripMenuItem.Checked=true;
						hideNontranslatedToolStripMenuItem.Checked=false;
						break;
					}
				case FilterMode.HideNonTranslated:
					{
						showAllToolStripMenuItem.Checked=false;
						hideTranslatedToolStripMenuItem.Checked=false;
						hideNontranslatedToolStripMenuItem.Checked=true;
						break;
					}
			}
		}

		private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			filterMode=FilterMode.ShowAll;
			ApplyFilterCondition();
		}

		private void hideTranslatedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			filterMode=FilterMode.HideTranslated;
			ApplyFilterCondition();
		}

		private void hideNontranslatedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			filterMode=FilterMode.HideNonTranslated;
			ApplyFilterCondition();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAbout InstFormAbout=new FormAbout();
			InstFormAbout.ShowDialog();
		}

		static void CreateNewResourcesFile(string file)
		{
			using(Stream s=typeof(FormMain).Assembly.GetManifestResourceStream("Vertimas.Templates.blank-resx.dat"))
			{
				byte[] buffer=new byte[s.Length];
				s.Read(buffer, 0, (int)s.Length);
				File.WriteAllBytes(file, buffer);
			}
		}

		private TreeNode GetTreenodeWithFullPath(TreeNode treeNode, string fullPath)
		{
			if(treeNode.FullPath==fullPath)
			{
				return treeNode;
			}

			foreach(TreeNode tn in treeNode.Nodes)
			{
				TreeNode node=GetTreenodeWithFullPath(tn, fullPath);
				if(node!=null) return node;
			}

			return null;
		}

		private void addNewLanguageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormLanguageSelector InstFormLanguageSelector=new FormLanguageSelector();

			if(InstFormLanguageSelector.ShowDialog()==System.Windows.Forms.DialogResult.OK)
			{
				string resName=currentResource.Filename;
				string resNameNewLanguage=String.Format("{0}{1}.{2}.resx", FileSystem.GetPath(resName), FileSystem.GetFilenameWithoutExt(resName), InstFormLanguageSelector.SelectedLanguage);

				if(FileSystem.ExistsFile(resNameNewLanguage))
				{
					MessageBox.Show(Translate.ThisResourceFileAlreadyExists, Translate.Notice, MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				//Save the project
				saveToolStripMenuItem_Click(null, null);

				//Save treenode position
				string fullpath=tvFolderStructure.SelectedNode.FullPath;

				//Close the project
				closeToolStripMenuItem_Click(null, null);

				//CopyFile
				//FileSystem.CopyFile(resName, resNameNewLanguage);

				//Clean file
				CreateNewResourcesFile(resNameNewLanguage);

				//Reopen project
				OpenFolder(rootPath);

				//Reselect the treenode
				tvFolderStructure.SelectedNode=GetTreenodeWithFullPath(tvFolderStructure.Nodes[0], fullpath);
			}
		}
    }
}

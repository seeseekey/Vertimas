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

namespace Vertimas
{
    public partial class FormMain : Form
    {
        private string rootPath;
        private Dictionary<string, ResourceHolder> resources;
        private ResourceHolder currentResource;
		private FilterMode filterMode=FilterMode.ShowAll;
		private int visibleCount=0;

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
			if(!CanClose())
			{
				return;
			}

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            folderDialog.SelectedPath = rootPath;
            folderDialog.Description = Translate.FolderDialogDescription;

			if(folderDialog.ShowDialog()==DialogResult.OK)
			{
				rootPath=folderDialog.SelectedPath;

				FindResx(rootPath);

				treeViewResx.Nodes.Clear();
				foreach(ResourceHolder resource in resources.Values)
				{
					BuildTreeView(resource);
				}

				treeViewResx.ExpandAll();
			}
        }

		private void BuildTreeView(ResourceHolder resource)
		{
			TreeNode parentNode=null;
			string[] topFolders=resource.DisplayFolder.Split(new char[] {'\\'}, StringSplitOptions.RemoveEmptyEntries);

			foreach(string subFolder in topFolders)
			{
				TreeNodeCollection searchNodes=parentNode==null?treeViewResx.Nodes:parentNode.Nodes;
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

        private void FindResx(string folder)
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
                FindResx(subfolder);
            }
        }

        private void treeViewResx_DoubleClick(object sender, EventArgs e)
        {
            SelectResource();
        }

        private void OpenResource(ResourceHolder resource)
        {
            labelTitle.Text = resource.Id;
            checkedListBoxLanguages.Items.Clear();

            foreach (LanguageHolder languageHolder in resource.Languages.Values)
            {
                checkedListBoxLanguages.Items.Add(languageHolder, true);
            }

			gridResourcesStrings.DataSource=resource.StringsTable;

			gridResourcesStrings.Columns["Comment"].Visible=false;
			gridResourcesStrings.Columns["Translated"].Visible=false;
			gridResourcesStrings.Columns["Error"].Visible=false;

            ApplyFilterCondition();
        }

        private void checkedListBoxLanguages_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LanguageHolder languageHolder = checkedListBoxLanguages.Items[e.Index] as LanguageHolder;
            if (languageHolder == null)
                return;

			if(gridResourcesStrings==null)
			{
				// Not populated yet
				return;
			}

			if(gridResourcesStrings.Columns.Contains(languageHolder.Id))
			{
				gridResourcesStrings.Columns[languageHolder.Id].Visible=e.NewValue==CheckState.Checked;
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

		private void ApplyFilterCondition()
		{
			if(gridResourcesStrings==null)
			{
				return;
			}

			#region Farben
			for(int rowCounter=0; rowCounter<gridResourcesStrings.Rows.Count; rowCounter++)
			{
				//Farbe
				bool cellValue=false;

				if(gridResourcesStrings.Rows[rowCounter].Cells["Error"].Value!=null)
				{
					cellValue=(bool)gridResourcesStrings.Rows[rowCounter].Cells["Error"].Value;
				}

				if(cellValue==true)
				{
					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.Red;
					gridResourcesStrings.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
				else
				{
					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.White;
					gridResourcesStrings.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}

				//Translated
				bool translated=true;

				for(int i=0; i<gridResourcesStrings.Rows[rowCounter].Cells.Count; i++)
				{
					DataGridViewCell cell=gridResourcesStrings.Rows[rowCounter].Cells[i];

					if(gridResourcesStrings.Columns[i].HeaderText=="Translated") continue;
					if(gridResourcesStrings.Columns[i].HeaderText=="Error") continue;
					if(gridResourcesStrings.Columns[i].HeaderText=="Comment") continue;

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
					gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value=true;

					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.White;
					gridResourcesStrings.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
				else
				{
					gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value=false;

					DataGridViewCellStyle tmpStyle=new DataGridViewCellStyle();
					tmpStyle.BackColor=Color.Yellow;
					gridResourcesStrings.Rows[rowCounter].DefaultCellStyle=tmpStyle;
				}
			}

			
			#endregion

			#region Filter
			//Ersten Sichtbaren Entry suchen
			int firstVisibleEntry=-1;

			for(int rowCounter=0; rowCounter<gridResourcesStrings.Rows.Count; rowCounter++)
			{
				bool Translated=false;

				if(gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value!=null)
				{
					Translated=(bool)gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value;
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
				tslEntryCount.Text=String.Format(Translate.EntryCount, gridResourcesStrings.Rows.Count, visibleCount);
				return;
			}

			try
			{
				gridResourcesStrings.Rows[firstVisibleEntry].Visible=true;
				gridResourcesStrings.CurrentCell=gridResourcesStrings.Rows[firstVisibleEntry].Cells[0];
				visibleCount=0;
			}
			catch
			{
				tslEntryCount.Text=String.Format(Translate.EntryCount, gridResourcesStrings.Rows.Count, visibleCount);
				return;
			}

			for(int rowCounter=0; rowCounter<gridResourcesStrings.Rows.Count; rowCounter++)
			{
				bool Translated=false;

				if(gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value!=null)
				{
					Translated=(bool)gridResourcesStrings.Rows[rowCounter].Cells["Translated"].Value;
				}

				switch(filterMode)
				{
					case FilterMode.ShowAll:
						{
							gridResourcesStrings.Rows[rowCounter].Visible=true;
							visibleCount++;
							break;
						}
					case FilterMode.HideTranslated:
						{
							if(Translated)
							{
								gridResourcesStrings.Rows[rowCounter].Visible=false;
							}
							else
							{
								gridResourcesStrings.Rows[rowCounter].Visible=true;
								visibleCount++;
							}

							break;
						}
					case FilterMode.HideNonTranslated:
						{
							if(Translated)
							{
								gridResourcesStrings.Rows[rowCounter].Visible=true;
								visibleCount++;
							}
							else
							{
								gridResourcesStrings.Rows[rowCounter].Visible=false;
							}

							break;
						}
				}
			}
			#endregion

			tslEntryCount.Text=String.Format(Translate.EntryCount, gridResourcesStrings.Rows.Count, visibleCount);
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
			if(currentResource==null||gridResourcesStrings.RowCount==0)
			{
				return;
			}

			if(MessageBox.Show(Translate.AreYouSureYouWantToDeleteTheCurrentKey, Translate.DeleteKey, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes)
			{
				DataGridViewRow dataRow=gridResourcesStrings.Rows[gridResourcesStrings.SelectedCells[0].RowIndex]; //Determinate selected row
				gridResourcesStrings.Rows.Remove(dataRow); //Remove row
			}
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if(!CanClose())
			{
				return;
			}

            treeViewResx.Nodes.Clear();
            checkedListBoxLanguages.Items.Clear();

			gridResourcesStrings.DataSource=null;
			gridResourcesStrings.Columns.Clear();
			gridResourcesStrings.Rows.Clear();

            labelTitle.Visible = false;

            currentResource = null;
        }

        private void SelectResource()
        {
            TreeNode selectedTreeNode = treeViewResx.SelectedNode;
            if (selectedTreeNode == null)
                return;

            if (selectedTreeNode.Tag is PathHolder)
                return;

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
			//Versionsnummer in Titelleiste schreiben
			Assembly InstAssembly=Assembly.GetExecutingAssembly();
			Text+=" " + InstAssembly.GetName().Version.ToString();
		}

		private void menuStrip_MenuActivate(object sender, EventArgs e)
		{
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
    }
}

namespace Vertimas
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip=new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2=new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3=new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.showAllToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.hideTranslatedToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.hideNontranslatedToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.keysToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.addNewKeyToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.deleteKeyToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip=new System.Windows.Forms.ToolStrip();
			this.statusStrip=new System.Windows.Forms.StatusStrip();
			this.tslEntryCount=new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainerMain=new System.Windows.Forms.SplitContainer();
			this.treeViewResx=new System.Windows.Forms.TreeView();
			this.splitContainerResource=new System.Windows.Forms.SplitContainer();
			this.checkedListBoxLanguages=new System.Windows.Forms.CheckedListBox();
			this.gridResourcesStrings=new System.Windows.Forms.DataGridView();
			this.panelTitle=new System.Windows.Forms.Panel();
			this.labelTitle=new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.splitContainerResource.Panel1.SuspendLayout();
			this.splitContainerResource.Panel2.SuspendLayout();
			this.splitContainerResource.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResourcesStrings)).BeginInit();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.keysToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name="menuStrip";
			this.menuStrip.MenuActivate+=new System.EventHandler(this.menuStrip_MenuActivate);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name="fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name="openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click+=new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name="toolStripMenuItem2";
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name="saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Click+=new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name="toolStripMenuItem3";
			resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name="exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click+=new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.hideTranslatedToolStripMenuItem,
            this.hideNontranslatedToolStripMenuItem});
			this.settingsToolStripMenuItem.Name="settingsToolStripMenuItem";
			resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			// 
			// showAllToolStripMenuItem
			// 
			this.showAllToolStripMenuItem.Name="showAllToolStripMenuItem";
			resources.ApplyResources(this.showAllToolStripMenuItem, "showAllToolStripMenuItem");
			this.showAllToolStripMenuItem.Click+=new System.EventHandler(this.showAllToolStripMenuItem_Click);
			// 
			// hideTranslatedToolStripMenuItem
			// 
			this.hideTranslatedToolStripMenuItem.Name="hideTranslatedToolStripMenuItem";
			resources.ApplyResources(this.hideTranslatedToolStripMenuItem, "hideTranslatedToolStripMenuItem");
			this.hideTranslatedToolStripMenuItem.Click+=new System.EventHandler(this.hideTranslatedToolStripMenuItem_Click);
			// 
			// hideNontranslatedToolStripMenuItem
			// 
			this.hideNontranslatedToolStripMenuItem.Name="hideNontranslatedToolStripMenuItem";
			resources.ApplyResources(this.hideNontranslatedToolStripMenuItem, "hideNontranslatedToolStripMenuItem");
			this.hideNontranslatedToolStripMenuItem.Click+=new System.EventHandler(this.hideNontranslatedToolStripMenuItem_Click);
			// 
			// keysToolStripMenuItem
			// 
			this.keysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewKeyToolStripMenuItem,
            this.deleteKeyToolStripMenuItem});
			this.keysToolStripMenuItem.Name="keysToolStripMenuItem";
			resources.ApplyResources(this.keysToolStripMenuItem, "keysToolStripMenuItem");
			// 
			// addNewKeyToolStripMenuItem
			// 
			this.addNewKeyToolStripMenuItem.Name="addNewKeyToolStripMenuItem";
			resources.ApplyResources(this.addNewKeyToolStripMenuItem, "addNewKeyToolStripMenuItem");
			this.addNewKeyToolStripMenuItem.Click+=new System.EventHandler(this.addNewKeyToolStripMenuItem_Click);
			// 
			// deleteKeyToolStripMenuItem
			// 
			this.deleteKeyToolStripMenuItem.Name="deleteKeyToolStripMenuItem";
			resources.ApplyResources(this.deleteKeyToolStripMenuItem, "deleteKeyToolStripMenuItem");
			this.deleteKeyToolStripMenuItem.Click+=new System.EventHandler(this.deleteKeyToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name="helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click+=new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStrip
			// 
			resources.ApplyResources(this.toolStrip, "toolStrip");
			this.toolStrip.Name="toolStrip";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEntryCount});
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name="statusStrip";
			// 
			// tslEntryCount
			// 
			this.tslEntryCount.Name="tslEntryCount";
			resources.ApplyResources(this.tslEntryCount, "tslEntryCount");
			// 
			// splitContainerMain
			// 
			resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
			this.splitContainerMain.Name="splitContainerMain";
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.treeViewResx);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerResource);
			// 
			// treeViewResx
			// 
			resources.ApplyResources(this.treeViewResx, "treeViewResx");
			this.treeViewResx.HideSelection=false;
			this.treeViewResx.Name="treeViewResx";
			this.treeViewResx.AfterSelect+=new System.Windows.Forms.TreeViewEventHandler(this.treeViewResx_AfterSelect);
			// 
			// splitContainerResource
			// 
			resources.ApplyResources(this.splitContainerResource, "splitContainerResource");
			this.splitContainerResource.Name="splitContainerResource";
			// 
			// splitContainerResource.Panel1
			// 
			this.splitContainerResource.Panel1.Controls.Add(this.checkedListBoxLanguages);
			// 
			// splitContainerResource.Panel2
			// 
			this.splitContainerResource.Panel2.Controls.Add(this.gridResourcesStrings);
			this.splitContainerResource.Panel2.Controls.Add(this.panelTitle);
			// 
			// checkedListBoxLanguages
			// 
			this.checkedListBoxLanguages.CheckOnClick=true;
			resources.ApplyResources(this.checkedListBoxLanguages, "checkedListBoxLanguages");
			this.checkedListBoxLanguages.FormattingEnabled=true;
			this.checkedListBoxLanguages.MultiColumn=true;
			this.checkedListBoxLanguages.Name="checkedListBoxLanguages";
			this.checkedListBoxLanguages.ItemCheck+=new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLanguages_ItemCheck);
			// 
			// gridResourcesStrings
			// 
			this.gridResourcesStrings.AllowUserToAddRows=false;
			this.gridResourcesStrings.AllowUserToDeleteRows=false;
			this.gridResourcesStrings.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridResourcesStrings.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resources.ApplyResources(this.gridResourcesStrings, "gridResourcesStrings");
			this.gridResourcesStrings.MultiSelect=false;
			this.gridResourcesStrings.Name="gridResourcesStrings";
			this.gridResourcesStrings.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridResourcesStrings.DataSourceChanged+=new System.EventHandler(this.gridResourcesStrings_DataSourceChanged);
			this.gridResourcesStrings.CellEndEdit+=new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResourcesStrings_CellLeave);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			resources.ApplyResources(this.panelTitle, "panelTitle");
			this.panelTitle.Name="panelTitle";
			// 
			// labelTitle
			// 
			resources.ApplyResources(this.labelTitle, "labelTitle");
			this.labelTitle.Name="labelTitle";
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip=this.menuStrip;
			this.Name="FormMain";
			this.WindowState=System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing+=new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load+=new System.EventHandler(this.FormMain_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.ResumeLayout(false);
			this.splitContainerResource.Panel1.ResumeLayout(false);
			this.splitContainerResource.Panel2.ResumeLayout(false);
			this.splitContainerResource.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResourcesStrings)).EndInit();
			this.panelTitle.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		//private Janus.Windows.GridEX.GridEX gridEXStrings;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideNontranslatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteKeyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem hideTranslatedToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.TreeView treeViewResx;
		private System.Windows.Forms.SplitContainer splitContainerResource;
		private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
		private System.Windows.Forms.DataGridView gridResourcesStrings;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel tslEntryCount;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}


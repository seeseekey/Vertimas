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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideTranslatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideNontranslatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tslEntryCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.tvFolderStructure = new System.Windows.Forms.TreeView();
			this.splitContainerResource = new System.Windows.Forms.SplitContainer();
			this.checkedListBoxLanguages = new System.Windows.Forms.CheckedListBox();
			this.dgwResourceData = new System.Windows.Forms.DataGridView();
			this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addNewKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.cutFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.copyFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyFromNeutralLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.pasteFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.clearFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerResource)).BeginInit();
			this.splitContainerResource.Panel1.SuspendLayout();
			this.splitContainerResource.Panel2.SuspendLayout();
			this.splitContainerResource.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwResourceData)).BeginInit();
			this.cmsDataGridView.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.keysToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.MenuActivate += new System.EventHandler(this.menuStrip_MenuActivate);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recentProjectsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			// 
			// recentProjectsToolStripMenuItem
			// 
			this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
			resources.ApplyResources(this.recentProjectsToolStripMenuItem, "recentProjectsToolStripMenuItem");
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.hideTranslatedToolStripMenuItem,
            this.hideNontranslatedToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			// 
			// showAllToolStripMenuItem
			// 
			this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
			resources.ApplyResources(this.showAllToolStripMenuItem, "showAllToolStripMenuItem");
			this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
			// 
			// hideTranslatedToolStripMenuItem
			// 
			this.hideTranslatedToolStripMenuItem.Name = "hideTranslatedToolStripMenuItem";
			resources.ApplyResources(this.hideTranslatedToolStripMenuItem, "hideTranslatedToolStripMenuItem");
			this.hideTranslatedToolStripMenuItem.Click += new System.EventHandler(this.hideTranslatedToolStripMenuItem_Click);
			// 
			// hideNontranslatedToolStripMenuItem
			// 
			this.hideNontranslatedToolStripMenuItem.Name = "hideNontranslatedToolStripMenuItem";
			resources.ApplyResources(this.hideNontranslatedToolStripMenuItem, "hideNontranslatedToolStripMenuItem");
			this.hideNontranslatedToolStripMenuItem.Click += new System.EventHandler(this.hideNontranslatedToolStripMenuItem_Click);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLanguageToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
			// 
			// addNewLanguageToolStripMenuItem
			// 
			this.addNewLanguageToolStripMenuItem.Name = "addNewLanguageToolStripMenuItem";
			resources.ApplyResources(this.addNewLanguageToolStripMenuItem, "addNewLanguageToolStripMenuItem");
			this.addNewLanguageToolStripMenuItem.Click += new System.EventHandler(this.addNewLanguageToolStripMenuItem_Click);
			// 
			// keysToolStripMenuItem
			// 
			this.keysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewKeyToolStripMenuItem,
            this.deleteKeyToolStripMenuItem});
			this.keysToolStripMenuItem.Name = "keysToolStripMenuItem";
			resources.ApplyResources(this.keysToolStripMenuItem, "keysToolStripMenuItem");
			// 
			// addNewKeyToolStripMenuItem
			// 
			this.addNewKeyToolStripMenuItem.Name = "addNewKeyToolStripMenuItem";
			resources.ApplyResources(this.addNewKeyToolStripMenuItem, "addNewKeyToolStripMenuItem");
			this.addNewKeyToolStripMenuItem.Click += new System.EventHandler(this.addNewKeyToolStripMenuItem_Click);
			// 
			// deleteKeyToolStripMenuItem
			// 
			this.deleteKeyToolStripMenuItem.Name = "deleteKeyToolStripMenuItem";
			resources.ApplyResources(this.deleteKeyToolStripMenuItem, "deleteKeyToolStripMenuItem");
			this.deleteKeyToolStripMenuItem.Click += new System.EventHandler(this.deleteKeyToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStrip
			// 
			resources.ApplyResources(this.toolStrip, "toolStrip");
			this.toolStrip.Name = "toolStrip";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEntryCount});
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name = "statusStrip";
			// 
			// tslEntryCount
			// 
			this.tslEntryCount.Name = "tslEntryCount";
			resources.ApplyResources(this.tslEntryCount, "tslEntryCount");
			// 
			// splitContainerMain
			// 
			resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
			this.splitContainerMain.Name = "splitContainerMain";
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.tvFolderStructure);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerResource);
			// 
			// tvFolderStructure
			// 
			resources.ApplyResources(this.tvFolderStructure, "tvFolderStructure");
			this.tvFolderStructure.HideSelection = false;
			this.tvFolderStructure.Name = "tvFolderStructure";
			this.tvFolderStructure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewResx_AfterSelect);
			// 
			// splitContainerResource
			// 
			resources.ApplyResources(this.splitContainerResource, "splitContainerResource");
			this.splitContainerResource.Name = "splitContainerResource";
			// 
			// splitContainerResource.Panel1
			// 
			this.splitContainerResource.Panel1.Controls.Add(this.checkedListBoxLanguages);
			// 
			// splitContainerResource.Panel2
			// 
			this.splitContainerResource.Panel2.Controls.Add(this.dgwResourceData);
			this.splitContainerResource.Panel2.Controls.Add(this.panelTitle);
			// 
			// checkedListBoxLanguages
			// 
			this.checkedListBoxLanguages.CheckOnClick = true;
			resources.ApplyResources(this.checkedListBoxLanguages, "checkedListBoxLanguages");
			this.checkedListBoxLanguages.FormattingEnabled = true;
			this.checkedListBoxLanguages.MultiColumn = true;
			this.checkedListBoxLanguages.Name = "checkedListBoxLanguages";
			this.checkedListBoxLanguages.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLanguages_ItemCheck);
			// 
			// dgwResourceData
			// 
			this.dgwResourceData.AllowUserToAddRows = false;
			this.dgwResourceData.AllowUserToDeleteRows = false;
			this.dgwResourceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwResourceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwResourceData.ContextMenuStrip = this.cmsDataGridView;
			resources.ApplyResources(this.dgwResourceData, "dgwResourceData");
			this.dgwResourceData.MultiSelect = false;
			this.dgwResourceData.Name = "dgwResourceData";
			this.dgwResourceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgwResourceData.DataSourceChanged += new System.EventHandler(this.gridResourcesStrings_DataSourceChanged);
			this.dgwResourceData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResourcesStrings_CellLeave);
			// 
			// cmsDataGridView
			// 
			this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewKeyToolStripMenuItem1,
            this.deleteKeyToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.cutFieldToolStripMenuItem,
            this.toolStripMenuItem7,
            this.copyFieldToolStripMenuItem,
            this.copyFromNeutralLanguageToolStripMenuItem,
            this.toolStripMenuItem8,
            this.pasteFieldToolStripMenuItem,
            this.toolStripMenuItem6,
            this.clearFieldToolStripMenuItem});
			this.cmsDataGridView.Name = "cmsDataGridView";
			resources.ApplyResources(this.cmsDataGridView, "cmsDataGridView");
			// 
			// addNewKeyToolStripMenuItem1
			// 
			this.addNewKeyToolStripMenuItem1.Name = "addNewKeyToolStripMenuItem1";
			resources.ApplyResources(this.addNewKeyToolStripMenuItem1, "addNewKeyToolStripMenuItem1");
			this.addNewKeyToolStripMenuItem1.Click += new System.EventHandler(this.addNewKeyToolStripMenuItem_Click);
			// 
			// deleteKeyToolStripMenuItem1
			// 
			this.deleteKeyToolStripMenuItem1.Name = "deleteKeyToolStripMenuItem1";
			resources.ApplyResources(this.deleteKeyToolStripMenuItem1, "deleteKeyToolStripMenuItem1");
			this.deleteKeyToolStripMenuItem1.Click += new System.EventHandler(this.deleteKeyToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
			// 
			// cutFieldToolStripMenuItem
			// 
			this.cutFieldToolStripMenuItem.Name = "cutFieldToolStripMenuItem";
			resources.ApplyResources(this.cutFieldToolStripMenuItem, "cutFieldToolStripMenuItem");
			this.cutFieldToolStripMenuItem.Click += new System.EventHandler(this.cutFieldToolStripMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
			// 
			// copyFieldToolStripMenuItem
			// 
			this.copyFieldToolStripMenuItem.Name = "copyFieldToolStripMenuItem";
			resources.ApplyResources(this.copyFieldToolStripMenuItem, "copyFieldToolStripMenuItem");
			this.copyFieldToolStripMenuItem.Click += new System.EventHandler(this.copyFieldToolStripMenuItem_Click);
			// 
			// copyFromNeutralLanguageToolStripMenuItem
			// 
			this.copyFromNeutralLanguageToolStripMenuItem.Name = "copyFromNeutralLanguageToolStripMenuItem";
			resources.ApplyResources(this.copyFromNeutralLanguageToolStripMenuItem, "copyFromNeutralLanguageToolStripMenuItem");
			this.copyFromNeutralLanguageToolStripMenuItem.Click += new System.EventHandler(this.copyFromNeutralLanguageToolStripMenuItem_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
			// 
			// pasteFieldToolStripMenuItem
			// 
			this.pasteFieldToolStripMenuItem.Name = "pasteFieldToolStripMenuItem";
			resources.ApplyResources(this.pasteFieldToolStripMenuItem, "pasteFieldToolStripMenuItem");
			this.pasteFieldToolStripMenuItem.Click += new System.EventHandler(this.pasteFieldToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
			// 
			// clearFieldToolStripMenuItem
			// 
			this.clearFieldToolStripMenuItem.Name = "clearFieldToolStripMenuItem";
			resources.ApplyResources(this.clearFieldToolStripMenuItem, "clearFieldToolStripMenuItem");
			this.clearFieldToolStripMenuItem.Click += new System.EventHandler(this.clearFieldToolStripMenuItem_Click);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			resources.ApplyResources(this.panelTitle, "panelTitle");
			this.panelTitle.Name = "panelTitle";
			// 
			// labelTitle
			// 
			resources.ApplyResources(this.labelTitle, "labelTitle");
			this.labelTitle.Name = "labelTitle";
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.splitContainerResource.Panel1.ResumeLayout(false);
			this.splitContainerResource.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerResource)).EndInit();
			this.splitContainerResource.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwResourceData)).EndInit();
			this.cmsDataGridView.ResumeLayout(false);
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
		private System.Windows.Forms.TreeView tvFolderStructure;
		private System.Windows.Forms.SplitContainer splitContainerResource;
		private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
		private System.Windows.Forms.DataGridView dgwResourceData;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel tslEntryCount;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
		private System.Windows.Forms.ToolStripMenuItem addNewKeyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteKeyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewLanguageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem copyFromNeutralLanguageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem cutFieldToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
	}
}


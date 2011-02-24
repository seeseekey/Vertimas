namespace Vertimas
{
	partial class FormAbout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing&&(components!=null))
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
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.logoPictureBox=new System.Windows.Forms.PictureBox();
			this.labelProductName=new System.Windows.Forms.Label();
			this.labelVersion=new System.Windows.Forms.Label();
			this.labelCopyright=new System.Windows.Forms.Label();
			this.okButton=new System.Windows.Forms.Button();
			this.linkLabel=new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
			this.logoPictureBox.Name="logoPictureBox";
			this.logoPictureBox.TabStop=false;
			// 
			// labelProductName
			// 
			resources.ApplyResources(this.labelProductName, "labelProductName");
			this.labelProductName.Name="labelProductName";
			// 
			// labelVersion
			// 
			resources.ApplyResources(this.labelVersion, "labelVersion");
			this.labelVersion.Name="labelVersion";
			// 
			// labelCopyright
			// 
			resources.ApplyResources(this.labelCopyright, "labelCopyright");
			this.labelCopyright.Name="labelCopyright";
			// 
			// okButton
			// 
			resources.ApplyResources(this.okButton, "okButton");
			this.okButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Name="okButton";
			// 
			// linkLabel
			// 
			resources.ApplyResources(this.linkLabel, "linkLabel");
			this.linkLabel.Name="linkLabel";
			this.linkLabel.TabStop=true;
			this.linkLabel.LinkClicked+=new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// FormAbout
			// 
			this.AcceptButton=this.okButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="FormAbout";
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.LinkLabel linkLabel;
	}
}

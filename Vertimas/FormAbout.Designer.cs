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
			this.logoPictureBox.Image=((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location=new System.Drawing.Point(12, 6);
			this.logoPictureBox.Name="logoPictureBox";
			this.logoPictureBox.Size=new System.Drawing.Size(131, 135);
			this.logoPictureBox.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex=12;
			this.logoPictureBox.TabStop=false;
			// 
			// labelProductName
			// 
			this.labelProductName.Font=new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProductName.Location=new System.Drawing.Point(152, 6);
			this.labelProductName.Margin=new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.Name="labelProductName";
			this.labelProductName.Size=new System.Drawing.Size(271, 32);
			this.labelProductName.TabIndex=19;
			this.labelProductName.Text="Product Name";
			this.labelProductName.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			this.labelVersion.Location=new System.Drawing.Point(153, 49);
			this.labelVersion.Margin=new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.Name="labelVersion";
			this.labelVersion.Size=new System.Drawing.Size(270, 17);
			this.labelVersion.TabIndex=0;
			this.labelVersion.Text="Version";
			this.labelVersion.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCopyright
			// 
			this.labelCopyright.Location=new System.Drawing.Point(152, 66);
			this.labelCopyright.Margin=new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.Name="labelCopyright";
			this.labelCopyright.Size=new System.Drawing.Size(271, 22);
			this.labelCopyright.TabIndex=21;
			this.labelCopyright.Text="Copyright";
			this.labelCopyright.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// okButton
			// 
			this.okButton.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom|System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location=new System.Drawing.Point(156, 118);
			this.okButton.Name="okButton";
			this.okButton.Size=new System.Drawing.Size(267, 23);
			this.okButton.TabIndex=24;
			this.okButton.Text="&OK";
			// 
			// linkLabel
			// 
			this.linkLabel.AutoSize=true;
			this.linkLabel.Font=new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.linkLabel.ImeMode=System.Windows.Forms.ImeMode.NoControl;
			this.linkLabel.Location=new System.Drawing.Point(153, 88);
			this.linkLabel.Name="linkLabel";
			this.linkLabel.Size=new System.Drawing.Size(189, 13);
			this.linkLabel.TabIndex=25;
			this.linkLabel.TabStop=true;
			this.linkLabel.Text="http://vertimas.googlecode.com";
			this.linkLabel.LinkClicked+=new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// FormAbout
			// 
			this.AcceptButton=this.okButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize=new System.Drawing.Size(435, 151);
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
			this.Padding=new System.Windows.Forms.Padding(9);
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text="FormAbout";
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

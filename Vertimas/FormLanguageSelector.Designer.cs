namespace Vertimas
{
	partial class FormLanguageSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.btnOk=new System.Windows.Forms.Button();
			this.lvLanguages=new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location=new System.Drawing.Point(0, 242);
			this.btnOk.Name="btnOk";
			this.btnOk.Size=new System.Drawing.Size(302, 23);
			this.btnOk.TabIndex=1;
			this.btnOk.Text="&OK";
			this.btnOk.UseVisualStyleBackColor=true;
			this.btnOk.Click+=new System.EventHandler(this.btnOk_Click);
			// 
			// lvLanguages
			// 
			this.lvLanguages.AutoArrange=false;
			this.lvLanguages.Dock=System.Windows.Forms.DockStyle.Top;
			this.lvLanguages.FullRowSelect=true;
			this.lvLanguages.Location=new System.Drawing.Point(0, 0);
			this.lvLanguages.Name="lvLanguages";
			this.lvLanguages.Size=new System.Drawing.Size(302, 236);
			this.lvLanguages.TabIndex=2;
			this.lvLanguages.UseCompatibleStateImageBehavior=false;
			this.lvLanguages.View=System.Windows.Forms.View.Details;
			// 
			// FormLanguageSelector
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize=new System.Drawing.Size(302, 268);
			this.Controls.Add(this.lvLanguages);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="FormLanguageSelector";
			this.StartPosition=System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text="Select language";
			this.Load+=new System.EventHandler(this.FormLanguageSelector_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView lvLanguages;
	}
}
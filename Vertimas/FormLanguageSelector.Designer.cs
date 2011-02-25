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
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(FormLanguageSelector));
			this.btnOk=new System.Windows.Forms.Button();
			this.lvLanguages=new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			resources.ApplyResources(this.btnOk, "btnOk");
			this.btnOk.Name="btnOk";
			this.btnOk.UseVisualStyleBackColor=true;
			this.btnOk.Click+=new System.EventHandler(this.btnOk_Click);
			// 
			// lvLanguages
			// 
			this.lvLanguages.AutoArrange=false;
			resources.ApplyResources(this.lvLanguages, "lvLanguages");
			this.lvLanguages.FullRowSelect=true;
			this.lvLanguages.Name="lvLanguages";
			this.lvLanguages.UseCompatibleStateImageBehavior=false;
			this.lvLanguages.View=System.Windows.Forms.View.Details;
			// 
			// FormLanguageSelector
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvLanguages);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="FormLanguageSelector";
			this.Load+=new System.EventHandler(this.FormLanguageSelector_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView lvLanguages;
	}
}
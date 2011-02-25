namespace Vertimas
{
    partial class FormAddKey
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
			this.components=new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(FormAddKey));
			this.labelKey=new System.Windows.Forms.Label();
			this.labelNoXlateValue=new System.Windows.Forms.Label();
			this.txtKey=new System.Windows.Forms.TextBox();
			this.txtNeutralValue=new System.Windows.Forms.TextBox();
			this.btnAdd=new System.Windows.Forms.Button();
			this.labelDefaultValue=new System.Windows.Forms.Label();
			this.txtDefaultValue=new System.Windows.Forms.TextBox();
			this.errorProvider=new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// labelKey
			// 
			resources.ApplyResources(this.labelKey, "labelKey");
			this.errorProvider.SetError(this.labelKey, resources.GetString("labelKey.Error"));
			this.errorProvider.SetIconAlignment(this.labelKey, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelKey.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.labelKey, ((int)(resources.GetObject("labelKey.IconPadding"))));
			this.labelKey.Name="labelKey";
			// 
			// labelNoXlateValue
			// 
			resources.ApplyResources(this.labelNoXlateValue, "labelNoXlateValue");
			this.errorProvider.SetError(this.labelNoXlateValue, resources.GetString("labelNoXlateValue.Error"));
			this.errorProvider.SetIconAlignment(this.labelNoXlateValue, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelNoXlateValue.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.labelNoXlateValue, ((int)(resources.GetObject("labelNoXlateValue.IconPadding"))));
			this.labelNoXlateValue.Name="labelNoXlateValue";
			// 
			// txtKey
			// 
			resources.ApplyResources(this.txtKey, "txtKey");
			this.errorProvider.SetError(this.txtKey, resources.GetString("txtKey.Error"));
			this.errorProvider.SetIconAlignment(this.txtKey, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKey.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtKey, ((int)(resources.GetObject("txtKey.IconPadding"))));
			this.txtKey.Name="txtKey";
			this.txtKey.TextChanged+=new System.EventHandler(this.txtKey_TextChanged);
			// 
			// txtNeutralValue
			// 
			resources.ApplyResources(this.txtNeutralValue, "txtNeutralValue");
			this.errorProvider.SetError(this.txtNeutralValue, resources.GetString("txtNeutralValue.Error"));
			this.errorProvider.SetIconAlignment(this.txtNeutralValue, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNeutralValue.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtNeutralValue, ((int)(resources.GetObject("txtNeutralValue.IconPadding"))));
			this.txtNeutralValue.Name="txtNeutralValue";
			// 
			// btnAdd
			// 
			resources.ApplyResources(this.btnAdd, "btnAdd");
			this.btnAdd.DialogResult=System.Windows.Forms.DialogResult.OK;
			this.errorProvider.SetError(this.btnAdd, resources.GetString("btnAdd.Error"));
			this.errorProvider.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding"))));
			this.btnAdd.Name="btnAdd";
			this.btnAdd.UseVisualStyleBackColor=true;
			// 
			// labelDefaultValue
			// 
			resources.ApplyResources(this.labelDefaultValue, "labelDefaultValue");
			this.errorProvider.SetError(this.labelDefaultValue, resources.GetString("labelDefaultValue.Error"));
			this.errorProvider.SetIconAlignment(this.labelDefaultValue, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelDefaultValue.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.labelDefaultValue, ((int)(resources.GetObject("labelDefaultValue.IconPadding"))));
			this.labelDefaultValue.Name="labelDefaultValue";
			// 
			// txtDefaultValue
			// 
			resources.ApplyResources(this.txtDefaultValue, "txtDefaultValue");
			this.errorProvider.SetError(this.txtDefaultValue, resources.GetString("txtDefaultValue.Error"));
			this.errorProvider.SetIconAlignment(this.txtDefaultValue, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDefaultValue.IconAlignment"))));
			this.errorProvider.SetIconPadding(this.txtDefaultValue, ((int)(resources.GetObject("txtDefaultValue.IconPadding"))));
			this.txtDefaultValue.Name="txtDefaultValue";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl=this;
			resources.ApplyResources(this.errorProvider, "errorProvider");
			// 
			// FormAddKey
			// 
			this.AcceptButton=this.btnAdd;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtDefaultValue);
			this.Controls.Add(this.labelDefaultValue);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtNeutralValue);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.labelNoXlateValue);
			this.Controls.Add(this.labelKey);
			this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name="FormAddKey";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelNoXlateValue;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtNeutralValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelDefaultValue;
        private System.Windows.Forms.TextBox txtDefaultValue;
    }
}
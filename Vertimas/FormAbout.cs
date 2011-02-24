using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Vertimas
{
	partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
			this.Text=String.Format("About {0}", AssemblyTitle);
			this.labelProductName.Text=AssemblyProduct;
			this.labelVersion.Text=String.Format("Version {0}", AssemblyVersion);
			this.labelCopyright.Text=AssemblyCopyright;
		}

		#region Assembly Attribute Accessors

		public string AssemblyTitle
		{
			get
			{
				object[] attributes=Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if(attributes.Length>0)
				{
					AssemblyTitleAttribute titleAttribute=(AssemblyTitleAttribute)attributes[0];
					if(titleAttribute.Title!="")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes=Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if(attributes.Length==0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes=Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if(attributes.Length==0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes=Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if(attributes.Length==0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes=Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if(attributes.Length==0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Webbrowser mit Doamin aufrufen
			System.Diagnostics.Process p=new System.Diagnostics.Process();
			p.StartInfo.RedirectStandardOutput=false;
			p.StartInfo.FileName="http://vertimas.googlecode.com";
			p.StartInfo.UseShellExecute=true;
			p.Start();
		}
	}
}

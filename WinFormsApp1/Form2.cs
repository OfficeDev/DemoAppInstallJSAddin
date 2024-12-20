using Microsoft.Win32;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!checkBox1.Checked)
			{
				return;
			}

		//Write register key for {addinName} Addin Installed, Word/Excel/PowerPoint
		RegistryKey hklm = Registry.CurrentUser;
			//RegistryKey baseKey = Registry.CurrentUser.OpenSubKey(basePath);
			RegistryKey existingKey = hklm.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Wef\\AutoInstallAddins\\Word");
			if (existingKey != null)
			{
				hklm.DeleteSubKeyTree("Software\\Microsoft\\Office\\16.0\\Wef\\AutoInstallAddins\\Word");
			}

			RegistryKey software = hklm.CreateSubKey("Software\\Microsoft\\Office\\16.0\\Wef\\AutoInstallAddins\\Word\\Scriptlab");
			if (software != null)
			{
				software.SetValue("AssetIds", "WA104380862");
				//you can use WA104382081 for word as mendeleycit, WA104099688 wikipidia for excel , WA104380955 is silent , WA104380862 is scriptlab

				//set this value if the Privacy Consent has been shown on the main app installation widget, this is must have for silent-install
				software.SetValue("HasPrivacyLink", 1);
			}

			this.Close();
			Form3 frm = new Form3();
			frm.Show();


		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://appsource.microsoft.com/en-us/product/office/WA104380862?tab=Overview");
		}
	}
}

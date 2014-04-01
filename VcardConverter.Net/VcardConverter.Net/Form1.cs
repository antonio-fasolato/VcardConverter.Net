using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VcardConverter.Net {
	using Logger;

	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			dlgOpenFile.Multiselect = true;
			dlgOpenFile.Filter = "vCard (*.vcf)|*.vcf|All files|*.*";
		}

		private void btnAddFile_Click(object sender, EventArgs e) {
			if (dlgOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				foreach (string s in dlgOpenFile.FileNames) {
					Logger.debug(s, "VcardConverter.Net", "btnAddFile_Click");
				}
			}
		}
	}
}

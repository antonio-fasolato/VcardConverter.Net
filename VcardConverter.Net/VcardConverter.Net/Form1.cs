using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VcardConverter.Net {
	using Logger;

	public partial class Form1 : Form {
		List<Vcard> cards;

		public Form1() {
			InitializeComponent();

			cards = new List<Vcard>();

			dlgOpenFile.Multiselect = true;
			dlgOpenFile.Filter = "vCard (*.vcf)|*.vcf|All files|*.*";

			dlgOpenFolder.ShowNewFolderButton = false;

			refreshList();
		}

		private void refreshList() {
			vcardBindingSource.Clear();

			foreach (Vcard v in cards) {
				vcardBindingSource.Add(v);
			}
		}

		private void btnAddFile_Click(object sender, EventArgs e) {
			if (dlgOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				foreach (string s in dlgOpenFile.FileNames) {
					cards.Add(new Vcard(s));
				}

				refreshList();
			}
		}

		private void btnAddFolder_Click(object sender, EventArgs e) {
			if (dlgOpenFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				DirectoryInfo d = new DirectoryInfo(dlgOpenFolder.SelectedPath);
				foreach (FileInfo f in d.GetFiles()) {
					cards.Add(new Vcard(f.FullName));
				}

				refreshList();
			}
		}
	}
}

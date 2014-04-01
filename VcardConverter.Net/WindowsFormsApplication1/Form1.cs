using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
	using VcardLib;
	using Logger;

	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			string filename = @"c:\users\ut0729\Dropbox\Backup nokia Marie\Others\Contacts\Alice Paolin.vcf";
			VcardReader reader = new VcardReader();

			try {
				//reader.addFile(filename);
				reader.addDir(@"c:\users\ut0729\Dropbox\Backup nokia Marie\Others\Contacts");
				foreach (Vcard v in reader.cards) {
					Logger.debug(v.info, "Form1", "button1_Click");
				}
			} catch (Exception ex) {
				Logger.err(ex, "Form1", "button1_Click");
			}
		}
	}
}

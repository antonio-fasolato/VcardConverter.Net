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

	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			VcardReader.read(new Uri(@"c:\users\ut0729\Dropbox\Backup nokia Marie\Others\Contacts\Alice Paolin.vcf"));
		}
	}
}

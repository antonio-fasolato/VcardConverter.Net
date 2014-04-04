namespace VcardConverter.Net {
	partial class Form1 {
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnAddFile = new System.Windows.Forms.Button();
			this.btnAddFolder = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.tblFiles = new System.Windows.Forms.DataGridView();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vcardBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblFiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vcardBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(943, 676);
			this.splitContainer1.SplitterDistance = 523;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tblFiles);
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(943, 523);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnAddFile);
			this.flowLayoutPanel1.Controls.Add(this.btnAddFolder);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(937, 30);
			this.flowLayoutPanel1.TabIndex = 2;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// btnAddFile
			// 
			this.btnAddFile.Location = new System.Drawing.Point(859, 3);
			this.btnAddFile.Name = "btnAddFile";
			this.btnAddFile.Size = new System.Drawing.Size(75, 23);
			this.btnAddFile.TabIndex = 0;
			this.btnAddFile.Text = "Add file";
			this.btnAddFile.UseVisualStyleBackColor = true;
			this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
			// 
			// btnAddFolder
			// 
			this.btnAddFolder.Location = new System.Drawing.Point(778, 3);
			this.btnAddFolder.Name = "btnAddFolder";
			this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
			this.btnAddFolder.TabIndex = 1;
			this.btnAddFolder.Text = "Add folder";
			this.btnAddFolder.UseVisualStyleBackColor = true;
			this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(943, 149);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output";
			// 
			// tblFiles
			// 
			this.tblFiles.AllowUserToAddRows = false;
			this.tblFiles.AllowUserToDeleteRows = false;
			this.tblFiles.AllowUserToResizeRows = false;
			this.tblFiles.AutoGenerateColumns = false;
			this.tblFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.tblFiles.BackgroundColor = System.Drawing.SystemColors.Control;
			this.tblFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn});
			this.tblFiles.DataSource = this.vcardBindingSource;
			this.tblFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblFiles.Location = new System.Drawing.Point(3, 46);
			this.tblFiles.Name = "tblFiles";
			this.tblFiles.ReadOnly = true;
			this.tblFiles.RowHeadersWidth = 4;
			this.tblFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblFiles.ShowCellErrors = false;
			this.tblFiles.ShowEditingIcon = false;
			this.tblFiles.ShowRowErrors = false;
			this.tblFiles.Size = new System.Drawing.Size(937, 474);
			this.tblFiles.TabIndex = 3;
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			this.infoDataGridViewTextBoxColumn.ReadOnly = true;
			this.infoDataGridViewTextBoxColumn.Width = 49;
			// 
			// filenameDataGridViewTextBoxColumn
			// 
			this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
			this.filenameDataGridViewTextBoxColumn.HeaderText = "filename";
			this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
			this.filenameDataGridViewTextBoxColumn.ReadOnly = true;
			this.filenameDataGridViewTextBoxColumn.Width = 71;
			// 
			// vcardBindingSource
			// 
			this.vcardBindingSource.DataSource = typeof(VcardConverter.Net.Vcard);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 676);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tblFiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vcardBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAddFolder;
		private System.Windows.Forms.Button btnAddFile;
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.DataGridView tblFiles;
		private System.Windows.Forms.BindingSource vcardBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;

	}
}


namespace LKS_ITSoftware
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_studentLabel;
            System.Windows.Forms.Label id_categoryLabel;
            System.Windows.Forms.Label violation_dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label counseling_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idrecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idreporteruserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counselingstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_siskom_smeasDataSet = new LKS_ITSoftware.db_siskom_smeasDataSet();
            this.violation_recordsTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.violation_recordsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.studentsTableAdapter();
            this.violation_categoriesTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.violation_categoriesTableAdapter();
            this.id_studentComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_categoryComboBox = new System.Windows.Forms.ComboBox();
            this.violationcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.violation_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.counseling_statusTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_studentLabel = new System.Windows.Forms.Label();
            id_categoryLabel = new System.Windows.Forms.Label();
            violation_dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            counseling_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_studentLabel
            // 
            id_studentLabel.AutoSize = true;
            id_studentLabel.Location = new System.Drawing.Point(46, 48);
            id_studentLabel.Name = "id_studentLabel";
            id_studentLabel.Size = new System.Drawing.Size(83, 20);
            id_studentLabel.TabIndex = 1;
            id_studentLabel.Text = "id student:";
            // 
            // id_categoryLabel
            // 
            id_categoryLabel.AutoSize = true;
            id_categoryLabel.Location = new System.Drawing.Point(46, 82);
            id_categoryLabel.Name = "id_categoryLabel";
            id_categoryLabel.Size = new System.Drawing.Size(90, 20);
            id_categoryLabel.TabIndex = 3;
            id_categoryLabel.Text = "id category:";
            // 
            // violation_dateLabel
            // 
            violation_dateLabel.AutoSize = true;
            violation_dateLabel.Location = new System.Drawing.Point(46, 117);
            violation_dateLabel.Name = "violation_dateLabel";
            violation_dateLabel.Size = new System.Drawing.Size(106, 20);
            violation_dateLabel.TabIndex = 5;
            violation_dateLabel.Text = "violation date:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(46, 148);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(90, 20);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "description:";
            // 
            // counseling_statusLabel
            // 
            counseling_statusLabel.AutoSize = true;
            counseling_statusLabel.Location = new System.Drawing.Point(46, 250);
            counseling_statusLabel.Name = "counseling_statusLabel";
            counseling_statusLabel.Size = new System.Drawing.Size(137, 20);
            counseling_statusLabel.TabIndex = 9;
            counseling_statusLabel.Text = "counseling status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrecordDataGridViewTextBoxColumn,
            this.idstudentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.idreporteruserDataGridViewTextBoxColumn,
            this.counselingstatusDataGridViewTextBoxColumn,
            this.violationdateDataGridViewTextBoxColumn,
            this.idcategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.violationrecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(479, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 433);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idrecordDataGridViewTextBoxColumn
            // 
            this.idrecordDataGridViewTextBoxColumn.DataPropertyName = "id_record";
            this.idrecordDataGridViewTextBoxColumn.HeaderText = "id_record";
            this.idrecordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idrecordDataGridViewTextBoxColumn.Name = "idrecordDataGridViewTextBoxColumn";
            this.idrecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrecordDataGridViewTextBoxColumn.Visible = false;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "Nama Siswa";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idreporteruserDataGridViewTextBoxColumn
            // 
            this.idreporteruserDataGridViewTextBoxColumn.DataPropertyName = "id_reporter_user";
            this.idreporteruserDataGridViewTextBoxColumn.HeaderText = "Nama Pelapor";
            this.idreporteruserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idreporteruserDataGridViewTextBoxColumn.Name = "idreporteruserDataGridViewTextBoxColumn";
            this.idreporteruserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // counselingstatusDataGridViewTextBoxColumn
            // 
            this.counselingstatusDataGridViewTextBoxColumn.DataPropertyName = "counseling_status";
            this.counselingstatusDataGridViewTextBoxColumn.HeaderText = "Status Konseling";
            this.counselingstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.counselingstatusDataGridViewTextBoxColumn.Name = "counselingstatusDataGridViewTextBoxColumn";
            this.counselingstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // violationdateDataGridViewTextBoxColumn
            // 
            this.violationdateDataGridViewTextBoxColumn.DataPropertyName = "violation_date";
            this.violationdateDataGridViewTextBoxColumn.HeaderText = "Tanggal Pelanggaran";
            this.violationdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.violationdateDataGridViewTextBoxColumn.Name = "violationdateDataGridViewTextBoxColumn";
            this.violationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcategoryDataGridViewTextBoxColumn
            // 
            this.idcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.HeaderText = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcategoryDataGridViewTextBoxColumn.Name = "idcategoryDataGridViewTextBoxColumn";
            this.idcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // violationrecordsBindingSource
            // 
            this.violationrecordsBindingSource.DataMember = "violation_records";
            this.violationrecordsBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // db_siskom_smeasDataSet
            // 
            this.db_siskom_smeasDataSet.DataSetName = "db_siskom_smeasDataSet";
            this.db_siskom_smeasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violation_recordsTableAdapter
            // 
            this.violation_recordsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "violation_records";
            this.bindingSource1.DataSource = this.db_siskom_smeasDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classesTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.violation_categoriesTableAdapter = this.violation_categoriesTableAdapter;
            this.tableAdapterManager.violation_recordsTableAdapter = this.violation_recordsTableAdapter;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // violation_categoriesTableAdapter
            // 
            this.violation_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // id_studentComboBox
            // 
            this.id_studentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "id_student", true));
            this.id_studentComboBox.DataSource = this.studentsBindingSource;
            this.id_studentComboBox.DisplayMember = "full_name";
            this.id_studentComboBox.FormattingEnabled = true;
            this.id_studentComboBox.Location = new System.Drawing.Point(189, 45);
            this.id_studentComboBox.Name = "id_studentComboBox";
            this.id_studentComboBox.Size = new System.Drawing.Size(261, 28);
            this.id_studentComboBox.TabIndex = 2;
            this.id_studentComboBox.ValueMember = "id_student";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // id_categoryComboBox
            // 
            this.id_categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "id_category", true));
            this.id_categoryComboBox.DataSource = this.violationcategoriesBindingSource;
            this.id_categoryComboBox.DisplayMember = "category_name";
            this.id_categoryComboBox.FormattingEnabled = true;
            this.id_categoryComboBox.Location = new System.Drawing.Point(189, 79);
            this.id_categoryComboBox.Name = "id_categoryComboBox";
            this.id_categoryComboBox.Size = new System.Drawing.Size(261, 28);
            this.id_categoryComboBox.TabIndex = 4;
            this.id_categoryComboBox.ValueMember = "id_category";
            // 
            // violationcategoriesBindingSource
            // 
            this.violationcategoriesBindingSource.DataMember = "violation_categories";
            this.violationcategoriesBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // violation_dateDateTimePicker
            // 
            this.violation_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "violation_date", true));
            this.violation_dateDateTimePicker.Location = new System.Drawing.Point(189, 113);
            this.violation_dateDateTimePicker.Name = "violation_dateDateTimePicker";
            this.violation_dateDateTimePicker.Size = new System.Drawing.Size(261, 26);
            this.violation_dateDateTimePicker.TabIndex = 6;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(189, 145);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(261, 96);
            this.descriptionRichTextBox.TabIndex = 8;
            this.descriptionRichTextBox.Text = "";
            // 
            // counseling_statusTextBox
            // 
            this.counseling_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "counseling_status", true));
            this.counseling_statusTextBox.Location = new System.Drawing.Point(189, 247);
            this.counseling_statusTextBox.Name = "counseling_statusTextBox";
            this.counseling_statusTextBox.Size = new System.Drawing.Size(261, 26);
            this.counseling_statusTextBox.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(id_studentLabel);
            this.Controls.Add(this.id_studentComboBox);
            this.Controls.Add(id_categoryLabel);
            this.Controls.Add(this.id_categoryComboBox);
            this.Controls.Add(violation_dateLabel);
            this.Controls.Add(this.violation_dateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(counseling_statusLabel);
            this.Controls.Add(this.counseling_statusTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form Guru - Catat Pelanggaran";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_siskom_smeasDataSet db_siskom_smeasDataSet;
        private System.Windows.Forms.BindingSource violationrecordsBindingSource;
        private db_siskom_smeasDataSetTableAdapters.violation_recordsTableAdapter violation_recordsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private db_siskom_smeasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_siskom_smeasDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox id_studentComboBox;
        private System.Windows.Forms.ComboBox id_categoryComboBox;
        private System.Windows.Forms.DateTimePicker violation_dateDateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox counseling_statusTextBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private db_siskom_smeasDataSetTableAdapters.violation_categoriesTableAdapter violation_categoriesTableAdapter;
        private System.Windows.Forms.BindingSource violationcategoriesBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrecordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreporteruserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counselingstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace LKS_ITSoftware
{
    partial class Form3
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
            System.Windows.Forms.Label nisnLabel;
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label id_classLabel;
            System.Windows.Forms.Label genderLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nisnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_siskom_smeasDataSet = new LKS_ITSoftware.db_siskom_smeasDataSet();
            this.studentsTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.studentsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager();
            this.classesTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.classesTableAdapter();
            this.nisnTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            nisnLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            id_classLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nisnLabel
            // 
            nisnLabel.AutoSize = true;
            nisnLabel.Location = new System.Drawing.Point(70, 485);
            nisnLabel.Name = "nisnLabel";
            nisnLabel.Size = new System.Drawing.Size(51, 20);
            nisnLabel.TabIndex = 6;
            nisnLabel.Text = "NISN:";
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(70, 386);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(121, 20);
            full_nameLabel.TabIndex = 8;
            full_nameLabel.Text = "Nama Lengkap:";
            // 
            // id_classLabel
            // 
            id_classLabel.AutoSize = true;
            id_classLabel.Location = new System.Drawing.Point(70, 450);
            id_classLabel.Name = "id_classLabel";
            id_classLabel.Size = new System.Drawing.Size(52, 20);
            id_classLabel.TabIndex = 10;
            id_classLabel.Text = "Kelas:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(70, 418);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(110, 20);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "Jenis Kelamin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NISN/Nama Lengkap:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.nisnDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.idclassDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.editCol,
            this.delCol});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 247);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // nisnDataGridViewTextBoxColumn
            // 
            this.nisnDataGridViewTextBoxColumn.DataPropertyName = "nisn";
            this.nisnDataGridViewTextBoxColumn.HeaderText = "NISN";
            this.nisnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nisnDataGridViewTextBoxColumn.Name = "nisnDataGridViewTextBoxColumn";
            this.nisnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclassDataGridViewTextBoxColumn
            // 
            this.idclassDataGridViewTextBoxColumn.DataPropertyName = "id_class";
            this.idclassDataGridViewTextBoxColumn.HeaderText = "Class";
            this.idclassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idclassDataGridViewTextBoxColumn.Name = "idclassDataGridViewTextBoxColumn";
            this.idclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editCol
            // 
            this.editCol.DataPropertyName = "id_student";
            this.editCol.HeaderText = "Edit";
            this.editCol.MinimumWidth = 8;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.DataPropertyName = "id_student";
            this.delCol.HeaderText = "Delete";
            this.delCol.MinimumWidth = 8;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // db_siskom_smeasDataSet
            // 
            this.db_siskom_smeasDataSet.DataSetName = "db_siskom_smeasDataSet";
            this.db_siskom_smeasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kelas:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.violation_categoriesTableAdapter = null;
            this.tableAdapterManager.violation_recordsTableAdapter = null;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // nisnTextBox
            // 
            this.nisnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nisn", true));
            this.nisnTextBox.Location = new System.Drawing.Point(197, 479);
            this.nisnTextBox.Name = "nisnTextBox";
            this.nisnTextBox.Size = new System.Drawing.Size(270, 26);
            this.nisnTextBox.TabIndex = 7;
            this.nisnTextBox.Tag = "NISN";
            this.nisnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nisnTextBox_KeyPress);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "students";
            this.bindingSource1.DataSource = this.db_siskom_smeasDataSet;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(197, 383);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(270, 26);
            this.full_nameTextBox.TabIndex = 9;
            this.full_nameTextBox.Tag = "Nama lengkap";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(197, 415);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(270, 26);
            this.genderTextBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1069, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1194, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "id_class", true));
            this.comboBox1.DataSource = this.classesBindingSource;
            this.comboBox1.DisplayMember = "class_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(510, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "id_class";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "classes";
            this.classesBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "id_class", true));
            this.comboBox2.DataSource = this.classesBindingSource;
            this.comboBox2.DisplayMember = "class_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(197, 447);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Tag = "Kelas";
            this.comboBox2.ValueMember = "id_class";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 648);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(nisnLabel);
            this.Controls.Add(this.nisnTextBox);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(id_classLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Siswa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_siskom_smeasDataSet db_siskom_smeasDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private db_siskom_smeasDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
        private System.Windows.Forms.Label label2;
        private db_siskom_smeasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nisnTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private db_siskom_smeasDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
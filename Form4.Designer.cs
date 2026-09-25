namespace LKS_ITSoftware
{
    partial class Form4
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
            System.Windows.Forms.Label class_nameLabel;
            System.Windows.Forms.Label academic_yearLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_siskom_smeasDataSet = new LKS_ITSoftware.db_siskom_smeasDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.classesTableAdapter();
            this.idclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableAdapterManager = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager();
            this.class_nameTextBox = new System.Windows.Forms.TextBox();
            this.academic_yearTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            class_nameLabel = new System.Windows.Forms.Label();
            academic_yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
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
            this.idclassDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn,
            this.academicyearDataGridViewTextBoxColumn,
            this.delCol,
            this.editCol});
            this.dataGridView1.DataSource = this.classesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 186);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // db_siskom_smeasDataSet
            // 
            this.db_siskom_smeasDataSet.DataSetName = "db_siskom_smeasDataSet";
            this.db_siskom_smeasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "classes";
            this.classesBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // idclassDataGridViewTextBoxColumn
            // 
            this.idclassDataGridViewTextBoxColumn.DataPropertyName = "id_class";
            this.idclassDataGridViewTextBoxColumn.HeaderText = "id_class";
            this.idclassDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idclassDataGridViewTextBoxColumn.Name = "idclassDataGridViewTextBoxColumn";
            this.idclassDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclassDataGridViewTextBoxColumn.Visible = false;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "Nama Kelas";
            this.classnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // academicyearDataGridViewTextBoxColumn
            // 
            this.academicyearDataGridViewTextBoxColumn.DataPropertyName = "academic_year";
            this.academicyearDataGridViewTextBoxColumn.HeaderText = "Tahun Ajaran";
            this.academicyearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.academicyearDataGridViewTextBoxColumn.Name = "academicyearDataGridViewTextBoxColumn";
            this.academicyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.DataPropertyName = "id_class";
            this.delCol.HeaderText = "Delete";
            this.delCol.MinimumWidth = 8;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // editCol
            // 
            this.editCol.DataPropertyName = "id_class";
            this.editCol.HeaderText = "Edit";
            this.editCol.MinimumWidth = 8;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.violation_categoriesTableAdapter = null;
            this.tableAdapterManager.violation_recordsTableAdapter = null;
            // 
            // class_nameLabel
            // 
            class_nameLabel.AutoSize = true;
            class_nameLabel.Location = new System.Drawing.Point(95, 363);
            class_nameLabel.Name = "class_nameLabel";
            class_nameLabel.Size = new System.Drawing.Size(98, 20);
            class_nameLabel.TabIndex = 4;
            class_nameLabel.Tag = "Nama kelas";
            class_nameLabel.Text = "Nama Kelas:";
            // 
            // class_nameTextBox
            // 
            this.class_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "class_name", true));
            this.class_nameTextBox.Location = new System.Drawing.Point(216, 360);
            this.class_nameTextBox.Name = "class_nameTextBox";
            this.class_nameTextBox.Size = new System.Drawing.Size(244, 26);
            this.class_nameTextBox.TabIndex = 5;
            this.class_nameTextBox.Tag = "Nama kelas";
            // 
            // academic_yearLabel
            // 
            academic_yearLabel.AutoSize = true;
            academic_yearLabel.Location = new System.Drawing.Point(95, 331);
            academic_yearLabel.Name = "academic_yearLabel";
            academic_yearLabel.Size = new System.Drawing.Size(108, 20);
            academic_yearLabel.TabIndex = 6;
            academic_yearLabel.Tag = "Tahun Ajaran";
            academic_yearLabel.Text = "Tahun Ajaran:";
            // 
            // academic_yearTextBox
            // 
            this.academic_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "academic_year", true));
            this.academic_yearTextBox.Location = new System.Drawing.Point(216, 328);
            this.academic_yearTextBox.Name = "academic_yearTextBox";
            this.academic_yearTextBox.Size = new System.Drawing.Size(244, 26);
            this.academic_yearTextBox.TabIndex = 7;
            this.academic_yearTextBox.Tag = "Tahun ajaran";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1136, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1011, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "classes";
            this.bindingSource1.DataSource = this.db_siskom_smeasDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 675);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(class_nameLabel);
            this.Controls.Add(this.class_nameTextBox);
            this.Controls.Add(academic_yearLabel);
            this.Controls.Add(this.academic_yearTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Kelas";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_siskom_smeasDataSet db_siskom_smeasDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private db_siskom_smeasDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private db_siskom_smeasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox class_nameTextBox;
        private System.Windows.Forms.TextBox academic_yearTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
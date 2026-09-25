namespace LKS_ITSoftware
{
    partial class Form5
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
            System.Windows.Forms.Label category_nameLabel;
            System.Windows.Forms.Label severity_levelLabel;
            System.Windows.Forms.Label default_pointLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severitylevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.violationcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_siskom_smeasDataSet = new LKS_ITSoftware.db_siskom_smeasDataSet();
            this.violation_categoriesTableAdapter = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.violation_categoriesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager();
            this.category_nameTextBox = new System.Windows.Forms.TextBox();
            this.severity_levelTextBox = new System.Windows.Forms.TextBox();
            this.default_pointTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            severity_levelLabel = new System.Windows.Forms.Label();
            default_pointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Location = new System.Drawing.Point(107, 382);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(118, 20);
            category_nameLabel.TabIndex = 1;
            category_nameLabel.Text = "Nama Kategori:";
            // 
            // severity_levelLabel
            // 
            severity_levelLabel.AutoSize = true;
            severity_levelLabel.Location = new System.Drawing.Point(107, 414);
            severity_levelLabel.Name = "severity_levelLabel";
            severity_levelLabel.Size = new System.Drawing.Size(138, 20);
            severity_levelLabel.TabIndex = 3;
            severity_levelLabel.Text = "Tingkat Hukuman:";
            // 
            // default_pointLabel
            // 
            default_pointLabel.AutoSize = true;
            default_pointLabel.Location = new System.Drawing.Point(107, 446);
            default_pointLabel.Name = "default_pointLabel";
            default_pointLabel.Size = new System.Drawing.Size(44, 20);
            default_pointLabel.TabIndex = 5;
            default_pointLabel.Text = "Poin:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoryDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.severitylevelDataGridViewTextBoxColumn,
            this.defaultpointDataGridViewTextBoxColumn,
            this.editCol,
            this.delCol});
            this.dataGridView1.DataSource = this.violationcategoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idcategoryDataGridViewTextBoxColumn
            // 
            this.idcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.HeaderText = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcategoryDataGridViewTextBoxColumn.Name = "idcategoryDataGridViewTextBoxColumn";
            this.idcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcategoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // severitylevelDataGridViewTextBoxColumn
            // 
            this.severitylevelDataGridViewTextBoxColumn.DataPropertyName = "severity_level";
            this.severitylevelDataGridViewTextBoxColumn.HeaderText = "Tingkat Hukuman";
            this.severitylevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.severitylevelDataGridViewTextBoxColumn.Name = "severitylevelDataGridViewTextBoxColumn";
            this.severitylevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultpointDataGridViewTextBoxColumn
            // 
            this.defaultpointDataGridViewTextBoxColumn.DataPropertyName = "default_point";
            this.defaultpointDataGridViewTextBoxColumn.HeaderText = "Poin ";
            this.defaultpointDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.defaultpointDataGridViewTextBoxColumn.Name = "defaultpointDataGridViewTextBoxColumn";
            this.defaultpointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editCol
            // 
            this.editCol.DataPropertyName = "id_category";
            this.editCol.HeaderText = "Edit";
            this.editCol.MinimumWidth = 8;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.DataPropertyName = "id_category";
            this.delCol.HeaderText = "Delete";
            this.delCol.MinimumWidth = 8;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // violationcategoriesBindingSource
            // 
            this.violationcategoriesBindingSource.DataMember = "violation_categories";
            this.violationcategoriesBindingSource.DataSource = this.db_siskom_smeasDataSet;
            // 
            // db_siskom_smeasDataSet
            // 
            this.db_siskom_smeasDataSet.DataSetName = "db_siskom_smeasDataSet";
            this.db_siskom_smeasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violation_categoriesTableAdapter
            // 
            this.violation_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "violation_categories";
            this.bindingSource1.DataSource = this.db_siskom_smeasDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classesTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.violation_categoriesTableAdapter = this.violation_categoriesTableAdapter;
            this.tableAdapterManager.violation_recordsTableAdapter = null;
            // 
            // category_nameTextBox
            // 
            this.category_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "category_name", true));
            this.category_nameTextBox.Location = new System.Drawing.Point(260, 379);
            this.category_nameTextBox.Name = "category_nameTextBox";
            this.category_nameTextBox.Size = new System.Drawing.Size(239, 26);
            this.category_nameTextBox.TabIndex = 2;
            // 
            // severity_levelTextBox
            // 
            this.severity_levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "severity_level", true));
            this.severity_levelTextBox.Location = new System.Drawing.Point(260, 411);
            this.severity_levelTextBox.Name = "severity_levelTextBox";
            this.severity_levelTextBox.Size = new System.Drawing.Size(239, 26);
            this.severity_levelTextBox.TabIndex = 4;
            // 
            // default_pointTextBox
            // 
            this.default_pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "default_point", true));
            this.default_pointTextBox.Location = new System.Drawing.Point(260, 443);
            this.default_pointTextBox.Name = "default_pointTextBox";
            this.default_pointTextBox.Size = new System.Drawing.Size(239, 26);
            this.default_pointTextBox.TabIndex = 6;
            this.default_pointTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.default_pointTextBox_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1179, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1054, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Kategori:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(category_nameLabel);
            this.Controls.Add(this.category_nameTextBox);
            this.Controls.Add(severity_levelLabel);
            this.Controls.Add(this.severity_levelTextBox);
            this.Controls.Add(default_pointLabel);
            this.Controls.Add(this.default_pointTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Kategori Pelanggaran";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_siskom_smeasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_siskom_smeasDataSet db_siskom_smeasDataSet;
        private System.Windows.Forms.BindingSource violationcategoriesBindingSource;
        private db_siskom_smeasDataSetTableAdapters.violation_categoriesTableAdapter violation_categoriesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private db_siskom_smeasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox category_nameTextBox;
        private System.Windows.Forms.TextBox severity_levelTextBox;
        private System.Windows.Forms.TextBox default_pointTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn severitylevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
    }
}
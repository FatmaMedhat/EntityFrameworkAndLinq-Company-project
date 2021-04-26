
namespace pp
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Namestore = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Superrvisor = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyDataSet1 = new pp.CompanyDataSet1();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new pp.CompanyDataSet1TableAdapters.SupplierTableAdapter();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierMobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierWebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(289, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Website";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox5.Location = new System.Drawing.Point(296, 55);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(109, 23);
            this.textBox5.TabIndex = 58;
            // 
            // Namestore
            // 
            this.Namestore.AutoSize = true;
            this.Namestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Namestore.Location = new System.Drawing.Point(17, 80);
            this.Namestore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namestore.Name = "Namestore";
            this.Namestore.Size = new System.Drawing.Size(93, 17);
            this.Namestore.TabIndex = 57;
            this.Namestore.Text = "supp_Name";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(152, 99);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 23);
            this.textBox4.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIdDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierPhoneDataGridViewTextBoxColumn,
            this.supplierMobDataGridViewTextBoxColumn,
            this.supplierWebsiteDataGridViewTextBoxColumn,
            this.supplierMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 190);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Superrvisor
            // 
            this.Superrvisor.AutoSize = true;
            this.Superrvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Superrvisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Superrvisor.Location = new System.Drawing.Point(149, 36);
            this.Superrvisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Superrvisor.Name = "Superrvisor";
            this.Superrvisor.Size = new System.Drawing.Size(53, 17);
            this.Superrvisor.TabIndex = 54;
            this.Superrvisor.Text = "phone";
            this.Superrvisor.Click += new System.EventHandler(this.Superrvisor_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Address.Location = new System.Drawing.Point(149, 80);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(38, 17);
            this.Address.TabIndex = 53;
            this.Address.Text = "Mob";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Update.Location = new System.Drawing.Point(283, 352);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(72, 32);
            this.Update.TabIndex = 51;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Insert.Location = new System.Drawing.Point(152, 352);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(65, 32);
            this.Insert.TabIndex = 50;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(152, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 23);
            this.textBox3.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(20, 99);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 23);
            this.textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(20, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 23);
            this.textBox1.TabIndex = 47;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox6.Location = new System.Drawing.Point(296, 99);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 23);
            this.textBox6.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(293, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Email";
            // 
            // companyDataSet1
            // 
            this.companyDataSet1.DataSetName = "CompanyDataSet1";
            this.companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.companyDataSet1;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Id";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier_Id";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // supplierPhoneDataGridViewTextBoxColumn
            // 
            this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.HeaderText = "Supplier_Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
            // 
            // supplierMobDataGridViewTextBoxColumn
            // 
            this.supplierMobDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Mob";
            this.supplierMobDataGridViewTextBoxColumn.HeaderText = "Supplier_Mob";
            this.supplierMobDataGridViewTextBoxColumn.Name = "supplierMobDataGridViewTextBoxColumn";
            // 
            // supplierWebsiteDataGridViewTextBoxColumn
            // 
            this.supplierWebsiteDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Website";
            this.supplierWebsiteDataGridViewTextBoxColumn.HeaderText = "Supplier_Website";
            this.supplierWebsiteDataGridViewTextBoxColumn.Name = "supplierWebsiteDataGridViewTextBoxColumn";
            // 
            // supplierMailDataGridViewTextBoxColumn
            // 
            this.supplierMailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Mail";
            this.supplierMailDataGridViewTextBoxColumn.HeaderText = "Supplier_Mail";
            this.supplierMailDataGridViewTextBoxColumn.Name = "supplierMailDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Namestore);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Superrvisor);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Namestore;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Superrvisor;
        public System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.Label label3;
        private CompanyDataSet1 companyDataSet1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private CompanyDataSet1TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierMobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierWebsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierMailDataGridViewTextBoxColumn;
    }
}
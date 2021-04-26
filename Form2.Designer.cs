
namespace pp
{
    partial class Form2
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
            this.companyDataSet = new pp.CompanyDataSet();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new pp.CompanyDataSetTableAdapters.StoreTableAdapter();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeResposibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Namestore
            // 
            this.Namestore.AutoSize = true;
            this.Namestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.Namestore.Location = new System.Drawing.Point(203, 46);
            this.Namestore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namestore.Name = "Namestore";
            this.Namestore.Size = new System.Drawing.Size(86, 17);
            this.Namestore.TabIndex = 33;
            this.Namestore.Text = "Namestore";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(419, 65);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 23);
            this.textBox4.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIdDataGridViewTextBoxColumn,
            this.storenameDataGridViewTextBoxColumn,
            this.storeAddressDataGridViewTextBoxColumn,
            this.storeResposibleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 190);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Superrvisor
            // 
            this.Superrvisor.AutoSize = true;
            this.Superrvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Superrvisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.Superrvisor.Location = new System.Drawing.Point(333, 46);
            this.Superrvisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Superrvisor.Name = "Superrvisor";
            this.Superrvisor.Size = new System.Drawing.Size(92, 17);
            this.Superrvisor.TabIndex = 30;
            this.Superrvisor.Text = "Superrvisor";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.Address.Location = new System.Drawing.Point(440, 46);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(67, 17);
            this.Address.TabIndex = 29;
            this.Address.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Update.Location = new System.Drawing.Point(327, 318);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(72, 32);
            this.Update.TabIndex = 27;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Insert.Location = new System.Drawing.Point(206, 318);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(65, 32);
            this.Insert.TabIndex = 26;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(306, 65);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 23);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(193, 65);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 23);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(80, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 23;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.companyDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "Store_Id";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "Store_Id";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            // 
            // storenameDataGridViewTextBoxColumn
            // 
            this.storenameDataGridViewTextBoxColumn.DataPropertyName = "Store_name";
            this.storenameDataGridViewTextBoxColumn.HeaderText = "Store_name";
            this.storenameDataGridViewTextBoxColumn.Name = "storenameDataGridViewTextBoxColumn";
            // 
            // storeAddressDataGridViewTextBoxColumn
            // 
            this.storeAddressDataGridViewTextBoxColumn.DataPropertyName = "Store_Address";
            this.storeAddressDataGridViewTextBoxColumn.HeaderText = "Store_Address";
            this.storeAddressDataGridViewTextBoxColumn.Name = "storeAddressDataGridViewTextBoxColumn";
            // 
            // storeResposibleDataGridViewTextBoxColumn
            // 
            this.storeResposibleDataGridViewTextBoxColumn.DataPropertyName = "Store_Resposible";
            this.storeResposibleDataGridViewTextBoxColumn.HeaderText = "Store_Resposible";
            this.storeResposibleDataGridViewTextBoxColumn.Name = "storeResposibleDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private CompanyDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeResposibleDataGridViewTextBoxColumn;
    }
}
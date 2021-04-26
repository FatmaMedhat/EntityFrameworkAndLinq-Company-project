using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp
{
    public partial class Form4 : Form
    {
        CFDB ENT = new CFDB();
        public Form4()
        {
            InitializeComponent();
        }

        private void Superrvisor_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.companyDataSet1.Supplier);

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Supplier_Id = int.Parse(textBox1.Text);
            sup.Supplier_Name = textBox2.Text;
            sup.Supplier_Phone = textBox3.Text;
            sup.Supplier_Mob = textBox4.Text;
            sup.Supplier_Mail = (textBox5.Text);


            ENT.Suppliers.Add(sup);
            ENT.SaveChanges();
            MessageBox.Show("Supplier added Succfully");
            this.supplierTableAdapter.Fill(this.companyDataSet1.Supplier);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int N_id = int.Parse(textBox1.Text);
            Supplier sp = (from St in ENT.Suppliers
                        where St.Supplier_Id == N_id
                        select St).FirstOrDefault();
            sp.Supplier_Id = int.Parse(textBox1.Text);
            sp.Supplier_Name = textBox2.Text;
            sp.Supplier_Phone = textBox3.Text;
            sp.Supplier_Mob = textBox4.Text;
            sp.Supplier_Website = textBox5.Text;
            sp.Supplier_Mail = textBox6.Text;


            ENT.SaveChanges();
            MessageBox.Show("update Succfully");
            this.supplierTableAdapter.Fill(this.companyDataSet1.Supplier);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
    }
}

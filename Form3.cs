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
    public partial class Form3 : Form
    {
        CFDB ENT = new CFDB();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet1.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.companyDataSet1.Item);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Item t = new Item();
            t.Item_Id = int.Parse(textBox1.Text);
            t.Item_Name = textBox2.Text;
            t.Expiration = textBox3.Text;
            t.Production_Date = textBox4.Text;
            t.quantity = int.Parse(textBox5.Text);


            ENT.Items.Add(t);
            ENT.SaveChanges();
            MessageBox.Show("Store add Succfully");
            this.itemTableAdapter.Fill(this.companyDataSet1.Item);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int N_id = int.Parse(textBox1.Text);
            Item itm = (from St in ENT.Items
                           where St.Item_Id == N_id
                           select St).FirstOrDefault();
            itm.Item_Id = int.Parse(textBox1.Text);
            itm.Item_Name = textBox2.Text;
            itm.Expiration = textBox3.Text;
            itm.Production_Date = textBox4.Text;
            ENT.SaveChanges();
            MessageBox.Show("update Succfully");
            this.itemTableAdapter.Fill(this.companyDataSet1.Item);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }
    }
}

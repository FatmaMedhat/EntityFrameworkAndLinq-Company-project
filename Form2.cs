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
    public partial class Form2 : Form
    {
        CFDB ENT = new CFDB();

        public Form2()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Store_Id = int.Parse(textBox1.Text);
            store.Store_name = textBox2.Text;
            store.Store_Address = textBox3.Text;
            store.Store_Resposible = textBox4.Text;

            ENT.Stores.Add(store);
            ENT.SaveChanges();
            MessageBox.Show("Store add Succfully");
            this.storeTableAdapter.Fill(this.companyDataSet.Store);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.companyDataSet.Store);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int N_id = int.Parse(textBox1.Text);
            Store Store = (from St in ENT.Stores
                           where St.Store_Id == N_id
                           select St).FirstOrDefault();
            Store.Store_Id = int.Parse(textBox1.Text);
            Store.Store_name = textBox2.Text;
            Store.Store_Resposible = textBox3.Text;
            Store.Store_Address = textBox4.Text;
            ENT.SaveChanges();
            MessageBox.Show("update Succfully");
            this.storeTableAdapter.Fill(this.companyDataSet.Store);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}

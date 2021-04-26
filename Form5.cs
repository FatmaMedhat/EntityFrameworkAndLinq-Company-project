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
    public partial class Form5 : Form
    {
        CFDB ENT = new CFDB();
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.companyDataSet1.Client);

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Client sup = new Client();
            sup.Client_Id = int.Parse(textBox1.Text);
            sup.Client_Name = textBox2.Text;
            sup.Client_Phone = textBox3.Text;
            sup.Client_Mob = textBox4.Text;
            sup.Client_Website = (textBox5.Text);
            sup.Client_Mail = (textBox6.Text);
            sup.Client_Fax = textBox7.Text;



            ENT.Clients.Add(sup);
            ENT.SaveChanges();
            MessageBox.Show("Client added Succfully");
            this.clientTableAdapter.Fill(this.companyDataSet1.Client);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text= textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int N_id = int.Parse(textBox1.Text);
            Client sp = (from St in ENT.Clients
                           where St.Client_Id == N_id
                           select St).FirstOrDefault();
            sp.Client_Id = int.Parse(textBox1.Text);
            sp.Client_Name = textBox2.Text;
            sp.Client_Phone = textBox3.Text;
            sp.Client_Mob = textBox4.Text;
            sp.Client_Website = textBox5.Text;
            sp.Client_Mail = textBox6.Text;
            sp.Client_Fax = textBox7.Text;



            ENT.SaveChanges();
            MessageBox.Show("update Succfully");
            this.clientTableAdapter.Fill(this.companyDataSet1.Client);

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }
    }
}

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
    public partial class Form6 : Form
    {
        CFDB ENT = new CFDB();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet7.Store_supplier' table. You can move, or remove it, as needed.
            this.store_supplierTableAdapter.Fill(this.companyDataSet7.Store_supplier);
          

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Store_supplier strsup = new Store_supplier();
            stored_Item stritem = new stored_Item();

            //get id of supplier
            var supid = (from W in ENT.Suppliers
                         where W.Supplier_Name == comboBox4.SelectedItem
                         select W.Supplier_Id).FirstOrDefault();
            //get id of store
            var storeid = (from W in ENT.Stores
                           where W.Store_name == comboBox5.SelectedItem
                           select W.Store_Id).FirstOrDefault();
            // get itemid  of item name
            var itmid = (from W in ENT.Items
                         where W.Item_Name == comboBox1.SelectedItem
                         select W.Item_Id).FirstOrDefault();
            //**************fill storesupplier table***************
            strsup.Supplier_Id = (supid);
            strsup.Item_Id = itmid;
            strsup.Store_Id = (storeid);
            strsup.quantity = int.Parse(textBox1.Text);
            strsup.License_supplier_date = DateTime.Parse(textBox5.Text);
            strsup.License_supplier_Num = int.Parse(textBox3.Text);
            MessageBox.Show("addeed row in storesupplier");
            ENT.Store_supplier.Add(strsup);



            //**************************fill stored item*************************************************
            //stritem.Item_Id = itmid;
            //stritem.Store_Id = storeid;
            //stritem.quantity = int.Parse(textBox1.Text);
            //ENT.stored_Item.Add(stritem);
            var exist = (from r in ENT.stored_Item
                         where r.Item_Id == itmid
                         && r.Store_Id == storeid
                         select r).FirstOrDefault();
            if (exist.Store_Id != null && exist.Item_Id != null)//update 
            {
                //stored_Item st = (from St in ENT.stored_Item
                //                  where St.Store_Id == storeid
                //                  select St).FirstOrDefault();
                int q = (int)(exist.quantity);
                exist.quantity = q + (strsup.quantity);
            }
            else if (exist.Store_Id == null && exist.Item_Id == null)//insert
            {
                stritem.Item_Id = itmid;
                stritem.Store_Id = storeid;
                stritem.quantity = int.Parse(textBox1.Text);
                ENT.stored_Item.Add(stritem);
            }



            ENT.SaveChanges();
            this.store_supplierTableAdapter.Fill(this.companyDataSet7.Store_supplier);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var supnames = from x in ENT.Items
                           select x.Item_Name;
            foreach (var S in supnames)
            {
                comboBox1.Items.Add(S);
            }
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            var strnames = from x in ENT.Stores
                           select x.Store_name;
            foreach (var S in strnames)
            {
                comboBox5.Items.Add(S);
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            var supnames = from x in ENT.Suppliers
                           select x.Supplier_Name;
            foreach (var S in supnames)
            {
                comboBox4.Items.Add(S);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supidu = (from W in ENT.Suppliers
                          where W.Supplier_Name == comboBox4.SelectedItem
                          select W.Supplier_Id).FirstOrDefault();
            //get id of store
            var storeidu = (from W in ENT.Stores
                            where W.Store_name == comboBox5.SelectedItem
                            select W.Store_Id).FirstOrDefault();
            // get itemid  of item name
            var itmidu = (from W in ENT.Items
                          where W.Item_Name == comboBox1.SelectedItem
                          select W.Item_Id).FirstOrDefault();
            //****************************updated store supplier  table and updated******************************
            Store_supplier st = (from St in ENT.Store_supplier
                                 where St.Store_Id == storeidu
                                 && St.Supplier_Id == supidu
                                 && St.Item_Id == itmidu
                                 select St).FirstOrDefault();
            stored_Item stitm = (from St in ENT.stored_Item
                                 where St.Store_Id == storeidu
                                 && St.Item_Id == itmidu
                                 select St).FirstOrDefault();

            //***************************old val of quent****************
            var oldvalsp = (from St in ENT.Store_supplier
                            where St.Store_Id == storeidu
                            && St.Supplier_Id == supidu
                            && St.Item_Id == itmidu
                            select St.quantity).FirstOrDefault();
            var oldvalstitm = (from St in ENT.stored_Item
                               where St.Store_Id == storeidu
                               && St.Item_Id == itmidu
                               select St.quantity).FirstOrDefault();

            st.quantity = int.Parse(textBox1.Text);
            st.License_supplier_Num = int.Parse(textBox3.Text);
            st.License_supplier_date = DateTime.Parse(textBox5.Text);

            stitm.quantity = (oldvalstitm - oldvalsp) + int.Parse(textBox1.Text);

            MessageBox.Show("two tables updated");
            ENT.SaveChanges();

            this.store_supplierTableAdapter.Fill(this.companyDataSet7.Store_supplier);
        }
    }
}

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
    public partial class Form7 : Form
    {
        CFDB ENT = new CFDB();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet6.Exchange' table. You can move, or remove it, as needed.
            this.exchangeTableAdapter.Fill(this.companyDataSet6.Exchange);
           

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Exchange exch = new Exchange();
            stored_Item stritem = new stored_Item();
            CFDB ent = new CFDB();
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
                         where W.Item_Name == comboBox3.SelectedItem
                         select W.Item_Id).FirstOrDefault();
            var clientid = (from W in ENT.Clients
                            where W.Client_Name == comboBox1.SelectedItem
                            select W.Client_Id).FirstOrDefault();
            //**************fill Exchange table***************
            exch.Item_Id = itmid;
            exch.Supplier_Id = (supid);
            exch.Client_Id = (clientid);
            exch.Store_Id = (storeid);
            exch.quantity = int.Parse(textBox4.Text);
            exch.License_date = DateTime.Parse(textBox2.Text);
            exch.License_Number = int.Parse(textBox1.Text);

            //************************************************
            stored_Item st = (from St in ENT.stored_Item
                              where St.Store_Id == storeid
                              select St).FirstOrDefault();
            int q = (int)(st.quantity);
            if (exch.quantity < q)
            {

                st.quantity = q - (exch.quantity);
            }
            else
            {
                MessageBox.Show("out of stock");
            }

            //**************************fill stored item*************************************************


            ENT.Exchanges.Add(exch);
            MessageBox.Show("addeed row in exchange");
            MessageBox.Show("added in storesitem");
            ENT.SaveChanges();
            
            this.exchangeTableAdapter.Fill(this.companyDataSet6.Exchange);

        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            var WareH = (from W in ENT.Stores
                         select W).Distinct();
            comboBox5.Items.Clear();
            foreach (var S in WareH)
            {
                comboBox5.Items.Add(S.Store_name);
            }

        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            var store = comboBox5.SelectedItem;
            var selectedid = (from s in ENT.Stores
                              where s.Store_name == store.ToString()
                              select s.Store_Id).FirstOrDefault();
            var itemid = (from s in ENT.stored_Item
                          where s.Store_Id == selectedid
                          select s.Item_Id);
            comboBox3.Items.Clear();

            foreach (var i in itemid)
            {
                var itemnames = (from s in ENT.Items
                                 where s.Item_Id == i
                                 select s.Item_Name);
                foreach (var S in itemnames)
                {
                    comboBox3.Items.Add(S);
                }

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            var sup_name = (from W in ENT.Suppliers

                            select W.Supplier_Name);
            comboBox4.Items.Clear();
            foreach (var S in sup_name)
            {
                comboBox4.Items.Add(S);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var client_name = (from W in ENT.Clients

                               select W.Client_Name);
            comboBox1.Items.Clear();
            foreach (var S in client_name)
            {
                comboBox1.Items.Add(S);

           }
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
                          where W.Item_Name == comboBox3.SelectedItem
                          select W.Item_Id).FirstOrDefault();
            //d=getcliemtid***********
            var clientid = (from W in ENT.Clients
                            where W.Client_Name == comboBox1.SelectedItem
                            select W.Client_Id).FirstOrDefault();
            var oldvalex = (from St in ENT.Exchanges
                            where St.Store_Id == storeidu
                            && St.Supplier_Id == supidu
                            && St.Item_Id == itmidu
                            select St.quantity).FirstOrDefault();
            var oldvalstitm = (from St in ENT.stored_Item
                               where St.Store_Id == storeidu
                               && St.Item_Id == itmidu
                               select St.quantity).FirstOrDefault();


            //****************************updated store supplier  table and updated******************************
            Exchange st = (from St in ENT.Exchanges
                           where St.Store_Id == storeidu
                           && St.Supplier_Id == supidu
                           && St.Item_Id == itmidu
                            && St.Client_Id == clientid
                           select St).FirstOrDefault();
            stored_Item stitm = (from St in ENT.stored_Item
                                 where St.Store_Id == storeidu
                                 && St.Item_Id == itmidu
                                 select St).FirstOrDefault();

            st.License_Number = int.Parse(textBox1.Text);
            st.License_date = DateTime.Parse(textBox2.Text);
            st.quantity = int.Parse(textBox4.Text);

            stitm.quantity = oldvalstitm + oldvalex - int.Parse(textBox4.Text);
            MessageBox.Show("two tables updated");
            ENT.SaveChanges();
            this.exchangeTableAdapter.Fill(this.companyDataSet6.Exchange);


        }
    }
}

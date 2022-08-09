using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConnectionString;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class DetailSearch : UserControl
    {
        public DetailSearch()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
               

                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    //Client Code                    
                    command = new MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register", connection);
                    reader = command.ExecuteReader();

                }
                else if(comboBoxEdit1.SelectedIndex == 1)
                {
                    //Client name
                    command = new MySqlCommand("SELECT DISTINCT(client_name) FROM intake_register ORDER BY client_name", connection);
                    reader = command.ExecuteReader();
                }
                else if(comboBoxEdit1.SelectedIndex == 2)
                {
                    //Contact number
                    command = new MySqlCommand("SELECT DISTINCT(contact) FROM intake_register ORDER BY contact", connection);
                    reader = command.ExecuteReader();
                }

                else { connection.Close(); return; }



                ComboBoxItemCollection coll = comboBoxEdit2.Properties.Items;

                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }
                coll.EndUpdate();

               

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                if (comboBoxEdit1.SelectedIndex == -1) { return; }
                if (comboBoxEdit2.Text == "") { DevExpress.XtraEditors.XtraMessageBox.Show("You have to enter a criteria Field Text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    //Client No
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address FROM intake_register WHERE client_no={0}", Convert.ToInt32(comboBoxEdit2.Text)), connection);
                    reader = command.ExecuteReader();
                }
                else if (comboBoxEdit1.SelectedIndex == 1)
                {
                    //Client Name
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address FROM intake_register WHERE client_name LIKE '%{0}%'", comboBoxEdit2.Text), connection);
                    reader = command.ExecuteReader();
                }
                else if (comboBoxEdit1.SelectedIndex == 2)
                {
                    //Client Contact
                    //Client Name
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address FROM intake_register WHERE contact LIKE '%{0}%'", comboBoxEdit2.Text), connection);
                    reader = command.ExecuteReader();
                }

                else { return; }

                

                listView1.Clear();
                listView1.Columns.Add("Client No", 60);
                listView1.Columns.Add("Client Name", 120);
                listView1.Columns.Add("Contact No", 80);
                listView1.Columns.Add("Address", 80);


                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(reader[3].ToString());

                    listView1.Items.Add(lvItem);
                }               

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close(); }
        
        }

         
    }
}

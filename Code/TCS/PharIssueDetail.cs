using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static ConnectionString;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class PharIssueDetail : DevExpress.XtraEditors.XtraForm
    {
        public PharIssueDetail()
        {
            InitializeComponent();
        }

        private void PharIssueDetail_Load(object sender, EventArgs e)
        {
            try
            {
                //Connection State
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }

                //Insert Command
                command = new MySqlCommand("SELECT client_no FROM intake_register", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = client_no.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());

                }
                coll.EndUpdate();
                reader.Close();
            }
            catch (MySqlException ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {
                connection.Close(); 
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string[] sb = new string[100];
                if (!reader.IsClosed) { reader.Close(); }
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                listView1.Clear();

                command = new MySqlCommand("SELECT DISTINCT(Medicine) FROM phar_issue WHERE client_no = " + client_no.Text, connection);
                reader = command.ExecuteReader();

                listView1.Columns.Add("", 100);

                while (reader.Read())
                {
                    listView1.Columns.Add(reader[0].ToString(), 100);
                    sb[x] = reader[0].ToString();
                    x += 1;
                }



                if (!reader.IsClosed) { reader.Close(); }



                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL ISSUE";

                int k = 0;
                int a = 0;
                int y = sb.Length;
                string[] med = new string[y];
                while (y > 0)
                {
                    string name = sb[a];
                    command = new MySqlCommand("SELECT Quantity FROM phar_issue WHERE Medicine = '" + name + "'", connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        k += Convert.ToInt32(reader[0]);
                    }

                    lvItem.SubItems.Add(k.ToString());

                    y--;
                    a++;
                    k = 0;
                    if (!reader.IsClosed) { reader.Close(); }

                }

                listView1.Items.Add(lvItem);


            }
            catch (MySqlException ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {
                connection.Close(); 
            }
        }

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Connection State
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                if (!reader.IsClosed) { reader.Close(); }
                //Insert Command
                command = new MySqlCommand("SELECT client_name FROM intake_register WHERE client_no = " + client_no.EditValue, connection);
                reader = command.ExecuteReader();

                
                while (reader.Read())
                {
                    client_name.Text = reader[0].ToString();

                }
                if (!reader.IsClosed) { reader.Close(); }
            }
            catch (MySqlException ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {
                connection.Close(); 
            }
        }
    }
}
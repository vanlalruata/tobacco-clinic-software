using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using static ConnectionString;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class PharmoIssue : DevExpress.XtraEditors.XtraForm
    {
        public PharmoIssue()
        {
            InitializeComponent();
        }

        private string ToNameText(string name = "")
        {
            try
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                return (myTI.ToTitleCase(name).ToString());
            }
            catch (Exception ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); return name; }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.client_no.ResetText();
                this.med_detail.ResetText();
                this.quantity.ResetText();
                this.batch_detail.ResetText();
                //this.issue_date.ResetText();
                //this.exp_date.ResetText();
                this.remark_detail.ResetText();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void Details()
        {
            try
            {
                if(client_no.Text == "") { return; }

                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Load Client Medication Detai
                command = new MySqlCommand(string.Format("SELECT * FROM phar_issue WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                listView1.Clear();
                listView1.Columns.Add("Client No", 70);
                listView1.Columns.Add("Issue Date", 90);
                listView1.Columns.Add("Medicine", 85);
                listView1.Columns.Add("EXP Date", 90);
                listView1.Columns.Add("Quantity", 70);
                listView1.Columns.Add("Batch Detail", 70);
                listView1.Columns.Add("Remark", 150);


                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = string.Format("{0}", reader[1]);
                    lvItem.SubItems.Add(string.Format("{0:dd/MM/yyyy}", reader[2]));
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(string.Format("{0}", reader[4].ToString()));
                    lvItem.SubItems.Add(reader[5].ToString());
                    lvItem.SubItems.Add(reader[6].ToString());
                    lvItem.SubItems.Add(reader[7].ToString());
                    listView1.Items.Add(lvItem);
                }

                if (!reader.IsClosed) { reader.Close(); }

                command = new MySqlCommand(string.Format("SELECT client_name FROM intake_register WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    label1.Text = reader[0].ToString();
                }


            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close();  }
        }

        private void Clear()
        {
            try
            {
                this.client_no.ResetText();
                this.med_detail.ResetText();
                this.quantity.ResetText();
                this.batch_detail.ResetText();
                //this.issue_date.ResetText();
                //this.exp_date.ResetText();
                this.remark_detail.ResetText();
                LoadAll();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }


        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            Details();
        }

        private void LoadAll()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Load Client Medication Detail
                command = new MySqlCommand("SELECT * FROM phar_issue", connection);
                reader = command.ExecuteReader();

                listView1.Clear();
                listView1.Columns.Add("Client No", 70);
                listView1.Columns.Add("Issue Date", 90);
                listView1.Columns.Add("Medicine", 85);
                listView1.Columns.Add("EXP Date", 100);
                listView1.Columns.Add("Quantity", 70);
                listView1.Columns.Add("Batch Detail", 70);
                listView1.Columns.Add("Remark", 150);


                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = string.Format("{0}", reader[0]);
                    lvItem.SubItems.Add(string.Format("{0:dd/MM/yyyy}", reader[1]));
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(string.Format("{0:dd/MM/yyyy}", reader[3]));
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());
                    lvItem.SubItems.Add(reader[6].ToString());
                    listView1.Items.Add(lvItem);
                }

                //reader.Close();
                if (!reader.IsClosed) { reader.Close(); }
                
                command = new MySqlCommand("SELECT DISTINCT(Medicine_Name) FROM phar_stock", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = batch_detail.Properties.Items;

                coll = med_detail.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }
                coll.EndUpdate();


                if (!reader.IsClosed) { reader.Close(); }

                command = new MySqlCommand("SELECT DISTINCT(Batch_Detail) FROM phar_stock", connection);
                reader = command.ExecuteReader();


                coll = batch_detail.Properties.Items;
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
            { connection.Close();  }
        }

        private void PharmoIssue_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAll();                

                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Load Client No
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
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); return; }
            finally
            { connection.Close(); }
        }

        private void Save()
        {
            command = new MySqlCommand(string.Format("INSERT INTO phar_issue (Client_No,Issue_Date, Medicine,exp_date,Quantity,Batch_Detail, Remark) VALUES ({0},'{1}','{2}','{3}',{4},'{5}','{6}')", client_no.Text, string.Format("{0:yyyy-MM-dd}",issue_date.EditValue), med_detail.Text, exp_date.Text, Convert.ToInt32(quantity.EditValue), batch_detail.Text, remark_detail.Text), connection);
            int i = command.ExecuteNonQuery();
            if (i == 1)
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); Clear(); }
            else
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Not Added Successfully!", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text != "")
                {
                    connection.Open();
                    //Save
                    Save();
                }
                else { DevExpress.XtraEditors.XtraMessageBox.Show("You have to enter the Client No !", "Something Missing"); }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); }
        }

        private void MUpdate()
        {
            command = new MySqlCommand(string.Format("UPDATE phar_issue SET Medicine = '{0}',exp_date = '{1}',Quantity={2},Batch_Detail='{3}', Remark='{4}' WHERE Client_No = {5} AND Issue_Date = '{6}'", med_detail.Text, exp_date.Text, Convert.ToInt32(quantity.EditValue), batch_detail.Text, remark_detail.Text, Convert.ToInt32(client_no.Text), string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(issue_date.Text))), connection);
            int i = command.ExecuteNonQuery();
            if (i == 1)
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); Clear(); }
            else
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Not Updated Successfully!", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text != "" || issue_date.Text != "")
                {
                    connection.Open();
                    //Save
                    Delete();
                }
                else { DevExpress.XtraEditors.XtraMessageBox.Show("You have to enter the Client No or Issue Date !", "Something Missing"); }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); }
        }

        private void Delete()
        {
            command = new MySqlCommand(string.Format("DELETE FROM phar_issue WHERE Client_No = {0} AND Issue_Date = '{1}'",  Convert.ToInt32(client_no.Text), string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(issue_date.Text))), connection);
            int i = command.ExecuteNonQuery();
            if (i == 1)
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); Clear(); }
            else
            { DevExpress.XtraEditors.XtraMessageBox.Show("Record Not Deleted!", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text != "")
                {
                    connection.Open();
                    //Save
                    MUpdate();
                }
                else { DevExpress.XtraEditors.XtraMessageBox.Show("You have to enter the Client No !", "Something Missing"); }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    client_no.Text = item.SubItems[0].Text.ToString();
                    med_detail.Text = item.SubItems[2].Text;
                    quantity.EditValue = item.SubItems[4].Text;
                    batch_detail.Text = item.SubItems[5].Text;
                    issue_date.Text = item.SubItems[1].Text;
                    exp_date.Text = item.SubItems[3].Text;                    
                    remark_detail.Text = item.SubItems[6].Text;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DetailSearch myControl = new DetailSearch();
                DevExpress.XtraEditors.XtraDialog.Show(myControl, "Search In", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
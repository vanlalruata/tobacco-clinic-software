using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using static ConnectionString;
using System.Globalization;
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class PharmoStock : DevExpress.XtraEditors.XtraForm
    {

        private int id = 0;

        public PharmoStock()
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

        private void LoadBatchDetail()
        {
            try
            {
                //Connection State
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Insert Command
                command = new MySqlCommand("SELECT DISTINCT(Batch_Detail) FROM phar_stock ORDER BY Batch_Detail ASC", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = batch_detail.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {                                     
                        coll.Add(reader[0].ToString());                   
                    
                }
                coll.EndUpdate();
                if (!reader.IsClosed) { reader.Close(); }
            }
            catch (MySqlException ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {                
                connection.Close();
            }
        }

        private void LoadMedicine()
        {
            try
            {
                //Connection State
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Insert Command
                command = new MySqlCommand("SELECT DISTINCT(Medicine_Name) FROM phar_stock ORDER BY Medicine_Name ASC", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = med_detail.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {                                       
                        coll.Add(reader[0].ToString());  
                }
                coll.EndUpdate();

                if (!reader.IsClosed) { reader.Close(); }

            }
            catch (MySqlException ex)
            { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {
                if (!reader.IsClosed) { reader.Close(); }
                connection.Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Something Missing 
                if(string.IsNullOrEmpty(stockdate.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Stock Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(quantity.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Stock Quantity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(mfg_date.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Manufacturing Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(exp_date.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Expiry Date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(price_detail.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Price Detail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(med_detail.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Medicine Detail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(batch_detail.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Please fill out the Batch Detail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Connection State
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }

                //Insert Command
                command = new MySqlCommand(string.Format("INSERT INTO phar_stock (Stock_Date,Manufac_Date,Medicine_Name,Exp_Date,Quantity,Price,Batch_Detail,Medicine_Rating,Remark) VALUES ('{0}','{1}','{2}','{3}',{4},{5},'{6}',{7},'{8}')", string.Format("{0:yyyy-MM-dd}", stockdate.EditValue), mfg_date.Text, med_detail.Text, exp_date.Text, quantity.EditValue, price_detail.EditValue, batch_detail.Text, med_rating.EditValue, remark_detail.Text), connection);
                int i = command.ExecuteNonQuery();

                //Message To User
                if(i == 1)
                { //Success 
                    DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Registered!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Something went wrong! Could not add the details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(MySqlException ex)
            {  DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");  }
            finally
            {
                connection.Close();
            }
        }

        private void ClearAll()
        {
            //stockdate.Text = "";
            //mfg_date.Text = "";
            //exp_date.Text = "";
            price_detail.ResetText();
            med_detail.ResetText();
            med_rating.EditValue = 0;
            quantity.ResetText();
            batch_detail.ResetText();
            remark_detail.ResetText();
            id = 0;

            try
            {
                               
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                RetrieveAll();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (!reader.IsClosed) { reader.Close(); }                
                connection.Close();
            }

        }

        private void med_detail_Validating(object sender, CancelEventArgs e)
        {
            med_detail.Text = ToNameText(med_detail.Text);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
               
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void PharmoStock_Load(object sender, EventArgs e)
        {            
            try
            {
               
                LoadBatchDetail();
                LoadMedicine();
                ClearAll();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    id = Convert.ToInt32(item.SubItems[0].Text.ToString());
                    stockdate.Text = item.SubItems[1].Text;
                    med_detail.Text = item.SubItems[3].Text;
                    quantity.Text = item.SubItems[5].Text;
                    batch_detail.Text = item.SubItems[7].Text;
                    mfg_date.Text = item.SubItems[2].Text;
                    exp_date.Text = item.SubItems[4].Text;
                    price_detail.Text = item.SubItems[6].Text;
                    med_rating.EditValue = Convert.ToInt32(item.SubItems[8].Text);
                    remark_detail.Text = item.SubItems[9].Text;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void RetrieveAll()
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            
            command = new MySqlCommand("SELECT * FROM phar_stock", connection);
            reader = command.ExecuteReader();

            listView1.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("STOCK DATE", 90);
            listView1.Columns.Add("MFG DATE", 150);
            listView1.Columns.Add("MEDICINE", 85);
            listView1.Columns.Add("EXP DATE", 90);
            listView1.Columns.Add("QUANTITY", 70);
            listView1.Columns.Add("PRICE", 70);
            listView1.Columns.Add("BATCH", 70);
            listView1.Columns.Add("RATING 5", 70);
            listView1.Columns.Add("REMARK", 120);

            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = reader[0].ToString();
                lvItem.SubItems.Add(string.Format("{0:dd/MM/yyyy}", reader[1]));
                lvItem.SubItems.Add(reader[2].ToString());
                lvItem.SubItems.Add(reader[3].ToString());
                lvItem.SubItems.Add(reader[4].ToString());
                lvItem.SubItems.Add(string.Format("{0}", reader[5]));
                lvItem.SubItems.Add(string.Format("{0}", reader[6]));
                lvItem.SubItems.Add(reader[7].ToString());
                lvItem.SubItems.Add(reader[8].ToString());
                lvItem.SubItems.Add(reader[9].ToString());
                listView1.Items.Add(lvItem);
            }

            if (!reader.IsClosed) { reader.Close(); }

            command = new MySqlCommand("SELECT DISTINCT(Batch_Detail) FROM phar_stock", connection);
            reader = command.ExecuteReader();


            ComboBoxItemCollection coll = batch_detail.Properties.Items;
            coll.BeginUpdate();
            coll.Clear();
            while (reader.Read())
            {
                coll.Add(reader[0].ToString());
            }
            coll.EndUpdate();

            if (!reader.IsClosed) { reader.Close(); }

            command = new MySqlCommand("SELECT DISTINCT(Medicine_Name) FROM phar_stock", connection);
            reader = command.ExecuteReader();


            coll = med_detail.Properties.Items;
            coll.BeginUpdate();
            coll.Clear();
            while (reader.Read())
            {
                coll.Add(reader[0].ToString());
            }
            coll.EndUpdate();

            if (!reader.IsClosed) { reader.Close(); }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    if(connection.State == ConnectionState.Closed) { connection.Open(); }

                    command = new MySqlCommand("DELETE FROM phar_stock WHERE ID = " + id, connection);
                    int i = command.ExecuteNonQuery();
                    if(i==1)
                    {
                        XtraMessageBox.Show("Successfully Deleted from the Record!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {
                        XtraMessageBox.Show("Nothing to be deleted!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Cannot delete anything, you must select the data to be deleted first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                id = 0;
                connection.Close();
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    if (connection.State == ConnectionState.Closed) { connection.Open(); }

                    command = new MySqlCommand(string.Format("UPDATE phar_stock SET Stock_Date = '{0}', Manufac_Date = '{1}', Medicine_Name = '{2}', Exp_Date = '{3}', Quantity = {4}, Price = {5}, Batch_Detail = '{6}', Medicine_Rating = {7}, Remark= '{8}' WHERE ID = {9}", string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(stockdate.Text)), mfg_date.Text, med_detail.Text, exp_date.Text, quantity.EditValue, price_detail.EditValue, batch_detail.Text, med_rating.EditValue, remark_detail.Text, id), connection);
                    int i = command.ExecuteNonQuery();
                    if (i == 1)
                    {
                        XtraMessageBox.Show("Successfully Updated from the Record!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    else
                    {
                        XtraMessageBox.Show("Nothing to be Updated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Cannot change anything, you must select the data to be updated first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                id = 0;
                connection.Close();
            }
        }
    }
}
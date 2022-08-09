using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using static ConnectionString;
using MySql.Data.MySqlClient;

namespace TCS
{
    public partial class CenterInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public CenterInfoForm()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }

                if (center_no.Text != "")
                {
                    string chk = "False";


                    command = new MySqlCommand(string.Format("SELECT * FROM center_info WHERE center_code = '{0}'", center_code.Text), connection);
                    reader = command.ExecuteReader();
                    int y = 0;

                    while(reader.Read())
                    {
                        y++;
                    }

                    reader.Close();

                    if(y == 0)
                    {
                        if (default_button.CheckState == CheckState.Checked)
                        {
                            chk = "True";
                            command = new MySqlCommand(string.Format("UPDATE center_info SET IsDefault = 'False'; INSERT INTO center_info VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                XtraMessageBox.Show("Successfully Record Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (chk == "True")
                                {
                                    Properties.Settings.Default.CenterNo = center_no.Text;
                                    Properties.Settings.Default.CenterCode = center_code.Text;
                                    Properties.Settings.Default.CenterName = center_name.Text;
                                    Properties.Settings.Default.Email = email_address.Text;
                                    Properties.Settings.Default.Contact = contact_number.Text;
                                    Properties.Settings.Default.Save();
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Something went worng! Cannot add the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            {
                                chk = "False";
                                command = new MySqlCommand(string.Format("INSERT INTO center_info VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                                int i = command.ExecuteNonQuery();
                                if (i == 1)
                                {
                                    XtraMessageBox.Show("Successfully Record Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    XtraMessageBox.Show("Something went worng! Cannot add the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }

                    else
                    {
                        if (default_button.CheckState == CheckState.Checked)
                        {
                            chk = "True";
                            command = new MySqlCommand(string.Format("UPDATE center_info SET IsDefault = 'False'; UPDATE center_info SET Center_Code = '{1}', Center_name = '{2}', Contact_Number = '{3}', Email_Address = '{4}', IsDefault = '{5}' WHERE  Center_No = '{0}'", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                            int i = command.ExecuteNonQuery();

                            if (i > 1)
                            {
                                XtraMessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Properties.Settings.Default.CenterNo = center_no.Text;
                                Properties.Settings.Default.CenterCode = center_code.Text;
                                Properties.Settings.Default.CenterName = center_name.Text;
                                Properties.Settings.Default.Email = email_address.Text;
                                Properties.Settings.Default.Contact = contact_number.Text;
                                Properties.Settings.Default.Save();

                            }
                            else
                            {
                                XtraMessageBox.Show("Something went worng! Cannot update the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        else
                        {
                            command = new MySqlCommand(string.Format("UPDATE center_info SET Center_Code = '{1}', Center_name = '{2}', Contact_Number = '{3}', Email_Address = '{4}', IsDefault = '{5}' WHERE  Center_No = '{0}'", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                            int i = command.ExecuteNonQuery();
                            if (i == 1)
                            {
                                XtraMessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                XtraMessageBox.Show("Something went worng! Cannot update the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    
                }
                else { XtraMessageBox.Show("Client No cannot be left blank!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error); }                                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                ClearAll();
                LoadToListView();
            }
        }

        private void ClearAll()
        {
            center_code.ResetText();
            center_name.ResetText();
            contact_number.ResetText();
            email_address.ResetText();
            default_button.CheckState = CheckState.Unchecked;
            center_no.SelectedIndex = -1;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void CenterInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCenterInfo();
                LoadToListView();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        private void LoadCenterInfo()
        {
            try
            {

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                

                command = new MySqlCommand("SELECT Center_No FROM center_info", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = center_no.Properties.Items;
                
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
            { center_no.Text = Properties.Settings.Default.CenterNo; connection.Close(); }
        }

        private void LoadToListView()
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }
               
                command = new MySqlCommand("SELECT * FROM center_info", connection);
                reader = command.ExecuteReader();


                listView1.Clear();
                listView1.Columns.Add("Center No", 70);
                listView1.Columns.Add("Center Code", 80);
                listView1.Columns.Add("Center Name", 150);
                listView1.Columns.Add("Contact", 85);
                listView1.Columns.Add("Email", 140);
                listView1.Columns.Add("Default", 50);             
                
                while(reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());
                    listView1.Items.Add(lvItem);
                }
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "error!");
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    center_no.Text = item.SubItems[0].Text.ToString();
                    center_code.Text = item.SubItems[1].Text;
                    center_name.Text = item.SubItems[2].Text;
                    contact_number.Text = item.SubItems[3].Text;
                    email_address.Text = item.SubItems[4].Text;
                    if (item.SubItems[5].Text == "True") { default_button.CheckState = CheckState.Checked; }
                    else { default_button.CheckState = CheckState.Unchecked; }

                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void center_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                if (!reader.IsClosed) { reader.Close(); }

                command = new MySqlCommand(string.Format("SELECT * FROM center_info WHERE Center_No = '{0}'", center_no.Text), connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    center_code.Text = reader[1].ToString();
                    center_name.Text = reader[2].ToString();
                    contact_number.Text = reader[3].ToString();
                    email_address.Text = reader[4].ToString();

                    if(reader[5].ToString() == "True") { default_button.CheckState = CheckState.Checked; }
                    else { default_button.CheckState = CheckState.Unchecked; } 
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "error!");
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                if (center_no.Text != "")
                {
                    string chk = "False";

                    if (default_button.CheckState == CheckState.Checked) { chk = "True";
                        command = new MySqlCommand(string.Format("UPDATE center_info SET IsDefault = 'False'; UPDATE center_info SET Center_Code = '{1}', Center_name = '{2}', Contact_Number = '{3}', Email_Address = '{4}', IsDefault = '{5}' WHERE  Center_No = '{0}'", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                        int i = command.ExecuteNonQuery();                        

                        if (i > 1)
                        {
                            XtraMessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.CenterNo = center_no.Text;
                            Properties.Settings.Default.CenterCode = center_code.Text;
                            Properties.Settings.Default.CenterName = center_name.Text;
                            Properties.Settings.Default.Email = email_address.Text;
                            Properties.Settings.Default.Contact = contact_number.Text;
                            Properties.Settings.Default.Save();
                            
                        }
                        else
                        {
                            XtraMessageBox.Show("Something went worng! Cannot update the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }

                    else {
                        command = new MySqlCommand(string.Format("UPDATE center_info SET Center_Code = '{1}', Center_name = '{2}', Contact_Number = '{3}', Email_Address = '{4}', IsDefault = '{5}' WHERE  Center_No = '{0}'", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text, chk), connection);
                        int i = command.ExecuteNonQuery();
                        if (i == 1)
                        {
                            XtraMessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Something went worng! Cannot update the record!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
                else { XtraMessageBox.Show("Client No cannot be left blank!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                ClearAll();
                LoadToListView();
            }
        }
    }
}
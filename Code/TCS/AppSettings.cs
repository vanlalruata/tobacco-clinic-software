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


namespace TCS
{
    public partial class AppSettings : DevExpress.XtraEditors.XtraForm
    {
        public AppSettings()
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

        private void center_name_Validating(object sender, CancelEventArgs e)
        {
            center_name.Text = ToNameText(center_name.Text);
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            try
            {
                center_no.Text = Properties.Settings.Default.CenterNo;
                center_code.Text = Properties.Settings.Default.CenterCode;
                center_name.Text = Properties.Settings.Default.CenterName;
                email_address.Text = Properties.Settings.Default.Email;
                contact_number.Text = Properties.Settings.Default.Contact;


                DBName.Text = Properties.Settings.Default.dbName;
                DBUser.Text = Properties.Settings.Default.dbUser;
                DBServer.Text = Properties.Settings.Default.dbServer;
                //DBPassword.Text = Properties.Settings.Default.dbPassword;



                if (connection.State == ConnectionState.Closed) { connection.Open(); }
               
                command = new MySqlCommand("SELECT * FROM center_info WHERE IsDefault = 'True'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    center_no.Text = reader[0].ToString();
                    center_code.Text = reader[1].ToString();
                    center_name.Text = reader[2].ToString();
                    email_address.Text = reader[4].ToString();
                    contact_number.Text = reader[3].ToString();                    
                }

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close();  }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand(string.Format("UPDATE center_info SET Center_Code = '{1}', Center_name = '{2}', Contact_Number = '{3}', Email_Address = '{4}' WHERE  IsDefault = 'True'", center_no.Text, center_code.Text, center_name.Text, contact_number.Text, email_address.Text), connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
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
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close(); }
        }

        private void dbSave_Click(object sender, EventArgs e)
        {
            try
            {              
                if(DBUser.Text != "") { Properties.Settings.Default.dbUser = DBUser.Text; }
                if (DBPassword.Text != "") { Properties.Settings.Default.dbPassword = DBPassword.Text; }
                if (DBName.Text != "") { Properties.Settings.Default.dbName = DBName.Text; }
                if(DBServer.Text != "") { Properties.Settings.Default.dbServer = DBServer.Text; }

                Properties.Settings.Default.Save();
                    

                XtraMessageBox.Show("Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
        }
    }
}
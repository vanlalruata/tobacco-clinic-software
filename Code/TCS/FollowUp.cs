using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using static ConnectionString;
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class FollowUp : DevExpress.XtraEditors.XtraForm
    {
        public FollowUp()
        {
            InitializeComponent();
        }

        private string detail = "";
        private void ClearAll()
        {
            //client_no.SelectedIndex = -1;
            fu_visit.SelectedIndex = -1;
            use_status.ResetText();
            continine.SelectedIndex = -1;
            CO_Breath_test.SelectedIndex = -1;
            CO_level.SelectedIndex = -1;
            treatment.SelectedIndex = -1;
            medication.SelectedIndex = -1;
            source_info.SelectedIndex = -1;
            remark_box.ResetText();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            client_no.SelectedIndex = -1;
            fu_visit.SelectedIndex = -1;            
            use_status.ResetText();
            continine.SelectedIndex = -1;
            CO_Breath_test.SelectedIndex = -1;
            CO_level.SelectedIndex = -1;
            treatment.SelectedIndex = -1;
            medication.SelectedIndex = -1;
            source_info.SelectedIndex = -1;
            remark_box.ResetText();
        }

        private void CO_Breath_test_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CO_Breath_test.SelectedIndex == 0)
                { CO_level.Enabled = true; }
                else
                { CO_level.SelectedIndex = -1; CO_level.Enabled = false; }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void treatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (treatment.SelectedIndex == 0)
                { medication.SelectedIndex = -1; medication.Enabled = false; }
                else
                { medication.Enabled = true; }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void RetriveAll()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                

                command = new MySqlCommand(string.Format("SELECT client_no, visit_no,visiting_date,use_status,contine_test,CO_analysis, CO_Level, Treatment, Medication,Source_Info, Remark FROM follow_up WHERE client_no={0}", Convert.ToInt32(client_no.Text)), connection);
                reader = command.ExecuteReader();

                listView1.Clear();
                listView1.Columns.Add("Client No", 70);
                listView1.Columns.Add("FU Visit", 70);
                listView1.Columns.Add("Visit Date", 70);
                listView1.Columns.Add("Status", 70);
                listView1.Columns.Add("Contine Test", 70);
                listView1.Columns.Add("CO Breath Test", 70);
                listView1.Columns.Add("CO Level", 60);
                listView1.Columns.Add("Treatment", 90);
                listView1.Columns.Add("Medication", 90);
                listView1.Columns.Add("Source Info", 90);
                listView1.Columns.Add("Remark", 120);

                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(string.Format("{0:dd/MM/yyyy}", reader[2]));
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());
                    lvItem.SubItems.Add(reader[6].ToString());
                    lvItem.SubItems.Add(reader[7].ToString());
                    lvItem.SubItems.Add(reader[8].ToString());
                    lvItem.SubItems.Add(reader[9].ToString());
                    lvItem.SubItems.Add(reader[10].ToString());
                    listView1.Items.Add(lvItem);
                }

                listView1.Sorting = SortOrder.Ascending;
                listView1.Sort();

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close();  }
        }

        private void FollowUp_Load(object sender, EventArgs e)
        {
            //RetriveAll();
            LoadClient();
            Medicate();
        }

        private void LoadClient()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                
                //Load Client Medication Detail                

                command = new MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register", connection);
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
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close();  }
        }

        private void Medicate()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }

                //Load Client Medication Detail                
                
                command = new MySqlCommand("SELECT DISTINCT(Medicine_Name) FROM phar_stock", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = medication.Properties.Items;
                
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }
                coll.EndUpdate();

                reader.Close();

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close();  }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            using (MySqlTransaction trans = connection.BeginTransaction())
            {
                try
                {
                    if (client_no.Text == "")
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Client No. and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (fu_visit.SelectedIndex == -1)
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the FU Visitng and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (visiting_date.Text == "")
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Visiting Date and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (use_status.Text == "")
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Use Status Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (continine.SelectedIndex == -1)
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Continine Use Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    if (CO_Breath_test.SelectedIndex == -1)
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the CO Analysis Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                                 



                    command = new MySqlCommand(string.Format("INSERT INTO follow_up (client_no, visit_no,visiting_date,use_status,contine_test,CO_analysis, CO_Level, Treatment, Medication,Source_Info, Remark, diagnosis, gender) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}', '{12}')", client_no.Text, fu_visit.Text, string.Format("{0:yyyy-MM-dd}", visiting_date.EditValue), use_status.Text, continine.Text, CO_Breath_test.Text, CO_level.Text, treatment.Text, medication.Text, source_info.Text, remark_box.Text, addictionTypeText.Text, genderText.Text), connection, trans);
                    int i = command.ExecuteNonQuery();
                    if (i == 1)
                    {
                        XtraMessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //update table
                        command = new MySqlCommand(string.Format("UPDATE follow_up_status SET follow_date = '{0}', status = '{1}', detail = '{2}' WHERE client_no = {3}", string.Format("{0:yyyy-MM-dd}", visiting_date.EditValue), use_status.Text, detail, client_no.Text), connection, trans);
                        command.ExecuteNonQuery();


                        trans.Commit();
                        ClearAll();
                        RetriveAll();
                    }
                    else
                    { DevExpress.XtraEditors.XtraMessageBox.Show("Record Not Added Successfully!", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message + "\n\nPlease Check the Client No. or the FU Visiting No.\nNo Duplicate Entry Can be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); trans.Rollback(); }
                finally { connection.Close(); }
            }
                
        }

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text == "") { return; }
              

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                
                command = new MySqlCommand(string.Format("SELECT client_name, diagnosis_dtl, gender FROM intake_register WHERE client_no = {0}", Convert.ToInt32(client_no.Text)), connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nameText.Text = "Name :          " + reader[0].ToString();
                    addictionTypeText.Text = reader[1].ToString();
                    genderText.Text = reader[2].ToString();
                }

                connection.Close();
                RetriveAll();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close();  }
        }

        private void client_no_Validating(object sender, CancelEventArgs e)
        {
            //try
            //{
            //    if(client_no.Text == "") { return; }
            //
            //    if (connection.State == ConnectionState.Closed) { connection.Open(); }
            //
            //    command = new MySqlCommand(string.Format("SELECT client_name FROM intake_register WHERE client_no = {0}", Convert.ToInt32(client_no.Text)), connection);
            //    reader = command.ExecuteReader();
            //
            //    while(reader.Read())
            //    {
            //        nameText.Text = "Name :          " + reader[0].ToString();
            //    }
            //
            //    connection.Close();
            //    RetriveAll();
            //}
            //catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            //finally { connection.Close(); }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text == "")
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Client No. and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (fu_visit.SelectedIndex == -1)
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the FU Visitng and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (visiting_date.Text == "")
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Visiting Date and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (use_status.Text == "")
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Use Status Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (continine.SelectedIndex == -1)
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the Continine Use Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (CO_Breath_test.SelectedIndex == -1)
                { DevExpress.XtraEditors.XtraMessageBox.Show("Please Check the CO Analysis Field and try to save it again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand(string.Format("UPDATE follow_up SET visiting_date = '{0}', use_status = '{1}',contine_test = '{2}',CO_analysis = '{3}', CO_Level = '{4}', Treatment = '{5}', Medication = '{6}',Source_Info = '{7}', Remark = '{8}'  WHERE client_no={9} AND visit_no = '{10}'", string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(visiting_date.Text)), use_status.Text,  continine.Text, CO_Breath_test.Text, CO_level.Text, treatment.Text, medication.Text, source_info.Text, remark_box.Text, client_no.Text, fu_visit.Text), connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    RetriveAll();
                }
                else
                { DevExpress.XtraEditors.XtraMessageBox.Show("Record Not Updated! Something went wrong", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close(); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               

                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];

                    if (item.SubItems[0].Text == "") { return; }

                    client_no.Text = item.SubItems[0].Text.ToString();
                    fu_visit.Text = item.SubItems[1].Text;
                    visiting_date.EditValue = Convert.ToDateTime(item.SubItems[2].Text);
                    use_status.Text = item.SubItems[3].Text;

                    
                    if(item.SubItems[4].Text == "Done")
                    { continine.SelectedIndex = 0; }
                    else { continine.SelectedIndex = 1; }

                    if (item.SubItems[5].Text == "Done")
                    { CO_Breath_test.SelectedIndex = 0; }
                    else { CO_Breath_test.SelectedIndex = 1; }
                    
                    CO_level.Text = item.SubItems[6].Text;
                    treatment.Text = item.SubItems[7].Text;
                    medication.Text = item.SubItems[8].Text;
                    source_info.Text = item.SubItems[9].Text;
                    remark_box.Text = item.SubItems[10].Text;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                DetailSearch myControl = new DetailSearch();
                DevExpress.XtraEditors.XtraDialog.Show(myControl, "SEARCH", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void use_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                detail = "";
                if(use_status.SelectedIndex == 2)
                {
                    ReasonToLost myControl = new ReasonToLost();
                    DevExpress.XtraEditors.XtraDialog.Show(myControl, "Reason for Lost to Followup", MessageBoxButtons.OK);
                    detail = myControl.reasonfor;
                }          

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
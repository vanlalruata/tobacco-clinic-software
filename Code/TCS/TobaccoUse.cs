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
using DevExpress.XtraEditors.Controls;

namespace TCS
{
    public partial class TobaccoUse : DevExpress.XtraEditors.XtraForm
    {
        public TobaccoUse()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(client_no.Text == "") { DevExpress.XtraEditors.XtraMessageBox.Show("Can't leave blank the Client No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                string com = string.Format("INSERT INTO detail_tobacco_use(client_no,smoking_type,tobacco_product,age_onset, avg_perday,years_of_tobacco_use,years_of_regular,avg_in_chew) VALUES ($CLIENTNO$,'{1}','{2}',{3},{4},{5},{6},{7});", client_no.Text, tobacco_type.Text, tobacconame.Text, ageonset.EditValue, avg_day.EditValue, no_year.EditValue, total_year.EditValue, total_chew.EditValue);
                tobaccouse.AppendLine(com);

                t_use = true;

                RetriveAll();

                if (DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Added! Do you want to add another Tobacco Use?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                }
                ClearAll();
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearAll()
        {
            //tobacco_type.ResetText();
            tobacconame.ResetText();
            avg_day.ResetText();
            total_chew.ResetText();
            total_year.ResetText();
            no_year.ResetText();
            ageonset.ResetText();            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void RetriveAll()
        {
            try
            {
                if (listView1.Columns.Count < 1)
                {
                    listView1.Columns.Add("Client No", 70);
                    listView1.Columns.Add("Type", 70);
                    listView1.Columns.Add("Tobacco Product", 100);
                    listView1.Columns.Add("Age Onset", 70);
                    listView1.Columns.Add("AVG per Day", 80);
                    listView1.Columns.Add("Use Years", 70);
                    listView1.Columns.Add("Regualar Year", 90);
                    listView1.Columns.Add("AVG Chew", 70);
                }
                addtolist();       
                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally
            { 
            }
        }

        private void addtolist()
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.SubItems[0].Text = client_no.Text.ToString();
            lvItem.SubItems.Add(tobacco_type.Text);
            lvItem.SubItems.Add(tobacconame.Text.ToString());
            lvItem.SubItems.Add(ageonset.Text.ToString());
            lvItem.SubItems.Add(avg_day.Text.ToString());
            lvItem.SubItems.Add(no_year.Text.ToString());
            lvItem.SubItems.Add(total_year.Text.ToString());
            lvItem.SubItems.Add(total_chew.Text.ToString());
            listView1.Items.Add(lvItem);
        }        

        private void TobaccoUse_Load(object sender, EventArgs e)
        {
            tobaccouse.Clear();
            t_use = false;

       }

      

        private void tobacconame_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(tobacconame.SelectedIndex == 0 || tobacconame.SelectedIndex == 1 || tobacconame.SelectedIndex == 2)
                {
                    tobacco_type.SelectedIndex = 0;
                }
                else if (tobacconame.SelectedIndex == 3 || tobacconame.SelectedIndex == 4 || tobacconame.SelectedIndex == 5 || tobacconame.SelectedIndex == 6)
                {
                    tobacco_type.SelectedIndex = 1;
                }
            }

            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
        }

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(client_no.Text == "") { return; }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                listView1.Clear();
                listView1.Columns.Add("Client No", 70);
                listView1.Columns.Add("Type", 70);
                listView1.Columns.Add("Tobacco Product", 100);
                listView1.Columns.Add("Age Onset", 70);
                listView1.Columns.Add("AVG per Day", 80);
                listView1.Columns.Add("Use Years", 70);
                listView1.Columns.Add("Regualar Year", 90);
                listView1.Columns.Add("AVG Chew", 70);

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM detail_tobacco_use WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());
                    lvItem.SubItems.Add(reader[6].ToString());
                    lvItem.SubItems.Add(reader[7].ToString());
                    listView1.Items.Add(lvItem);
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM detail_tobacco_use WHERE client_no = {0} AND smoking_type = '{1}' AND tobacco_product='{2}'", client_no.Text, tobacco_type.Text, tobacconame.Text), connection);
                reader = command.ExecuteReader();

                int x = 0;

                while (reader.Read())
                { x += 1; }

                reader.Close();

                if (x == 0)
                {
                    //INSERT COMMAND

                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("INSERT INTO detail_tobacco_use VALUES({0}, '{1}', '{2}', {3}, {4}, {5}, {6}, {7});", Convert.ToInt32(client_no.Text), tobacco_type.Text, tobacconame.Text, ageonset.EditValue, avg_day.EditValue, no_year.EditValue, total_year.EditValue, total_chew.EditValue), connection);
                    int i = command.ExecuteNonQuery();

                    if (i == 1)
                    {
                        XtraMessageBox.Show("Successfully Updated!", "Done");
                    }
                    else
                    {
                        XtraMessageBox.Show("Something Went Wrong or Record not found!", "Error");
                    }
                }

                else
                {
                    //UPDATE COMMAND


                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("UPDATE detail_tobacco_use SET age_onset={3},avg_perday={4},years_of_tobacco_use={5},years_of_regular={6},avg_in_chew={7} WHERE client_no = {0} AND smoking_type = '{1}' AND tobacco_product='{2}'", Convert.ToInt32(client_no.Text), tobacco_type.Text, tobacconame.Text, ageonset.EditValue, avg_day.EditValue, no_year.EditValue, total_year.EditValue, total_chew.EditValue), connection);
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        XtraMessageBox.Show("Successfully Updated!", "Done");
                    }
                    else
                    {
                        XtraMessageBox.Show("Something Went Wrong or Record not found!", "Error");
                    }
                }

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); RetriveAgain();
            }
        }

        private void RetriveAgain()
        {
            try
            {
                if (client_no.Text == "") { return; }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                listView1.Clear();
                listView1.Columns.Add("Client No", 70);
                listView1.Columns.Add("Type", 70);
                listView1.Columns.Add("Tobacco Product", 100);
                listView1.Columns.Add("Age Onset", 70);
                listView1.Columns.Add("AVG per Day", 80);
                listView1.Columns.Add("Use Years", 70);
                listView1.Columns.Add("Regualar Year", 90);
                listView1.Columns.Add("AVG Chew", 70);

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM detail_tobacco_use WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());
                    lvItem.SubItems.Add(reader[6].ToString());
                    lvItem.SubItems.Add(reader[7].ToString());
                    listView1.Items.Add(lvItem);
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
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
                
               if (listView1.SelectedItems.Count < 1)
               {
                    ClearAll();
                    return;
               }                    

                ClearAll();
                //Command for Printing will Go on here
                ListViewItem item = listView1.SelectedItems[0];
                client_no.Text = item.SubItems[0].Text;
                tobacco_type.Text = item.SubItems[1].Text;
                tobacconame.Text = item.SubItems[2].Text;
                ageonset.EditValue = Convert.ToInt32(item.SubItems[3].Text);
                avg_day.EditValue = Convert.ToInt32(item.SubItems[4].Text);
                no_year.EditValue = Convert.ToInt32(item.SubItems[5].Text);
                total_year.EditValue = Convert.ToInt32(item.SubItems[6].Text);
                total_chew.EditValue = Convert.ToInt32(item.SubItems[7].Text);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
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

namespace TCS
{
    public partial class Substances : DevExpress.XtraEditors.XtraForm
    {
        public Substances()
        {
            InitializeComponent();
        }

        private void RetriveAll()
        {
            try
            {
                if (listView1.Columns.Count < 1)
                {
                    listView1.Columns.Add("Client No", 70);
                    listView1.Columns.Add("Substance Used", 100);
                    listView1.Columns.Add("Pattern Used", 100);
                    listView1.Columns.Add("Dependance", 90);
                    listView1.Columns.Add("AVG Amount", 80);
                    listView1.Columns.Add("Remark", 70);
                }
                               
                ListViewItem lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = client_no.Text;
                    lvItem.SubItems.Add(sub_used.Text);
                    lvItem.SubItems.Add(pattern_use.EditValue.ToString());
                    lvItem.SubItems.Add(depend.Text);
                    lvItem.SubItems.Add(avg_unit.EditValue.ToString());
                    lvItem.SubItems.Add(remark_box.Text);
                    listView1.Items.Add(lvItem);               


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {                                                     
                    substancex.AppendLine(string.Format("INSERT INTO intake_substance VALUES ($CLIENTNO$, '{1}', '{2}', '{3}', '{4}', '{5}')", client_no.Text, sub_used.Text, pattern_use.Text, depend.Text, avg_unit.Text, remark_box.Text));
                    substa = true;

                RetriveAll();

                    if (DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Registered! Do you want to add another substance?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.Close();
                    }
                    ClearAll();               
                
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void ClearAll()
        {
            sub_used.ResetText();
            pattern_use.ResetText();
            depend.SelectedIndex = 1;
            avg_unit.ResetText();
            remark_box.ResetText();            
        }

        private void Substances_Load(object sender, EventArgs e)
        {
            substancex.Clear();
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM intake_substance WHERE client_no = {0} AND substance_used = '{1}'", client_no.Text, sub_used.Text), connection);
                reader = command.ExecuteReader();

                int x = 0;

                while (reader.Read())
                { x += 1; }

                reader.Close();

                if (x == 0)
                {
                    //INSERT COMMAND

                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("INSERT INTO intake_substance VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}');", Convert.ToInt32(client_no.Text), sub_used.Text, pattern_use.EditValue.ToString(), depend.Text, avg_unit.EditValue.ToString(), remark_box.Text), connection);
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


                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("UPDATE intake_substance SET pattern_use='{2}',dependance='{3}',average_amount='{4}',remark='{5}' WHERE client_no = {0} AND substance_used = '{1}'", Convert.ToInt32(client_no.Text), sub_used.Text, pattern_use.EditValue.ToString(), depend.Text, avg_unit.EditValue.ToString(), remark_box.Text), connection);
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
            catch (Exception ex)
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
                listView1.Columns.Add("Substance Used", 100);
                listView1.Columns.Add("Pattern Used", 100);
                listView1.Columns.Add("Dependance", 90);
                listView1.Columns.Add("AVG Amount", 80);
                listView1.Columns.Add("Remark", 70);
                

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM intake_substance WHERE client_no = {0}", client_no.Text), connection);
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

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {            
                RetriveAgain();                     
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
                sub_used.Text = item.SubItems[1].Text;
                pattern_use.Text = item.SubItems[2].Text;
                if(item.SubItems[3].Text == "Yes")
                { depend.SelectedIndex = 0; }
                else
                { depend.SelectedIndex = 1; }                
                avg_unit.EditValue = Convert.ToInt32(item.SubItems[4].Text);
                remark_box.Text = item.SubItems[5].Text;
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
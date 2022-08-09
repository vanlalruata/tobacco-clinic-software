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
    public partial class Severity : DevExpress.XtraEditors.XtraForm
    {
        public string client_code = "A0001";
        private int _smokerscale = 0;
        private int _smokerlessscale = 0;
        public bool inedit;

        public Severity()
        {
            InitializeComponent();
        }

        public void LoadClient()
        {
            try {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }
                
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
            catch(Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally { connection.Close();  }
        }

        private void Severity_Load(object sender, EventArgs e)
        {
            try
            {
                scale_smoke.Clear();
                scale_smokeless.Clear();

                if (diagnosis == "None") { dignosis_box.SelectedIndex = 3; }
                else if (diagnosis == "Smoking") { dignosis_box.SelectedIndex = 0; }
                else if (diagnosis == "Smokeless") { dignosis_box.SelectedIndex = 1; }
                else if (diagnosis == "Both") { dignosis_box.SelectedIndex = 2; }
                else { dignosis_box.SelectedIndex = -1; }

                
                //LoadClient();                    
                
            
                seve = false;


            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }

            finally { }          
        }

        private void dignosis_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(dignosis_box.SelectedIndex == 0)
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;

                    groupBox1.Location = new Point(20, 48);

                    this.Size = new Size(696, 576);

                    clear_btn.Location = new Point(574, 56);
                    save_btn.Location = new Point(574, 187);
                    modify_btn.Location = new Point(574, 122);
                    
                }
                else if (dignosis_box.SelectedIndex == 1)
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;

                    groupBox2.Location = new Point(20, 48);

                    this.Size = new Size(696, 576);

                    clear_btn.Location = new Point(574, 56);
                    save_btn.Location = new Point(574, 187);
                    modify_btn.Location = new Point(574, 122);
                    
                }
                else if (dignosis_box.SelectedIndex == 2)
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    groupBox1.Location = new Point(20, 48);
                    groupBox2.Location = new Point(574, 47);

                    this.Size = new Size(1234, 576);

                    clear_btn.Location = new Point(1112, 56);
                    save_btn.Location = new Point(1112, 187);
                    modify_btn.Location = new Point(1112, 122);

                    
                }
                else
                {
                    this.Size = new Size(696, 576);

                    groupBox1.Visible = false;
                    groupBox2.Visible = false;

                    clear_btn.Visible = false;
                    save_btn.Visible = false;
                    modify_btn.Visible = false;
                }

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void SmokerScale()
        {
            try
            {
                int firstuse = 0;
                int forbid = 0;
                int fiveup = 0;
                int staybed = 0;
                int smokeday = 0;
                int restday = 0;

                if (first_use.SelectedIndex == 0)
                { firstuse = 3; }
                else if (first_use.SelectedIndex == 1)
                { firstuse = 2; }
                else if (first_use.SelectedIndex == 2)
                { firstuse = 1; }
                else
                { firstuse = 0; }

                if (forbiddent.SelectedIndex == 0)
                { forbid = 1; }
                else { forbid = 0; }

                if (five_up.SelectedIndex == 0)
                { fiveup = 1; }
                else { fiveup = 0; }

                if (stay_bed.SelectedIndex == 0)
                { staybed = 1; }
                else { staybed = 0; }

                if (smoke_day.SelectedIndex == 0)
                { smokeday = 0; }
                else if (smoke_day.SelectedIndex == 1)
                { smokeday = 1; }
                else if (smoke_day.SelectedIndex == 2)
                { smokeday = 2; }
                else { smokeday = 3; }

                if (rest_day.SelectedIndex == 0)
                { restday = 1; }
                else { restday = 0; }

                _smokerscale = restday + smokeday + staybed + forbid + firstuse + fiveup;
                this.smokerscorebox.Text = Convert.ToString(restday + smokeday + staybed + forbid + firstuse + fiveup);
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }

        }

        private void SmokelessScale()
        {
            try
            {
                int wake = 0;
                int mouth = 0;
                int per = 0;
                int spit = 0;
                int dip = 0;
                int strong = 0;
                int mouthchew = 0;
                int last = 0;
                int chew = 0;

                if (waking_use.SelectedIndex == 0)
                {
                    wake = 1;
                }
                else { wake = 0; }

                if (mouth_sores.SelectedIndex == 0)
                {
                    mouth = 1;
                }
                else { mouth = 0; }

                if (per_week.SelectedIndex == 0)
                {
                    per = 0;
                }
                else if (per_week.SelectedIndex == 1)
                {
                    per = 1;
                }
                else { per = 2; }

                if (spit_juice.SelectedIndex == 0)
                {
                    spit = 0;
                }
                else if (spit_juice.SelectedIndex == 1)
                {
                    spit = 1;
                }
                else
                {
                    spit = 2;
                }

                if (dip_chew.SelectedIndex == 0)
                {
                    dip = 1;
                }
                else { dip = 0; }

                if (strong_carving.SelectedIndex == 0)
                {
                    strong = 1;
                }
                else { strong = 0; }

                if (mouth_chew.SelectedIndex == 0)
                {
                    mouthchew = 1;
                }
                else if (mouth_chew.SelectedIndex == 1)
                {
                    mouthchew = 2;
                }
                else if (mouth_chew.SelectedIndex == 2)
                {
                    mouthchew = 3;
                }
                else { mouthchew = 0; }

                if (last_chew.SelectedIndex == 0)
                {
                    last = 0;
                }
                else if (last_chew.SelectedIndex == 1)
                {
                    last = 1;
                }
                else { last = 2; }

                if (chew_day.SelectedIndex == 0)
                {
                    chew = 1;
                }
                else if (chew_day.SelectedIndex == 1)
                {
                    chew = 2;
                }
                else if (chew_day.SelectedIndex == 2)
                {
                    chew = 3;
                }
                else { chew = 0; }

                _smokerlessscale = wake + mouth + per + spit + dip + strong + mouthchew + last + chew;

                this.smokelessscorebox.Text = Convert.ToString(wake + mouth + per + spit + dip + strong + mouthchew + last + chew);
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void ClearAll()
        {
            if(dignosis_box.SelectedIndex == 0 || dignosis_box.SelectedIndex == 2)
            {  //Smoking Severity
                first_use.SelectedIndex = 3;
                forbiddent.SelectedIndex = 1;
                five_up.SelectedIndex = 1;
                stay_bed.SelectedIndex = 1;
                smoke_day.SelectedIndex = 0;
                rest_day.SelectedIndex = 1;
            }

            if (dignosis_box.SelectedIndex == 1 || dignosis_box.SelectedIndex == 2)
            {
                //SmokelessSeverity
                waking_use.SelectedIndex = 1;
                mouth_sores.SelectedIndex = 1;
                per_week.SelectedIndex = 0;
                spit_juice.SelectedIndex = 0;
                dip_chew.SelectedIndex = 1;
                strong_carving.SelectedIndex = 1;
                mouth_chew.SelectedIndex = 3;
                last_chew.SelectedIndex = 0;
                chew_day.SelectedIndex = 3;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception Ex) { DevExpress.XtraEditors.XtraMessageBox.Show(Ex.Message, "Error"); }
        }

        private void chew_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { SmokelessScale(); }
            catch (Exception Ex) { DevExpress.XtraEditors.XtraMessageBox.Show(Ex.Message, "Error"); }
        }

        private void rest_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { SmokerScale(); }
            catch (Exception Ex) { DevExpress.XtraEditors.XtraMessageBox.Show(Ex.Message, "Error"); }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                scale_smoke.Clear();
                scale_smokeless.Clear();

                              
                scale_smoke.Append(string.Format("INSERT INTO scale_smoker(client_no, how_soon,find_diff,hate_to_giveup,stay_in_bed,smoke_a_day,rest_a_day,score_total) VALUES($CLIENTNO$,'{1}','{2}','{3}','{4}','{5}','{6}','{7}');", client_no.Text, first_use.Text, forbiddent.Text, five_up.Text, stay_bed.Text, smoke_day.Text, rest_day.Text, smokerscorebox.Text));
                scale_smokeless.Append(string.Format("INSERT INTO scale_smokeless(client_no, normal_sleep, sick_use, per_week, swallow, all_time, two_hour, avg_mouth, length_dip, avg_daily, score_total) VALUES($CLIENTNO$, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');", client_no.Text, waking_use.Text, mouth_sores.Text, per_week.Text, spit_juice.Text, dip_chew.Text, strong_carving.Text, mouth_chew.Text, last_chew.Text, chew_day.Text, smokelessscorebox.Text));

                seve = true;

                DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Registered! The dialog will be closed now!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    this.Close();                
                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client_no.Text == "") { return; }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                using (MySqlTransaction trans = connection.BeginTransaction())
                {
                    try
                    {

                        command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM scale_smoker WHERE client_no = {0}", client_no.Text), connection);
                        reader = command.ExecuteReader();

                        int x = 0;

                        while (reader.Read())
                        { x += 1; }

                        reader.Close();

                        if (x == 0)
                        {
                            //INSERT SMOKER
                            command = new MySqlCommand(string.Format("INSERT INTO scale_smoker(client_no, how_soon,find_diff,hate_to_giveup,stay_in_bed,smoke_a_day,rest_a_day,score_total) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7});", client_no.Text, first_use.Text, forbiddent.Text, five_up.Text, stay_bed.Text, smoke_day.Text, rest_day.Text, smokerscorebox.Text), connection, trans);
                            command.ExecuteNonQuery();
                        }

                        else
                        {
                            //Update
                            command = new MySqlCommand(string.Format("UPDATE scale_smoker SET how_soon='{1}',find_diff='{2}',hate_to_giveup='{3}',stay_in_bed='{4}',smoke_a_day='{5}',rest_a_day='{6}',score_total={7} WHERE client_no = {0}", client_no.Text, first_use.Text, forbiddent.Text, five_up.Text, stay_bed.Text, smoke_day.Text, rest_day.Text, smokerscorebox.Text), connection, trans);
                            command.ExecuteNonQuery();
                        }


                        command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM scale_smokeless WHERE client_no = {0}", client_no.Text), connection);
                        reader = command.ExecuteReader();

                        x = 0;

                        while (reader.Read())
                        { x += 1; }

                        reader.Close();

                        if (x == 0)
                        {
                            //INSERT SMOKELess
                            command = new MySqlCommand(string.Format("INSERT INTO scale_smokeless(client_no, normal_sleep, sick_use, per_week, swallow, all_time, two_hour, avg_mouth, length_dip, avg_daily, score_total) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10});", client_no.Text, waking_use.Text, mouth_sores.Text, per_week.Text, spit_juice.Text, dip_chew.Text, strong_carving.Text, mouth_chew.Text, last_chew.Text, chew_day.Text, smokelessscorebox.Text), connection, trans);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            //Update
                            command = new MySqlCommand(string.Format("UPDATE scale_smokeless SET normal_sleep='{1}', sick_use='{2}', per_week='{3}', swallow='{4}', all_time='{5}', two_hour='{6}', avg_mouth='{7}', length_dip='{8}', avg_daily='{9}', score_total={10} WHERE client_no={0}", client_no.Text, waking_use.Text, mouth_sores.Text, per_week.Text, spit_juice.Text, dip_chew.Text, strong_carving.Text, mouth_chew.Text, last_chew.Text, chew_day.Text, smokelessscorebox.Text), connection, trans);
                            command.ExecuteNonQuery();
                        }
                        trans.Commit();
                        XtraMessageBox.Show("Successfully Updated!", "Done");
                    }

                    catch (Exception ex) { trans.Rollback(); XtraMessageBox.Show(ex.Message); }                    
                }
          
            }  
            catch(Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
        }

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(client_no.Text == "") { return; }

                if(connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand(string.Format("SELECT diagnosis_dtl, client_name FROM intake_register WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    dignosis_box.Text = reader[0].ToString();
                    labelControl18.Text = "Name : " + reader[1].ToString();
                }

                reader.Close();

                LoadInfo(client_no.Text);
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { connection.Close(); }
        }

        private void LoadInfo(string id)
        {
            ClearAll();

            command = new MySqlCommand(string.Format("SELECT * FROM scale_smoker WHERE client_no = {0}", id), connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                if(reader[1].ToString() == "Within 5 Minute") { first_use.SelectedIndex = 0; }
                else if (reader[1].ToString() == "6 - 30 Minutes") { first_use.SelectedIndex = 1; }
                else if (reader[1].ToString() == "31 - 60 Minutes") { first_use.SelectedIndex = 2; }
                else { first_use.SelectedIndex = 3; }

                if (reader[2].ToString() == "Yes") { forbiddent.SelectedIndex = 0; }
                else { forbiddent.SelectedIndex = 1; }

                if (reader[3].ToString() == "First thing in morning") { five_up.SelectedIndex = 0; }
                else { five_up.SelectedIndex = 1; }

                if (reader[4].ToString() == "Yes") { stay_bed.SelectedIndex = 0; }
                else { stay_bed.SelectedIndex = 1; }

                if (reader[5].ToString() == "10 or less") { smoke_day.SelectedIndex = 0; }
                else if (reader[5].ToString() == "11 to 20") { smoke_day.SelectedIndex = 1; }
                else if (reader[5].ToString() == "21 to 30") { smoke_day.SelectedIndex = 2; }
                else { smoke_day.SelectedIndex = 3; }

                if (reader[6].ToString() == "Yes") { rest_day.SelectedIndex = 0; }
                else { rest_day.SelectedIndex = 1; }

            }

            reader.Close();

            command = new MySqlCommand(string.Format("SELECT * FROM scale_smokeless WHERE client_no = {0}", id), connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                if (reader[1].ToString() == "Yes") { waking_use.SelectedIndex = 0; }
                else { waking_use.SelectedIndex = 1; }

                if (reader[2].ToString() == "Yes") { mouth_sores.SelectedIndex = 0; }
                else { mouth_sores.SelectedIndex = 1; }

                if (reader[3].ToString() == "Less than 2 times") { per_week.SelectedIndex = 0; }
                else if (reader[3].ToString() == "More than 2 times") { per_week.SelectedIndex = 1; }                
                else { per_week.SelectedIndex = 2; }

                if (reader[4].ToString() == "Never") { spit_juice.SelectedIndex = 0; }
                else if (reader[4].ToString() == "Sometime") { spit_juice.SelectedIndex = 1; }
                else { spit_juice.SelectedIndex = 2; }

                if (reader[5].ToString() == "Yes") { dip_chew.SelectedIndex = 0; }
                else { dip_chew.SelectedIndex = 1; }

                if (reader[6].ToString() == "Yes") { strong_carving.SelectedIndex = 0; }
                else { strong_carving.SelectedIndex = 1; }

                if (reader[7].ToString() == "10-19 minutes") { mouth_chew.SelectedIndex = 0; }
                else if (reader[7].ToString() == "20-29 minutes") { mouth_chew.SelectedIndex = 1; }
                else if (reader[7].ToString() == "More than 30") { mouth_chew.SelectedIndex = 2; }
                else { mouth_chew.SelectedIndex = 3; }

                if (reader[8].ToString() == "Less than 14.5 hours") { last_chew.SelectedIndex = 0; }
                else if (reader[8].ToString() == "More than 14.5 hours") { last_chew.SelectedIndex = 1; }
                else { last_chew.SelectedIndex = 2; }

                if (reader[9].ToString() == "1 - 9 times") { chew_day.SelectedIndex = 0; }
                else if (reader[9].ToString() == "10 - 15 times") { chew_day.SelectedIndex = 1; }
                else if (reader[9].ToString() == ">15 times") { chew_day.SelectedIndex = 2; }
                else { chew_day.SelectedIndex = 3; }
            }

            reader.Close();
        }
    }
}
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
using Novacode;
using System.Diagnostics;
using System.IO;

namespace TCS
{
    public partial class IntakeRegister : XtraForm
    {

        

        public IntakeRegister()
        {
            InitializeComponent();
        }


        private void nextButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                page2.PageEnabled = true;
                page1.PageEnabled = false;
                xtraTabControl1.SelectedTabPageIndex += 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void IntakeRegister_Load(object sender, EventArgs e)
        {
            try
            {
                IDS();
                LoadID();
                LoadCenterInfo();
                page2.PageEnabled = false;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }

        }

        private void LoadID()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                client_no.Text = "1";

                command = new MySqlCommand("SELECT client_no FROM intake_register ORDER BY client_no DESC LIMIT 1", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client_no.Text = Convert.ToString(Convert.ToInt32(reader[0]) + 1);
                }
                if (!reader.IsClosed) { reader.Close(); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
        }

        private void IDS()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                client_no.Text = "1";

                command = new MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register ORDER BY client_no", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll;
                coll = client_no.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();

                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }

                coll.EndUpdate();
                if (!reader.IsClosed) { reader.Close(); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
        }


        private void LoadCenterInfo()
        {
            try
            {

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT Center_No, Center_Code FROM center_info", connection);
                reader = command.ExecuteReader();



                ComboBoxItemCollection coll;
                ComboBoxItemCollection col;
                col = center_code.Properties.Items;
                coll = center_no.Properties.Items;
                coll.BeginUpdate();
                coll.Clear();

                col.BeginUpdate();
                col.Clear();

                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                    col.Add(reader[1].ToString());
                }
                coll.EndUpdate();
                col.EndUpdate();
                if (!reader.IsClosed) { reader.Close(); }

                center_code.Text = Properties.Settings.Default.CenterCode;


            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); center_no.Text = Properties.Settings.Default.CenterNo; }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                { page2.PageEnabled = false; }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            try
            {
                page1.PageEnabled = true;
                page2.PageEnabled = false;
                xtraTabControl1.SelectedTabPageIndex -= 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void familihistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (familihistory.SelectedIndex == 0)
                { history_remark.Enabled = true; history_remark.SelectedIndex = 3; }
                else { history_remark.Enabled = false; history_remark.SelectedIndex = 0; }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void alcoholuse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (alcoholuse.SelectedIndex == 0)
                { alcoholpattern.Enabled = true; avgalcoholdrinking.Enabled = true; }
                else { alcoholpattern.Text = "None"; alcoholpattern.Enabled = false; avgalcoholdrinking.Enabled = false; }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void substancedetail_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Substances su = new Substances();
                su.ShowInTaskbar = false;
                su.client_no.Text = this.client_no.Text;
                su.modify_btn.Visible = false;
                su.save_btn.Visible = true;
                su.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                su.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void tobacco_use_btn_Click(object sender, EventArgs e)
        {
            try
            {
                TobaccoUse su = new TobaccoUse();
                su.ShowInTaskbar = false;
                su.client_no.Text = this.client_no.Text;
                su.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                su.addButton.Visible = false;

                su.save_btn.Visible = true;

                if (this.diagnosis.SelectedIndex == 0)
                { su.tobacco_type.SelectedIndex = 0; }
                else if (this.diagnosis.SelectedIndex == 1)
                { su.tobacco_type.SelectedIndex = 1; }
                else { su.tobacco_type.SelectedIndex = 0; }
                su.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void severity_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (diagnosis.Text == "" || diagnosis.SelectedIndex == -1) { XtraMessageBox.Show("Please select the Diagnosis type first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                Severity sv = new Severity();
                sv.ShowInTaskbar = false;
                sv.client_no.Text = this.client_no.Text;
                sv.diagnosis = diagnosis.Text;
                sv.client_no.Enabled = false;
                sv.labelControl18.Text = "Diagnosis : ";
                sv.dignosis_box.Enabled = false;
                sv.inedit = false;
                sv.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void phy_problem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                PhysicalProblem su = new PhysicalProblem();
                su.ShowInTaskbar = false;
                su.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                su.client_no.Text = this.client_no.Text;
                su.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void followupbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FollowUp su = new FollowUp();
                su.ShowInTaskbar = false;
                su.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void othersubstanceuse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (othersubstanceuse.SelectedIndex == 0)
                { substancedetail_btn.Enabled = true; }
                else { substancedetail_btn.Enabled = false; }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private string ToNameText(string name = "")
        {
            try
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                return (myTI.ToTitleCase(name).ToString());
            }
            catch (Exception ex)
            { XtraMessageBox.Show(ex.Message, "Error"); return name; }

        }

        private void name_box_Validating(object sender, CancelEventArgs e)
        {
            name_box.Text = ToNameText(name_box.Text);
            try {
                if (name_box.Text.LastIndexOf('i') == name_box.Text.Length - 1)
                {
                    gender.SelectedIndex = 1;
                }
                else { gender.SelectedIndex = 0; }
            }
            catch(Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void referred_by_Validating(object sender, CancelEventArgs e)
        {
            referred_by.Text = ToNameText(referred_by.Text);
        }

        private void address_box_Validating(object sender, CancelEventArgs e)
        {
            address_box.Text = ToNameText(address_box.Text);
        }

        private void avgalcoholdrinking_Validating(object sender, CancelEventArgs e)
        {
            avgalcoholdrinking.Text = ToNameText(avgalcoholdrinking.Text);
        }

        private void motivation_Validating(object sender, CancelEventArgs e)
        {
            motivation.Text = ToNameText(motivation.Text);
        }

        private void therapist_Validating(object sender, CancelEventArgs e)
        {
            therapist.Text = ToNameText(therapist.Text);
        }

        private void CO_analyst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CO_analyst.SelectedIndex == 0)
                { CO_level.Enabled = true; }
                else { CO_level.ResetText(); CO_level.Enabled = false; }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reg_date.Text != "" || diagnosis.Text != "" || center_no.Text != "" || center_code.Text != "" || name_box.Text != "")
                {
                    Save();
                }
                else { XtraMessageBox.Show("You have to enter the required field!", "Something Missing"); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            {
                //End Transaction or COMMIT
                //connection.Close();
            }
        }

        private void Save()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                using (MySqlTransaction trans = connection.BeginTransaction())
                {
                    try
                    {

                        command = new MySqlCommand(string.Format("INSERT INTO intake_register  VALUES (null, '{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},{15},'{16}',{17},'{18}','{19}', '{20}','{21}','{22}', '{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}')", center_no.Text, center_code.Text, string.Format("{0:yyyy-MM-dd}", reg_date.EditValue), name_box.Text, age_bar.Text, resident.Text, gender.Text, address_box.Text, state_province.Text, edu_qualification.Text, phone_box.Text, occupation.Text, marital_status.Text, referred_by.Text, income.EditValue, quit_attempt.EditValue, diagnosis.Text, monthly_expense.EditValue, alcoholuse.Text, alcoholpattern.Text, avgalcoholdrinking.Text, othersubstanceuse.Text, familihistory.Text, history_remark.Text, weight_phy.Text, height_phy.Text, motivation.Text, treatment.Text, CO_analyst.Text, CO_level.Text, therapist.Text, email_box.Text), connection, trans);
                        int i = command.ExecuteNonQuery();
                        if (i == 1)
                        {

                            long clientid = command.LastInsertedId;
                            client_no.Text = clientid.ToString();

                            //Follow Up Record
                            //Status as New Client
                            command = new MySqlCommand(string.Format("INSERT INTO follow_up_status VALUES ({0}, '{1}', '{1}', '{2}', '{3}', 'NEW', null)", clientid.ToString(), string.Format("{0:yyyy-MM-dd}", reg_date.EditValue), diagnosis.Text, gender.Text), connection, trans);
                            command.ExecuteNonQuery();

                            //Insert All Other Details....

                            //Severity
                            string scale_command = scale_smoke.ToString();
                            scale_command = scale_command.Replace("$CLIENTNO$", clientid.ToString());
                            string scale_com = scale_smokeless.ToString();
                            scale_com = scale_com.Replace("$CLIENTNO$", clientid.ToString());

                            //Tobacco Use Detail
                            string tobaccouse_command = tobaccouse.ToString();
                            tobaccouse_command = tobaccouse_command.Replace("$CLIENTNO$", clientid.ToString());


                            //Substances
                            string substancey_command = substancex.ToString();
                            substancey_command = substancey_command.Replace("$CLIENTNO$", clientid.ToString());

                            //Phy Problem
                            string phyproblem_command = phyproblem.ToString();
                            phyproblem_command = phyproblem_command.Replace("$CLIENTNO$", clientid.ToString());

                            if (seve == true)
                            {
                                command = new MySqlCommand(scale_command, connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(scale_com, connection, trans);
                                command.ExecuteNonQuery();
                            }

                            if (t_use == true)
                            {
                                command = new MySqlCommand(tobaccouse_command, connection, trans);
                                command.ExecuteNonQuery();
                            }

                            if (phypr == true)
                            {
                                command = new MySqlCommand(phyproblem_command, connection, trans);
                                command.ExecuteNonQuery();
                            }


                            if (othersubstanceuse.SelectedIndex == 0 && substa == true)
                            {
                                command = new MySqlCommand(substancey_command, connection, trans);
                                command.ExecuteNonQuery();
                            }

                            trans.Commit();

                            if (XtraMessageBox.Show("Successfully Registered! Do you want to create/print the document now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                DocX letter = DocX.Load(@"intake.docx");

                                // Perform the replace:
                                letter.ReplaceText("%regdate%", reg_date.Text);
                                letter.ReplaceText("%cn%", center_no.Text);
                                letter.ReplaceText("%center%", center_code.Text);
                                letter.ReplaceText("%clientno%", clientid.ToString());
                                letter.ReplaceText("%clientname%", name_box.Text);
                                letter.ReplaceText("%age%", age_bar.Text);
                                letter.ReplaceText("%gender%", gender.Text);
                                letter.ReplaceText("%state%", state_province.Text);
                                letter.ReplaceText("%address%", address_box.Text);
                                letter.ReplaceText("%resident%", resident.Text);
                                letter.ReplaceText("%contact%", phone_box.Text);
                                letter.ReplaceText("%education%", edu_qualification.Text);
                                letter.ReplaceText("%marital%", marital_status.Text);
                                letter.ReplaceText("%occupation%", occupation.Text);
                                letter.ReplaceText("%income%", income.Text);
                                letter.ReplaceText("%referredby%", referred_by.Text);
                                letter.ReplaceText("%expense%", monthly_expense.Text);
                                letter.ReplaceText("%treatment%", treatment.Text);
                                letter.ReplaceText("%weight%", weight_phy.Text);
                                letter.ReplaceText("%height%", height_phy.Text);
                                letter.ReplaceText("%motive%", motivation.Text);
                                letter.ReplaceText("%diagn%", diagnosis.Text);
                                letter.ReplaceText("%coan%", CO_analyst.Text);
                                letter.ReplaceText("%cole%", CO_level.Text);
                                letter.ReplaceText("%thera%", therapist.Text);
                                letter.ReplaceText("%prevat%", quit_attempt.Text);
                                letter.ReplaceText("%alcoholuse%", alcoholuse.Text);
                                letter.ReplaceText("%upat%", alcoholpattern.Text);
                                letter.ReplaceText("%patdr%", avgalcoholdrinking.Text);
                                letter.ReplaceText("%uset%", familihistory.Text);
                                letter.ReplaceText("%usdet%", history_remark.Text);
                                letter.ReplaceText("%othrsub%", othersubstanceuse.Text);
                                letter.ReplaceText("%email%", email_box.Text);

                                StringBuilder stobacco_type = new StringBuilder(string.Format("", ""));
                                StringBuilder stobacco_ageset = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder stobacco_avgper = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder stobacco_noyear = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder stobacco_sachet = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder stobacco_avgnum = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder sltobacco_type = new StringBuilder(string.Format("", ""));
                                StringBuilder sltobacco_ageset = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder sltobacco_avgper = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder sltobacco_noyear = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder sltobacco_sachet = new StringBuilder(string.Format("{0}", "\n"));
                                StringBuilder sltobacco_avgnum = new StringBuilder(string.Format("{0}", "\n"));


                                if (!reader.IsClosed) { reader.Close(); }

                                command = new MySqlCommand("SELECT * FROM detail_tobacco_use WHERE client_no = " + clientid, connection);
                                reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    if (reader[1].ToString() == "Smoking")
                                    {
                                        stobacco_type.Append(string.Format("\n{0}", reader[2].ToString()));
                                        stobacco_ageset.Append(string.Format("\n{0}", reader[3].ToString()));
                                        stobacco_avgper.Append(string.Format("\n{0}", reader[4].ToString()));
                                        stobacco_noyear.Append(string.Format("\n{0}", reader[5].ToString()));
                                        stobacco_sachet.Append(string.Format("\n{0}", reader[6].ToString()));
                                        stobacco_avgnum.Append(string.Format("\n{0}", reader[7].ToString()));
                                    }
                                    else
                                    {
                                        sltobacco_type.Append(string.Format("\n{0}", reader[2].ToString()));
                                        sltobacco_ageset.Append(string.Format("\n{0}", reader[3].ToString()));
                                        sltobacco_avgper.Append(string.Format("\n{0}", reader[4].ToString()));
                                        sltobacco_noyear.Append(string.Format("\n{0}", reader[5].ToString()));
                                        sltobacco_sachet.Append(string.Format("\n{0}", reader[6].ToString()));
                                        sltobacco_avgnum.Append(string.Format("\n{0}", reader[7].ToString()));
                                    }
                                }

                                if (!reader.IsClosed) { reader.Close(); }

                                letter.ReplaceText("%stype%", stobacco_type.ToString());
                                letter.ReplaceText("%sltype%", sltobacco_type.ToString());
                                letter.ReplaceText("%sag%", stobacco_ageset.ToString());
                                letter.ReplaceText("%slag%", sltobacco_ageset.ToString());
                                letter.ReplaceText("%sad%", stobacco_avgper.ToString());
                                letter.ReplaceText("%slad%", sltobacco_avgper.ToString());
                                letter.ReplaceText("%sreg%", stobacco_noyear.ToString());
                                letter.ReplaceText("%slreg%", sltobacco_noyear.ToString());
                                letter.ReplaceText("%sxno%", stobacco_sachet.ToString());
                                letter.ReplaceText("%slxno%", sltobacco_sachet.ToString());
                                letter.ReplaceText("%sanm%", stobacco_avgnum.ToString());
                                letter.ReplaceText("%slanm%", sltobacco_avgnum.ToString());

                                string _cough = "";
                                string _bronchial = "";
                                string _gastro = "";
                                string _cardiac = "";
                                string _oral = "";
                                string _psy = "";
                                string _other = "";

                                command = new MySqlCommand(string.Format("SELECT * FROM phy_problem WHERE client_no = {0}", clientid), connection);
                                reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    if (reader[1].ToString() == "True")
                                    { _cough += " Cough Sputum |"; }

                                    if (reader[2].ToString() == "True")
                                    { _cough += " Dry Cough |"; }

                                    if (reader[3].ToString() == "True")
                                    { _cough += " Sputum Blood"; }

                                    if (reader[4].ToString() == "True")
                                    { _bronchial += " Asthma |"; }

                                    if (reader[5].ToString() == "True")
                                    { _bronchial += " Bronchitis |"; }

                                    if (reader[6].ToString() == "True")
                                    { _bronchial += " Breathless"; }

                                    if (reader[7].ToString() == "True")
                                    { _gastro += " Blood in Stool |"; }

                                    if (reader[8].ToString() == "True")
                                    { _gastro += " Blood in Vomit |"; }

                                    if (reader[9].ToString() == "True")
                                    { _gastro += " Constipation |"; }

                                    if (reader[10].ToString() == "True")
                                    { _gastro += " Dyspepsia |"; }

                                    if (reader[11].ToString() == "True")
                                    { _gastro += " Diarrhoea |"; }

                                    if (reader[12].ToString() == "True")
                                    { _gastro += " Vomiting"; }

                                    if (reader[13].ToString() == "True")
                                    { _cardiac += " Chest Pain |"; }

                                    if (reader[14].ToString() == "True")
                                    { _cardiac += " Hypertension |"; }

                                    if (reader[15].ToString() == "True")
                                    { _cardiac += " Myocardial Infarction"; }

                                    if (reader[16].ToString() == "True")
                                    { _oral += " Erythroplakia |"; }

                                    if (reader[17].ToString() == "True")
                                    { _oral += " Leukoplakia |"; }

                                    if (reader[18].ToString() == "True")
                                    { _oral += " Sub Mucous Fibrosis |"; }

                                    if (reader[19].ToString() == "True")
                                    { _oral += " Mal-Order |"; }

                                    if (reader[20].ToString() == "True")
                                    { _oral += " Ulceration of Oral |"; }

                                    if (reader[21].ToString() == "True")
                                    { _oral += " Dental Caries |"; }

                                    if (reader[22].ToString() == "True")
                                    { _oral += " Staining of Teeth |"; }

                                    if (reader[23].ToString() == "True")
                                    { _oral += " Pain in Gums"; }

                                    if (reader[24].ToString() == "True")
                                    { _psy += " Anxiety |"; }

                                    if (reader[25].ToString() == "True")
                                    { _psy += " Depression |"; }

                                    if (reader[26].ToString() == "True")
                                    { _psy += " Schizophrenia |"; }

                                    if (reader[27].ToString() == "True")
                                    { _psy += " Others"; }

                                    if (reader[28].ToString() == "True")
                                    { _other += " Cancer |"; }

                                    if (reader[29].ToString() == "True")
                                    { _other += " Diabetes |"; }

                                    if (reader[30].ToString() == "True")
                                    { _other += " Sexual Dysfunction |"; }

                                    if (reader[31].ToString() == "True")
                                    { _other += " Stroke |"; }

                                    if (reader[32].ToString() == "True")
                                    { _other += " Seizure Disorder |"; }

                                    if (reader[33].ToString() == "True")
                                    { _other += " TB |"; }

                                    if (reader[34].ToString() == "True")
                                    { _other += " Weight Gain |"; }

                                    if (reader[35].ToString() == "True")
                                    { _other += " BWeight Loss |"; }

                                    letter.ReplaceText("%cough%", string.Format("{0}", _cough));
                                    letter.ReplaceText("%bronchial%", string.Format("{0}", _bronchial));
                                    letter.ReplaceText("%gastro%", string.Format("{0}", _gastro));
                                    letter.ReplaceText("%cardiac%", string.Format("{0}", _cardiac));
                                    letter.ReplaceText("%oral%", string.Format("{0}", _oral));
                                    letter.ReplaceText("%psych%", string.Format("{0}", _psy));
                                    letter.ReplaceText("%othp%", string.Format("{0}", _other));
                                }

                                //incase it is not read
                                letter.ReplaceText("%cough%", "");
                                letter.ReplaceText("%bronchial%", "");
                                letter.ReplaceText("%gastro%", "");
                                letter.ReplaceText("%cardiac%", "");
                                letter.ReplaceText("%oral%", "");
                                letter.ReplaceText("%psych%", "");
                                letter.ReplaceText("%othp%", "");

                                if (!reader.IsClosed) { reader.Close(); }

                                command = new MySqlCommand(string.Format("SELECT * FROM intake_substance WHERE client_no = {0}", clientid), connection);
                                reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    if (reader[1].ToString().ToLower() == "cannabis")
                                    {
                                        //Cannabis  
                                        letter.ReplaceText("%pouc%", string.Format("{0}", reader[2].ToString()));
                                        letter.ReplaceText("%dyc%", string.Format("{0}", reader[3].ToString()));
                                        letter.ReplaceText("%amuc%", string.Format("{0}", reader[4].ToString()));
                                        letter.ReplaceText("%rec%", string.Format("{0}", reader[5].ToString()));
                                    }

                                    if (reader[1].ToString().ToLower() == "benzodiazephines")
                                    {
                                        //Benzo
                                        letter.ReplaceText("%poub%", string.Format("{0}", reader[2].ToString()));
                                        letter.ReplaceText("%dyb%", string.Format("{0}", reader[3].ToString()));
                                        letter.ReplaceText("%amub%", string.Format("{0}", reader[4].ToString()));
                                        letter.ReplaceText("%reb%", string.Format("{0}", reader[5].ToString()));
                                    }

                                    if (reader[1].ToString().ToLower() == "opioids")
                                    {
                                        //Opi
                                        letter.ReplaceText("%pouo%", string.Format("{0}", reader[2].ToString()));
                                        letter.ReplaceText("%dyo%", string.Format("{0}", reader[3].ToString()));
                                        letter.ReplaceText("%amuo%", string.Format("{0}", reader[4].ToString()));
                                        letter.ReplaceText("%reo%", string.Format("{0}", reader[5].ToString()));
                                    }

                                    else
                                    {
                                        //other
                                        letter.ReplaceText("%poua%", string.Format("{0}", reader[2].ToString()));
                                        letter.ReplaceText("%dya%", string.Format("{0}", reader[3].ToString()));
                                        letter.ReplaceText("%amua%", string.Format("{0}", reader[4].ToString()));
                                        letter.ReplaceText("%rea%", string.Format("{0}", reader[5].ToString()));
                                    }
                                }
                                //Incase anything is empty
                                letter.ReplaceText("%pouc%", "");
                                letter.ReplaceText("%dyc%", "");
                                letter.ReplaceText("%amuc%", "");
                                letter.ReplaceText("%rec%", "");
                                letter.ReplaceText("%poub%", "");
                                letter.ReplaceText("%dyb%", "");
                                letter.ReplaceText("%amub%", "");
                                letter.ReplaceText("%reb%", "");
                                letter.ReplaceText("%pouo%", "");
                                letter.ReplaceText("%dyo%", "");
                                letter.ReplaceText("%amuo%", "");
                                letter.ReplaceText("%reo%", "");
                                letter.ReplaceText("%poua%", "");
                                letter.ReplaceText("%dya%", "");
                                letter.ReplaceText("%amua%", "");
                                letter.ReplaceText("%rea%", "");

                                //
                                if (!reader.IsClosed) { reader.Close(); }
                                command = new MySqlCommand(string.Format("SELECT * FROM scale_smokeless WHERE client_no = {0}", clientid), connection);
                                reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    letter.ReplaceText("%normalsleep%", string.Format("1.  After a normal sleeping period, do you use smokeless within 30 minutes of waking? {0}", reader[1].ToString()));
                                    letter.ReplaceText("%sickuse%", string.Format("2.  Do you use smokeless tobacco when you are sick or have mouth sores?  {0}", reader[2].ToString()));
                                    letter.ReplaceText("%perweek%", string.Format("3.  How many times do you use per week?  {0}", reader[3].ToString()));
                                    letter.ReplaceText("%swallow%", string.Format("4.  Do you intentionally swallow your tobacco juices rather than spit? {0}", reader[4].ToString()));
                                    letter.ReplaceText("%alltime%", string.Format("5.  Do you keep a dip or chew in your mouth almost all the time? {0}", reader[5].ToString()));
                                    letter.ReplaceText("%twohour%", string.Format("6.  Do you experience strong cravings for a dip or chew? {0}", reader[6].ToString()));
                                    letter.ReplaceText("%avgmouth%", string.Format("7.  On average, how many minutes do you keep a fresh dip or chew in your mouth? {0}", reader[7].ToString()));
                                    letter.ReplaceText("%lengthdip%", string.Format("8.  What is the length of your dipping day  {0}", reader[8].ToString()));
                                    letter.ReplaceText("%avgdailysl%", string.Format("9.  On average, how may dips/chews do you take each day?  {0}", reader[9].ToString()));
                                    letter.ReplaceText("%smokelessscore%", string.Format("Your Score = {0}", reader[10].ToString()));
                                }

                                letter.ReplaceText("%normalsleep%", "1.  After a normal sleeping period, do you use smokeless within 30 minutes of waking?");
                                letter.ReplaceText("%sickuse%", "2.  Do you use smokeless tobacco when you are sick or have mouth sores?");
                                letter.ReplaceText("%perweek%", "3.  How many times do you use per week?");
                                letter.ReplaceText("%swallow%", "4.  Do you intentionally swallow your tobacco juices rather than spit?");
                                letter.ReplaceText("%alltime%", "5.  Do you keep a dip or chew in your mouth almost all the time?");
                                letter.ReplaceText("%twohour%", "6.  Do you experience strong cravings for a dip or chew?");
                                letter.ReplaceText("%avgmouth%", "7.  On average, how many minutes do you keep a fresh dip or chew in your mouth?");
                                letter.ReplaceText("%lengthdip%", "8.  What is the length of your dipping day?");
                                letter.ReplaceText("%avgdailysl%", "9.  On average, how may dips/chews do you take each day?");
                                letter.ReplaceText("%smokelessscore%", "Your Score = 0");

                                if (!reader.IsClosed) { reader.Close(); }
                                command = new MySqlCommand(string.Format("SELECT * FROM scale_smoker WHERE client_no = {0}", clientid), connection);
                                reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    letter.ReplaceText("%howsoon%", string.Format("1.  How soon after you wake in the morning do you smoke or first use tobacco? {0}", reader[1].ToString()));
                                    letter.ReplaceText("%finddiff%", string.Format("2.  Do you find it difficult not to use tobacco where tobacco is forbidden?  {0}", reader[2].ToString()));
                                    letter.ReplaceText("%hateto%", string.Format("3.  Which of the cigarette would you most hate to give up? {0}", reader[3].ToString()));
                                    letter.ReplaceText("%staybed%", string.Format("4.  Do you use tobacco when you are sick enough to have to stay in bed? {0}", reader[4].ToString()));
                                    letter.ReplaceText("%smokeaday%", string.Format("5.  Do you use tobacco more in the morning than the rest of the day? {0}", reader[5].ToString()));
                                    letter.ReplaceText("%restaday%", string.Format("6.  How many cigarettes do you smoke a day? {0}", reader[6].ToString()));
                                    letter.ReplaceText("%smokerscore%", string.Format("Your Score = {0}", reader[7].ToString()));
                                }

                                letter.ReplaceText("%howsoon%", "1.  How soon after you wake in the morning do you smoke or first use tobacco? ");
                                letter.ReplaceText("%finddiff%", "2.  Do you find it difficult not to use tobacco where tobacco is forbidden?");
                                letter.ReplaceText("%hateto%", "3.  Which of the cigarette would you most hate to give up?");
                                letter.ReplaceText("%staybed%", "4.  Do you use tobacco when you are sick enough to have to stay in bed?");
                                letter.ReplaceText("%smokeaday%", "5.  Do you use tobacco more in the morning than the rest of the day?");
                                letter.ReplaceText("%restaday%", "6.  How many cigarettes do you smoke a day?");
                                letter.ReplaceText("%smokerscore%", "Your Score = 0");

                                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                                var t = Task<string>.Factory.StartNew(() =>
                                {
                                    return string.Format("D:\\TCC\\intakeform_{0}.docx", clientid);
                                });

                                letter.SaveAs(t.Result);
                                Process.Start("winword.exe", t.Result);
                            }

                            phypr = false;
                            t_use = false;
                            seve = false;
                            scale_smoke.Clear();
                            scale_smokeless.Clear();
                            tobaccouse.Clear();
                            substancex.Clear();
                            phyproblem.Clear();

                            ClearAll();
                        }
                        else
                        {
                            //Roll Back
                            trans.Rollback();
                            XtraMessageBox.Show("Client Not Added Successfully!", "Not Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }
                    catch (Exception ex) { trans.Rollback(); XtraMessageBox.Show(ex.Message, "Error"); }
                }


            }



            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }


            finally { connection.Close(); if (!reader.IsClosed) { reader.Close(); } }


        }

        private void center_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand(string.Format("SELECT Center_Code FROM center_info WHERE Center_No = '{0}'", center_no.Text), connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    center_code.Text = reader[0].ToString();
                }

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); if (!reader.IsClosed) { reader.Close(); } }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand(string.Format("UPDATE intake_register SET center_no = '{0}',  center_code = '{1}',  reg_date = '{2}',  client_name = '{3}',  age = {4},  resident_area = '{5}',  gender = '{6}',  address = '{7}',  state_province = '{8}',  education = '{9}',  contact = '{10}',  occupation = '{11}',  marital_status = '{12}',  referred_by = '{13}',  income = {14},  quit_attempt = {15},  diagnosis_dtl = '{16}',  monthly_exp = {17},  alcohol_use = '{18}',  alcohol_pattern = '{19}',  avgdrinking = '{20}',  othersubstance = '{21}',  familihistory = '{22}',  familihistorydtl = '{23}',  weight_phy = '{24}',  height_phy = '{25}',  motivation = '{26}',  treatment = '{27}',  CO_analyst = '{28}',  CO_level = '{29}',  therapist = '{30}', email = '{31}' WHERE client_no = {32}", center_no.Text, center_code.Text, string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(reg_date.Text)), name_box.Text, age_bar.Text, resident.Text, gender.Text, address_box.Text, state_province.Text, edu_qualification.Text, phone_box.Text, occupation.Text, marital_status.Text, referred_by.Text, income.EditValue, quit_attempt.EditValue, diagnosis.Text, monthly_expense.EditValue, alcoholuse.Text, alcoholpattern.Text, avgalcoholdrinking.Text, othersubstanceuse.Text, familihistory.Text, history_remark.Text, weight_phy.Text, height_phy.Text, motivation.Text, treatment.Text, CO_analyst.Text, CO_level.Text, therapist.Text, email_box.Text, client_no.Text), connection);
                int i = command.ExecuteNonQuery();

                if(i == 1)
                {
                    XtraMessageBox.Show("Successfully Updated in the record!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    IDS();
                    //LoadID();
                }
                else { XtraMessageBox.Show("Record coult not be updated! Record might not be in the Register!", "Not Done", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally { connection.Close(); }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            using (MySqlTransaction trans = connection.BeginTransaction())
            {
                try
                {
                    if (XtraMessageBox.Show("Are you sure to delete the Current Record from the Register?\n\nOnce Deleted, you won't be able to recover again!", "Confirm it", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string cid = client_no.Text;
                        
                        command = new MySqlCommand(string.Format("DELETE FROM intake_register WHERE client_no = '{0}'", client_no.Text), connection, trans);
                        int i = command.ExecuteNonQuery();
                        if (i == 1)
                        {                         

                            //Delete Other Record as well!
                            if (XtraMessageBox.Show("Do you want to delete all the related information with the same Client ID?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //Delete ALL
                                command = new MySqlCommand(string.Format("DELETE FROM detail_tobacco_use WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(string.Format("DELETE FROM follow_up WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(string.Format("DELETE FROM intake_substance WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(string.Format("DELETE FROM phy_problem WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(string.Format("DELETE FROM scale_smokeless WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand(string.Format("DELETE FROM scale_smoker WHERE client_no = {0}", cid), connection, trans);
                                command.ExecuteNonQuery();
                            }

                            trans.Commit();

                            XtraMessageBox.Show("Successfully Deleted from the record!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAll();
                            IDS();
                            LoadID();
                        }
                        else { XtraMessageBox.Show("Record could not be deleted! Record might not be in the Register!", "Not Done", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }

                }
                catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); trans.Rollback(); }
                finally { connection.Close(); }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try { LoadID(); ClearAll(); reg_date.Focus(); }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally { }
        }

        private void client_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void client_no_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void client_no_Validating(object sender, CancelEventArgs e)
        {
            LoadDetail();
        }

        private void ClearAll()
        {
            try
            {
                //reg_date.EditValue = DateTime.Now.ToShortDateString();
                name_box.ResetText();
                age_bar.ResetText();
                address_box.ResetText();
                gender.SelectedIndex = 0;
                resident.SelectedIndex = 1;
                //state_province.ResetText();
                edu_qualification.SelectedIndex = -1;
                phone_box.ResetText();
                occupation.SelectedIndex = -1;
                marital_status.SelectedIndex = -1;
                referred_by.ResetText();
                income.ResetText();
                quit_attempt.ResetText();
                diagnosis.SelectedIndex = -1;
                monthly_expense.ResetText();
                alcoholuse.SelectedIndex = 1;
                alcoholpattern.SelectedIndex = -1;
                avgalcoholdrinking.ResetText();
                othersubstanceuse.SelectedIndex = 1;
                familihistory.SelectedIndex = 1;
                history_remark.SelectedIndex = -1;
                weight_phy.ResetText(); 
                height_phy.ResetText();
                motivation.ResetText();
                treatment.ResetText();
                CO_analyst.SelectedIndex = 1;
                CO_level.SelectedIndex = -1;
                therapist.ResetText(); 
                email_box.ResetText();

                //reg_date.Focus();
                name_box.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }

        private void LoadDetail()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                if (!reader.IsClosed) { reader.Close(); }
                ClearAll();

                command = new MySqlCommand(string.Format("SELECT * from intake_register WHERE client_no = '{0}'", client_no.Text), connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    center_no.Text = reader[1].ToString();
                    center_code.Text = reader[2].ToString();
                    reg_date.Text = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(reader[3].ToString()).ToShortDateString());
                    name_box.Text = reader[4].ToString();
                    age_bar.Text = reader[5].ToString();
                    resident.Text = reader[6].ToString();
                    gender.Text = reader[7].ToString();
                    address_box.Text = reader[8].ToString();
                    state_province.Text = reader[9].ToString();
                    edu_qualification.Text = reader[10].ToString();
                    phone_box.Text = reader[11].ToString();
                    occupation.Text = reader[12].ToString();
                    marital_status.Text = reader[13].ToString();
                    referred_by.Text = reader[14].ToString();
                    income.Text = reader[15].ToString();
                    quit_attempt.Text = reader[16].ToString();
                    diagnosis.Text = reader[17].ToString();
                    monthly_expense.Text = reader[18].ToString();
                    alcoholuse.Text = reader[19].ToString();
                    alcoholpattern.Text = reader[20].ToString();
                    avgalcoholdrinking.Text = reader[21].ToString();
                    othersubstanceuse.Text = reader[22].ToString();
                    familihistory.Text = reader[23].ToString();
                    history_remark.Text = reader[24].ToString();
                    weight_phy.Text = reader[25].ToString();
                    height_phy.Text = reader[26].ToString();
                    motivation.Text = reader[27].ToString();
                    treatment.Text = reader[28].ToString();
                    CO_analyst.Text = reader[29].ToString();
                    CO_level.Text = reader[30].ToString();
                    therapist.Text = reader[31].ToString();
                    email_box.Text = reader[32].ToString();
                }
                
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "error"); }
            finally
            {
                connection.Close(); 
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(client_no.Text != "") { LoadDetail(); }            
        }

        private void occupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(occupation.SelectedIndex == 2)
                {
                    marital_status.SelectedIndex = 1;
                }
                else if (occupation.SelectedIndex == 8)
                {
                    marital_status.SelectedIndex = 0;
                }
            }
            catch(Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
        }
    }
}
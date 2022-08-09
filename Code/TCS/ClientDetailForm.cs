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
using DevExpress.DataAccess.Sql;
using System.IO;
using System.Diagnostics;
using Novacode;

namespace TCS
{
    public partial class ClientDetailForm : DevExpress.XtraEditors.XtraForm
    {

        public int client_no = 0;
        public ClientDetailForm()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }
                

                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    //Client Code                    
                    command = new MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register", connection);
                    reader = command.ExecuteReader();

                }
                else if (comboBoxEdit1.SelectedIndex == 1)
                {
                    //Client name
                    command = new MySqlCommand("SELECT DISTINCT(client_name) FROM intake_register", connection);
                    reader = command.ExecuteReader();
                }
                else if (comboBoxEdit1.SelectedIndex == 2)
                {
                    //Contact number
                    command = new MySqlCommand("SELECT DISTINCT(contact) FROM intake_register", connection);
                    reader = command.ExecuteReader();
                }

                else { connection.Close(); return; }



                ComboBoxItemCollection coll = comboBoxEdit2.Properties.Items;

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
            {  connection.Close();  }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }

                if (!reader.IsClosed) { reader.Close(); }

                if (comboBoxEdit1.SelectedIndex == -1) { return; }
                if (comboBoxEdit2.Text == "") { DevExpress.XtraEditors.XtraMessageBox.Show("You have to enter a criteria Field Text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    //Client No
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register WHERE client_no={0}", Convert.ToInt32(comboBoxEdit2.Text)), connection);
                    reader = command.ExecuteReader();
                }
                else if (comboBoxEdit1.SelectedIndex == 1)
                {
                    //Client Name
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register WHERE client_name LIKE '%{0}%'", comboBoxEdit2.Text), connection);
                    reader = command.ExecuteReader();
                }
                else if (comboBoxEdit1.SelectedIndex == 2)
                {
                    //Client Contact
                    //Client Name
                    command = new MySqlCommand(string.Format("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register WHERE contact LIKE '%{0}%'", comboBoxEdit2.Text), connection);
                    reader = command.ExecuteReader();
                }

                else { return; }


                listView1.Clear();
                listView1.Columns.Add("Client No", 60);
                listView1.Columns.Add("Client Name", 120);
                listView1.Columns.Add("Contact No", 80);
                listView1.Columns.Add("Address", 80);
                listView1.Columns.Add("Diagnosis", 90);

                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(reader[2].ToString());
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    listView1.Items.Add(lvItem);
                }

                listView1.Sorting = SortOrder.Ascending;
                listView1.Sort();

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally {  connection.Close();  }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count < 1)
                {
                    XtraMessageBox.Show("You must select the details to be Printed!", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Command for Printing will Go on here
                ListViewItem item = listView1.SelectedItems[0];
                client_no = Convert.ToInt32(item.SubItems[0].Text);

                ClientDetailPrint(client_no);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ClientDetailPrint(int clientid)
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }
                if (!reader.IsClosed) { reader.Close(); }

                command = new MySqlCommand("SELECT * FROM intake_register WHERE client_no = " + clientid, connection);
                reader = command.ExecuteReader();
                
                DocX letter = DocX.Load(@"intake.docx");

                if(reader.Read())
                {
                    // Perform the replace:
                    letter.ReplaceText("%regdate%", string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(reader[3])));
                    letter.ReplaceText("%cn%", reader[1].ToString());
                    letter.ReplaceText("%center%", reader[2].ToString());
                    letter.ReplaceText("%clientno%", clientid.ToString());
                    letter.ReplaceText("%clientname%", reader[4].ToString());
                    letter.ReplaceText("%age%", reader[5].ToString());
                    letter.ReplaceText("%gender%", reader[7].ToString());
                    letter.ReplaceText("%state%", reader[9].ToString());
                    letter.ReplaceText("%address%", reader[8].ToString());
                    letter.ReplaceText("%resident%", reader[6].ToString());
                    letter.ReplaceText("%contact%", reader[11].ToString());
                    letter.ReplaceText("%education%", reader[10].ToString());
                    letter.ReplaceText("%marital%", reader[13].ToString());
                    letter.ReplaceText("%occupation%", reader[12].ToString());
                    letter.ReplaceText("%income%", reader[15].ToString());
                    letter.ReplaceText("%referredby%", reader[14].ToString());
                    letter.ReplaceText("%expense%", reader[18].ToString());
                    letter.ReplaceText("%treatment%", reader[28].ToString());
                    letter.ReplaceText("%weight%", reader[25].ToString());
                    letter.ReplaceText("%height%", reader[26].ToString());
                    letter.ReplaceText("%motive%", reader[27].ToString());
                    letter.ReplaceText("%diagn%", reader[17].ToString());
                    letter.ReplaceText("%coan%", reader[29].ToString());
                    letter.ReplaceText("%cole%", reader[30].ToString());
                    letter.ReplaceText("%thera%", reader[31].ToString());
                    letter.ReplaceText("%prevat%", reader[16].ToString());
                    letter.ReplaceText("%alcoholuse%", reader[19].ToString());
                    letter.ReplaceText("%upat%", reader[20].ToString());
                    letter.ReplaceText("%patdr%", reader[21].ToString());
                    letter.ReplaceText("%uset%", reader[23].ToString());
                    letter.ReplaceText("%usdet%", reader[24].ToString());
                    letter.ReplaceText("%othrsub%", reader[22].ToString());
                    letter.ReplaceText("%email%", reader[32].ToString());
                }

                if (!reader.IsClosed) { reader.Close(); }

                StringBuilder stobacco_type = new StringBuilder(string.Format("{0}", ""));
                StringBuilder stobacco_ageset = new StringBuilder(string.Format("{0}", ""));
                StringBuilder stobacco_avgper = new StringBuilder(string.Format("{0}", ""));
                StringBuilder stobacco_noyear = new StringBuilder(string.Format("{0}", ""));
                StringBuilder stobacco_sachet = new StringBuilder(string.Format("{0}", ""));
                StringBuilder stobacco_avgnum = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_type = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_ageset = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_avgper = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_noyear = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_sachet = new StringBuilder(string.Format("{0}", ""));
                StringBuilder sltobacco_avgnum = new StringBuilder(string.Format("{0}", ""));

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

                string filename = "D:\\TCC\\intakeform_" + clientid.ToString() + ".docx";

                letter.SaveAs(filename);
                Process.Start("winword.exe", filename);
            
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error");
            }
            finally {
               
                connection.Close();
            }
        }

        public void ReportDetail()
        {
            try
            {
                //Now work with Databind
                if (connection.State == ConnectionState.Open) { connection.Close(); }


                DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters connectionParameters = new DevExpress.DataAccess.ConnectionParameters.MySqlConnectionParameters(Properties.Settings.Default.dbServer, Properties.Settings.Default.dbName, Properties.Settings.Default.dbUser, Properties.Settings.Default.dbPassword);
                SqlDataSource ds = new SqlDataSource(connectionParameters);
                

                // Create an SQL query to access the Products table.
                CustomSqlQuery query = new CustomSqlQuery();
                query.Name = "customQuery1";
                query.Sql = string.Format("SELECT * FROM intake_register WHERE client_no = {0}", client_no);


                ds.Queries.Add(query);


                //ClientDetail cds = new ClientDetail();
                //cds.DataSource = ds;
                //cds.DataMember = "customQuery1";


                //Set the Data Record
                
               //cds.center_no.DataBindings.Add("Text", null, "customQuery1.center_no");
               //cds.client_code.DataBindings.Add("Text", null, "customQuery1.client_no");
               //cds.reg_date.DataBindings.Add("Text", null, "customQuery1.reg_date", "{0:dd/MM/yyyy}");
               //cds.client_gender.DataBindings.Add("Text", null, "customQuery1.gender");
               //cds.center_no.DataBindings.Add("Text", null, "customQuery1.center_no");
               //cds.client_name.DataBindings.Add("Text", null, "customQuery1.client_name");
               //cds.client_address.DataBindings.Add("Text", null, "customQuery1.address");
               //cds.client_age.DataBindings.Add("Text", null, "customQuery1.age");
               //cds.client_area.DataBindings.Add("Text", null, "customQuery1.area_of_res");
               //cds.client_province.DataBindings.Add("Text", null, "customQuery1.state_province");
               //cds.client_contact.DataBindings.Add("Text", null, "customQuery1.contact");
               //cds.client_edu.DataBindings.Add("Text", null, "customQuery1.education_q");
               //cds.client_marital.DataBindings.Add("Text", null, "customQuery1.marital_status");
               //cds.client_occupation.DataBindings.Add("Text", null, "customQuery1.occupation");
               //cds.client_referrer.DataBindings.Add("Text", null, "customQuery1.referred_by");
               //cds.client_expense.DataBindings.Add("Text", null, "customQuery1.monthly_expense");
               //cds.client_attempt.DataBindings.Add("Text", null, "customQuery1.no_of_pre_attempt_quit");
               //cds.clinet_alcoholuse.DataBindings.Add("Text", null, "customQuery1.alcohol_use");
               //cds.client_avgdrinking.DataBindings.Add("Text", null, "customQuery1.avg_drinking_daily");
               //cds.client_alcoholpattern.DataBindings.Add("Text", null, "customQuery1.alcohol_use_pattern");
               //cds.client_substance.DataBindings.Add("Text", null, "customQuery1.other_substance_use");
               //cds.client_age.DataBindings.Add("Text", null, "customQuery1.family_his");
               //cds.client_family.DataBindings.Add("Text", null, "customQuery1.family_history_tobacco_use");
               //cds.client_motivation.DataBindings.Add("Text", null, "customQuery1.motivation_stage_assessment");
               //cds.client_diagnosis.DataBindings.Add("Text", null, "customQuery1.diagnosis");
               //cds.client_age.DataBindings.Add("Text", null, "customQuery1.CO_breath_analysis");
               //cds.client_co.DataBindings.Add("Text", null, "customQuery1.CO_level");
               //cds.client_treatment.DataBindings.Add("Text", null, "customQuery1.Treatment");
               //cds.client_therapist.DataBindings.Add("Text", null, "customQuery1.therapist");
               //cds.client_weight.DataBindings.Add("Text", null, "customQuery1.weight");
               //cds.client_height.DataBindings.Add("Text", null, "customQuery1.height");
               //
               //
               //if (connection.State == ConnectionState.Closed) { connection.Open(); }
               ////Work Manually
               //if (!reader.IsClosed) { reader.Close(); }
               //command = new MySqlCommand(string.Format("SELECT * FROM scale_smokeless WHERE client_no = {0}", client_no), connection);
               //reader = command.ExecuteReader();
               //
               //if (reader.Read())
               //{
               //    cds.normal_sleep.Text = string.Format("1.  After a normal sleeping period, do you use smokeless within 30 minutes of waking? {0}", reader[1].ToString());
               //    cds.sick_use.Text = string.Format("2.  Do you use smokeless tobacco when you are sick or have mouth sores?  {0}", reader[2].ToString());
               //    cds.per_week.Text = string.Format("3.  How many times do you use per week?  {0}", reader[3].ToString());
               //    cds.swallow.Text = string.Format("4.  Do you intentionally swallow your tobacco juices rather than spit? {0}", reader[4].ToString());
               //    cds.all_time.Text = string.Format("5.  Do you keep a dip or chew in your mouth almost all the time? {0}", reader[5].ToString());
               //    cds.two_hour.Text = string.Format("6.  Do you experience strong cravings for a dip or chew? {0}", reader[6].ToString());
               //    cds.avg_month.Text = string.Format("7.  On average, how many minutes do you keep a fresh dip or chew in your mouth? {0}", reader[7].ToString());
               //    cds.length_dip.Text = string.Format("8.  What is the length of your dipping day  {0}", reader[8].ToString());
               //    cds.avg_daily_sl.Text = string.Format("9.  On average, how may dips/chews do you take each day?  {0}", reader[9].ToString());
               //    cds.smokeless_score.Text = string.Format("Your Score = {0}", reader[10].ToString());
               //}
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //
               //command = new MySqlCommand(string.Format("SELECT * FROM scale_smoker WHERE client_no = {0}", client_no), connection);
               //reader = command.ExecuteReader();
               //if (reader.Read())
               //{
               //    cds.how_soon.Text = string.Format("1.  How soon after you wake in the morning do you smoke or first use tobacco? {0}", reader[1].ToString());
               //    cds.find_diff.Text = string.Format("2.  Do you find it difficult not to use tobacco where tobacco is forbidden?  {0}", reader[2].ToString());
               //    cds.hate_to.Text = string.Format("3.  Which of the cigarette would you most hate to give up? {0}", reader[3].ToString());
               //    cds.stay_bed.Text = string.Format("4.  Do you use tobacco when you are sick enough to have to stay in bed? {0}", reader[4].ToString());
               //    cds.smoke_a_day.Text = string.Format("5.  Do you use tobacco more in the morning than the rest of the day? {0}", reader[5].ToString());
               //    cds.rest_a_day.Text = string.Format("6.  How many cigarettes do you smoke a day? {0}", reader[6].ToString());
               //    cds.smoker_score.Text = string.Format("Your Score = {0}", reader[7].ToString());
               //}
               //
               //string _cough = "";
               //string _bronchial = "";
               //string _gastro = "";
               //string _cardiac = "";
               //string _oral = "";
               //string _psy = "";
               //string _other = "";
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //
               //command = new MySqlCommand(string.Format("SELECT * FROM phy_problem WHERE client_no = {0}", client_no), connection);
               //reader = command.ExecuteReader();
               //
               //
               //
               //if (reader.Read())
               //{
               //    if (reader[1].ToString() == "True")
               //    { _cough += " Cough Sputum |"; }
               //
               //    if (reader[2].ToString() == "True")
               //    { _cough += " Dry Cough |"; }
               //
               //    if (reader[3].ToString() == "True")
               //    { _cough += " Sputum Blood"; }
               //
               //    if (reader[4].ToString() == "True")
               //    { _bronchial += " Asthma |"; }
               //
               //    if (reader[5].ToString() == "True")
               //    { _bronchial += " Bronchitis |"; }
               //
               //    if (reader[6].ToString() == "True")
               //    { _bronchial += " Breathless"; }
               //
               //    if (reader[7].ToString() == "True")
               //    { _gastro += " Blood in Stool |"; }
               //
               //    if (reader[8].ToString() == "True")
               //    { _gastro += " Blood in Vomit |"; }
               //
               //    if (reader[9].ToString() == "True")
               //    { _gastro += " Constipation |"; }
               //
               //    if (reader[10].ToString() == "True")
               //    { _gastro += " Dyspepsia |"; }
               //
               //    if (reader[11].ToString() == "True")
               //    { _gastro += " Diarrhoea |"; }
               //
               //    if (reader[12].ToString() == "True")
               //    { _gastro += " Vomiting"; }
               //
               //    if (reader[13].ToString() == "True")
               //    { _cardiac += " Chest Pain |"; }
               //
               //    if (reader[14].ToString() == "True")
               //    { _cardiac += " Hypertension |"; }
               //
               //    if (reader[15].ToString() == "True")
               //    { _cardiac += " Myocardial Infarction"; }
               //
               //    if (reader[16].ToString() == "True")
               //    { _oral += " Erythroplakia |"; }
               //
               //    if (reader[17].ToString() == "True")
               //    { _oral += " Leukoplakia |"; }
               //
               //    if (reader[18].ToString() == "True")
               //    { _oral += " Sub Mucous Fibrosis |"; }
               //
               //    if (reader[19].ToString() == "True")
               //    { _oral += " Mal-Order |"; }
               //
               //    if (reader[20].ToString() == "True")
               //    { _oral += " Ulceration of Oral |"; }
               //
               //    if (reader[21].ToString() == "True")
               //    { _oral += " Dental Caries |"; }
               //
               //    if (reader[22].ToString() == "True")
               //    { _oral += " Staining of Teeth |"; }
               //
               //    if (reader[23].ToString() == "True")
               //    { _oral += " Pain in Gums"; }
               //
               //    if (reader[24].ToString() == "True")
               //    { _psy += " Anxiety |"; }
               //
               //    if (reader[25].ToString() == "True")
               //    { _psy += " Depression |"; }
               //
               //    if (reader[26].ToString() == "True")
               //    { _psy += " Schizophrenia |"; }
               //
               //    if (reader[27].ToString() == "True")
               //    { _psy += " Others"; }
               //
               //    if (reader[28].ToString() == "True")
               //    { _other += " Cancer |"; }
               //
               //    if (reader[29].ToString() == "True")
               //    { _other += " Diabetes |"; }
               //
               //    if (reader[30].ToString() == "True")
               //    { _other += " Sexual Dysfunction |"; }
               //
               //    if (reader[31].ToString() == "True")
               //    { _other += " Stroke |"; }
               //
               //    if (reader[32].ToString() == "True")
               //    { _other += " Seizure Disorder |"; }
               //
               //    if (reader[33].ToString() == "True")
               //    { _other += " TB |"; }
               //
               //    if (reader[34].ToString() == "True")
               //    { _other += " Weight Gain |"; }
               //
               //    if (reader[35].ToString() == "True")
               //    { _other += " BWeight Loss |"; }
               //
               //    cds.phy_cough.Text = string.Format("{0}", _cough);
               //    cds.phy_bronchial.Text = string.Format("{0}", _bronchial);
               //    cds.phy_gastro.Text = string.Format("{0}", _gastro);
               //    cds.phy_cardiac.Text = string.Format("{0}", _cardiac);
               //    cds.phy_oral.Text = string.Format("{0}", _oral);
               //    cds.phy_psy.Text = string.Format("{0}", _psy);
               //    cds.phy_other.Text = string.Format("{0}", _other);
               //
               //}
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //
               //command = new MySqlCommand(string.Format("SELECT * FROM intake_substance WHERE client_no = {0}", client_no), connection);
               //reader = command.ExecuteReader();
               //
               //if (reader.Read())
               //{
               //    if (reader[2].ToString().ToLower() == "cannabis")
               //    {
               //        //Cannabis
               //        cds.can_pattern.Text = string.Format("{0}", reader[3].ToString());
               //        cds.can_depend.Text = string.Format("{0}", reader[4].ToString());
               //        cds.can_avg.Text = string.Format("{0}", reader[5].ToString());
               //        cds.can_remark.Text = string.Format("{0}", reader[6].ToString());
               //    }
               //
               //    if (reader[2].ToString().ToLower() == "benzodiazephines")
               //    {
               //        //Benzo
               //        cds.ben_pattern.Text = string.Format("{0}", reader[3].ToString());
               //        cds.ben_depend.Text = string.Format("{0}", reader[4].ToString());
               //        cds.ben_avg.Text = string.Format("{0}", reader[5].ToString());
               //        cds.ben_remark.Text = string.Format("{0}", reader[6].ToString());
               //    }
               //
               //    if (reader[2].ToString().ToLower() == "opioids")
               //    {
               //        //Opi
               //        cds.opi_pattern.Text = string.Format("{0}", reader[3].ToString());
               //        cds.opi_depend.Text = string.Format("{0}", reader[4].ToString());
               //        cds.opi_avg.Text = string.Format("{0}", reader[5].ToString());
               //        cds.opi_remark.Text = string.Format("{0}", reader[6].ToString());
               //    }
               //
               //    else
               //    {
               //        //other
               //        cds.other_pattern.Text = string.Format("{0}", reader[3].ToString());
               //        cds.other_depend.Text = string.Format("{0}", reader[4].ToString());
               //        cds.other_avg.Text = string.Format("{0}", reader[5].ToString());
               //        cds.other_remark.Text = string.Format("{0}", reader[6].ToString());
               //    }
               //}
               //
               //StringBuilder stobacco_type = new StringBuilder(string.Format("", ""));
               //StringBuilder stobacco_ageset = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder stobacco_avgper = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder stobacco_noyear = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder stobacco_sachet = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder stobacco_avgnum = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder sltobacco_type = new StringBuilder(string.Format("", ""));
               //StringBuilder sltobacco_ageset = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder sltobacco_avgper = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder sltobacco_noyear = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder sltobacco_sachet = new StringBuilder(string.Format("{0}", "\n"));
               //StringBuilder sltobacco_avgnum = new StringBuilder(string.Format("{0}", "\n"));
               //
               //
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //
               //command = new MySqlCommand(string.Format("SELECT * FROM detail_tobacco_use WHERE client_no = {0}", client_no), connection);
               //reader = command.ExecuteReader();
               //while (reader.Read())
               //{
               //    if (reader[2].ToString() == "Smoking")
               //    {
               //        stobacco_type.AppendLine(string.Format("{0}{1}", reader[3].ToString(), "\n"));
               //        stobacco_ageset.AppendLine(string.Format("{0}{1}", reader[4].ToString(), "\n"));
               //        stobacco_avgper.AppendLine(string.Format("{0}{1}", reader[5].ToString(), "\n"));
               //        stobacco_noyear.AppendLine(string.Format("{0}{1}", reader[6].ToString(), "\n"));
               //        stobacco_sachet.AppendLine(string.Format("{0}{1}", reader[7].ToString(), "\n"));
               //        stobacco_avgnum.AppendLine(string.Format("{0}{1}", reader[8].ToString(), "\n"));
               //    }
               //    else
               //    {
               //        sltobacco_type.AppendLine(string.Format("{0}{1}", reader[3].ToString(), "\n"));
               //        sltobacco_ageset.AppendLine(string.Format("{0}{1}", reader[4].ToString(), "\n"));
               //        sltobacco_avgper.AppendLine(string.Format("{0}{1}", reader[5].ToString(), "\n"));
               //        sltobacco_noyear.AppendLine(string.Format("{0}{1}", reader[6].ToString(), "\n"));
               //        sltobacco_sachet.AppendLine(string.Format("{0}{1}", reader[7].ToString(), "\n"));
               //        sltobacco_avgnum.AppendLine(string.Format("{0}{1}", reader[8].ToString(), "\n"));
               //    }
               //}
               //
               //cds.smoking_type.Text = stobacco_type.ToString();
               //cds.smoke_ageset.Text = stobacco_ageset.ToString();
               //cds.smoking_avgper.Text = stobacco_avgper.ToString();
               //cds.smoke_noyear.Text = stobacco_noyear.ToString();
               //cds.smoke_sachet.Text = stobacco_sachet.ToString();
               //cds.smoke_avgnum.Text = stobacco_avgnum.ToString();
               //cds.smokeless_type.Text = sltobacco_type.ToString();
               //cds.smokeless_ageset.Text = sltobacco_ageset.ToString();
               //cds.smokeless_avgper.Text = sltobacco_avgper.ToString();
               //cds.smokeless_noyear.Text = sltobacco_noyear.ToString();
               //cds.smokeless_sachet.Text = sltobacco_sachet.ToString();
               //cds.smokeless_avgnum.Text = sltobacco_avgnum.ToString();
               //
               ////Follow up
               //StringBuilder fuvisit = new StringBuilder();
               //StringBuilder visitdate = new StringBuilder();
               //StringBuilder status = new StringBuilder();
               //StringBuilder contine = new StringBuilder();
               //StringBuilder CO_test = new StringBuilder();
               //StringBuilder CO_level = new StringBuilder();
               //StringBuilder treatment = new StringBuilder();
               //StringBuilder medication = new StringBuilder();
               //StringBuilder source = new StringBuilder();
               //StringBuilder remark = new StringBuilder();
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //
               //command = new MySqlCommand(string.Format("SELECT * FROM follow_up WHERE client_no={0}", client_no), connection);
               //reader = command.ExecuteReader();
               //while (reader.Read())
               //{
               //    fuvisit.AppendLine(string.Format("{0}{1}", reader[2].ToString(), "\n"));
               //    visitdate.AppendLine(string.Format("{0:dd/MM/yyyy}{1}", reader[3], "\n"));
               //    status.AppendLine(string.Format("{0}{1}", reader[4].ToString(), "\n"));
               //    contine.AppendLine(string.Format("{0}{1}", reader[5].ToString(), "\n"));
               //    CO_test.AppendLine(string.Format("{0}{1}", reader[6].ToString(), "\n"));
               //    CO_level.AppendLine(string.Format("{0}{1}", reader[7].ToString(), "\n"));
               //    treatment.AppendLine(string.Format("{0}{1}", reader[8].ToString(), "\n"));
               //    medication.AppendLine(string.Format("{0}{1}", reader[9].ToString(), "\n"));
               //    source.AppendLine(string.Format("{0}{1}", reader[10].ToString(), "\n"));
               //    remark.AppendLine(string.Format("{0}{1}", reader[11].ToString(), "\n"));
               //}
               //
               //cds.fu_visit.Text = fuvisit.ToString();
               //cds.visit_date.Text = visitdate.ToString();
               //cds.use_status.Text = status.ToString();
               //cds.continine_test.Text = contine.ToString();
               //cds.CO_breath.Text = CO_test.ToString();
               //cds.CO_Level.Text = CO_level.ToString();
               //cds.Treatment.Text = treatment.ToString();
               //cds.Medication.Text = medication.ToString();
               //cds.Remark_cell.Text = remark.ToString();
               //
               //
               //if (!reader.IsClosed) { reader.Close(); }
               //if (connection.State == ConnectionState.Open) { connection.Close(); }
                //Show the Report Form
                //ClientReport cf = new ClientReport();
                //cf.documentViewer1.DocumentSource = cds;
                //cf.ShowDialog();

                // Show the report's print preview.


            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally {  connection.Close();  }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    printButton.Visible = true;
                }

                else {
                    printButton.Visible = false;
                }               
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void printer_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count < 1)
                {
                    XtraMessageBox.Show("You must select the details to be Printed!", "Wait...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Command for Printing will Go on here
                ListViewItem item = listView1.SelectedItems[0];
                client_no = Convert.ToInt32(item.SubItems[0].Text);

                ClientDetailPrint(client_no);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void listView1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    printButton.Visible = true;
                }

                else
                {
                    printButton.Visible = false;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
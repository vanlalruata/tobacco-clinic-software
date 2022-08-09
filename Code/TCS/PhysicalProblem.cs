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
    public partial class PhysicalProblem : DevExpress.XtraEditors.XtraForm
    {
        private bool c_s = false, d_c = false, s_b = false, asth = false, bronchi = false, b_l = false, b_s = false, b_v = false, consti = false, dys = false, dia = false, vomit = false, c_p = false, h_t = false, myocardial = false, erythroplakia = false, leuko = false, sub_mocous = false, mal = false, ulcertation = false, dental_caries = false, staining_teeth = false, p_g = false, anxie = false, depress = false, schizo = false, oth = false, can = false, diabe = false, sexual = false, strk = false, sei = false, tuberculosis = false, w_g = false, w_l = false;

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                client_name.Text = "";

                if (client_no.Text == "") { return; }

                if(connection.State == ConnectionState.Closed) { connection.Open(); }

                

                command = new MySql.Data.MySqlClient.MySqlCommand("SELECT client_name FROM intake_register WHERE client_no = " + client_no.Text, connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    client_name.Text = "Name : " + reader[0].ToString();
                }

                reader.Close();

                command = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM phy_problem WHERE client_no = " + client_no.Text, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    if (reader[1].ToString() == "True") { cough_sputum.CheckState = CheckState.Checked; }
                    else { cough_sputum.CheckState = CheckState.Unchecked; }

                    if (reader[2].ToString() == "True") { dry_cough.CheckState = CheckState.Checked; }
                    else { dry_cough.CheckState = CheckState.Unchecked; }

                    if (reader[3].ToString() == "True") { sputum_blood.CheckState = CheckState.Checked; }
                    else  { sputum_blood.CheckState = CheckState.Unchecked; }                    

                    if (reader[4].ToString() == "True") { asthma.CheckState = CheckState.Checked; }
                    else { asthma.CheckState = CheckState.Unchecked; }

                    if (reader[5].ToString() == "True") { bronchitis.CheckState = CheckState.Checked; }
                    else { bronchitis.CheckState = CheckState.Unchecked; }

                    if (reader[6].ToString() == "True") { breathless.CheckState = CheckState.Checked; }
                    else { breathless.CheckState = CheckState.Unchecked; }

                    if (reader[7].ToString() == "True") { blood_stool.CheckState = CheckState.Checked; }
                    else { blood_stool.CheckState = CheckState.Unchecked; }

                    if (reader[8].ToString() == "True") { blood_vomit.CheckState = CheckState.Checked; }
                    else { blood_vomit.CheckState = CheckState.Unchecked; }

                    if (reader[9].ToString() == "True") { constipation.CheckState = CheckState.Checked; }
                    else { constipation.CheckState = CheckState.Unchecked; }

                    if (reader[10].ToString() == "True") { dyspepsia.CheckState = CheckState.Checked; }
                    else { dyspepsia.CheckState = CheckState.Unchecked; }

                    if (reader[11].ToString() == "True") { diarrhoea.CheckState = CheckState.Checked; }
                    else { diarrhoea.CheckState = CheckState.Unchecked; }

                    if (reader[12].ToString() == "True") { vomiting.CheckState = CheckState.Checked; }
                    else { vomiting.CheckState = CheckState.Unchecked; }

                    if (reader[13].ToString() == "True") { chest_pain.CheckState = CheckState.Checked; }
                    else { chest_pain.CheckState = CheckState.Unchecked; }

                    if (reader[14].ToString() == "True") { hypertension.CheckState = CheckState.Checked; }
                    else { hypertension.CheckState = CheckState.Unchecked; }

                    if (reader[15].ToString() == "True") { infraction.CheckState = CheckState.Checked; }
                    else { infraction.CheckState = CheckState.Unchecked; }

                    if (reader[16].ToString() == "True") { Erythroplakia.CheckState = CheckState.Checked; }
                    else { Erythroplakia.CheckState = CheckState.Unchecked; }

                    if (reader[17].ToString() == "True") { leukoplakia.CheckState = CheckState.Checked; }
                    else { leukoplakia.CheckState = CheckState.Unchecked; }

                    if (reader[18].ToString() == "True") { mucous.CheckState = CheckState.Checked; }
                    else { mucous.CheckState = CheckState.Unchecked; }

                    if (reader[19].ToString() == "True") { mal_order.CheckState = CheckState.Checked; }
                    else { mal_order.CheckState = CheckState.Unchecked; }

                    if (reader[20].ToString() == "True") { ulcer.CheckState = CheckState.Checked; }
                    else { ulcer.CheckState = CheckState.Unchecked; }

                    if (reader[21].ToString() == "True") { dental.CheckState = CheckState.Checked; }
                    else { dental.CheckState = CheckState.Unchecked; }

                    if (reader[22].ToString() == "True") { stain_teeth.CheckState = CheckState.Checked; }
                    else { stain_teeth.CheckState = CheckState.Unchecked; }

                    if (reader[23].ToString() == "True") { pain_gum.CheckState = CheckState.Checked; }
                    else { pain_gum.CheckState = CheckState.Unchecked; }

                    if (reader[24].ToString() == "True") { anxiety.CheckState = CheckState.Checked; }
                    else { anxiety.CheckState = CheckState.Unchecked; }

                    if (reader[25].ToString() == "True") { depression.CheckState = CheckState.Checked; }
                    else { depression.CheckState = CheckState.Unchecked; }

                    if (reader[26].ToString() == "True") { schizophrenia.CheckState = CheckState.Checked; }
                    else { schizophrenia.CheckState = CheckState.Unchecked; }

                    if (reader[27].ToString() == "True") { other.CheckState = CheckState.Checked; }
                    else { other.CheckState = CheckState.Unchecked; }

                    if (reader[28].ToString() == "True") { cancer.CheckState = CheckState.Checked; }
                    else { cancer.CheckState = CheckState.Unchecked; }

                    if (reader[29].ToString() == "True") { diabetes.CheckState = CheckState.Checked; }
                    else { diabetes.CheckState = CheckState.Unchecked; }

                    if (reader[30].ToString() == "True") { sexual_dysfunction.CheckState = CheckState.Checked; }
                    else { sexual_dysfunction.CheckState = CheckState.Unchecked; }

                    if (reader[31].ToString() == "True") { strock.CheckState = CheckState.Checked; }
                    else { strock.CheckState = CheckState.Unchecked; }

                    if (reader[32].ToString() == "True") { seizure.CheckState = CheckState.Checked; }
                    else { seizure.CheckState = CheckState.Unchecked; }

                    if (reader[33].ToString() == "True") { tb.CheckState = CheckState.Checked; }
                    else { tb.CheckState = CheckState.Unchecked; }

                    if (reader[34].ToString() == "True") { weight_gain.CheckState = CheckState.Checked; }
                    else { weight_gain.CheckState = CheckState.Unchecked; }

                    if (reader[35].ToString() == "True") { weight_loss.CheckState = CheckState.Checked; }
                    else { weight_loss.CheckState = CheckState.Unchecked; }
                }
            }
            catch(Exception ex) { XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
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

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }

                Result();

                command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("SELECT * FROM phy_problem WHERE client_no = {0}", client_no.Text), connection);
                reader = command.ExecuteReader();

                int x = 0;

                while(reader.Read())
                { x += 1; }

                reader.Close();
                               
                if(x == 0)
                {
                    //INSERT COMMAND
                    
                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("INSERT INTO phy_problem(client_no,cough_sputum,dry_cough,sputum_blood,asthma,bronchitis,breathless,blood_stool,blood_vomit,constipation,dyspepsia,diarrhoea,vomiting,chest_pain,hypertension,myocardial, erythroplakia, leukoplakia, sub_mocous, mal_order,ulceration,dental_caries, staining_teeth,pain_gum,anxiety,depression,schizophrenia,other,cancer,diabetes,sexual,strock,seizure,tuberculosis,weight_gain,weight_loss) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}');", Convert.ToInt32(client_no.Text), c_s, d_c, s_b, asth, bronchi, b_l, b_s, b_v, consti, dys, dia, vomit, c_p, h_t, myocardial, erythroplakia, leuko, sub_mocous, mal, ulcertation, dental_caries, staining_teeth, p_g, anxie, depress, schizo, oth, can, diabe, sexual, strk, sei, tuberculosis, w_g, w_l), connection);
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
                    

                    command = new MySql.Data.MySqlClient.MySqlCommand(string.Format("UPDATE phy_problem SET cough_sputum = '{0}',dry_cough = '{1}',sputum_blood = '{2}',asthma = '{3}',bronchitis = '{4}',breathless = '{5}',blood_stool = '{6}',blood_vomit = '{7}',constipation = '{8}',dyspepsia = '{9}',diarrhoea = '{10}',vomiting = '{11}',chest_pain = '{12}',hypertension = '{13}',myocardial = '{14}', erythroplakia = '{15}', leukoplakia = '{16}', sub_mocous = '{17}', mal_order = '{18}',ulceration = '{19}',dental_caries = '{20}', staining_teeth = '{21}',pain_gum = '{22}',anxiety = '{23}',depression = '{24}',schizophrenia = '{25}',other = '{26}',cancer = '{27}',diabetes = '{28}',sexual = '{29}',strock = '{30}',seizure = '{31}',tuberculosis = '{32}',weight_gain = '{33}',weight_loss = '{34}'   WHERE client_no = {35}", c_s, d_c, s_b, asth, bronchi, b_l, b_s, b_v, consti, dys, dia, vomit, c_p, h_t, myocardial, erythroplakia, leuko, sub_mocous, mal, ulcertation, dental_caries, staining_teeth, p_g, anxie, depress, schizo, oth, can, diabe, sexual, strk, sei, tuberculosis, w_g, w_l, client_no.Text), connection);
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
                XtraMessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }

        private void PhysicalProblem_Load(object sender, EventArgs e)
        {
            phypr = false;
            phyproblem.Clear();
            LoadID();
        }

        private void LoadID()
        {
            try
            {
                
                if (connection.State == ConnectionState.Closed)
                { connection.Open(); }

                //Load Client No
                command = new MySqlCommand("SELECT DISTINCT(client_no) FROM phy_problem", connection);
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
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error"); }
            finally
            { connection.Close(); }
        }

        public PhysicalProblem()
        {
            InitializeComponent();            
        }

        private void ClearAll()
        {
            cough_sputum.CheckState = CheckState.Unchecked;
            dry_cough.CheckState = CheckState.Unchecked;
            sputum_blood.CheckState = CheckState.Unchecked;
            cough_sputum.CheckState = CheckState.Unchecked;
            tb.CheckState = CheckState.Unchecked;
            cancer.CheckState = CheckState.Unchecked;
            blood_stool.CheckState = CheckState.Unchecked;
            blood_vomit.CheckState = CheckState.Unchecked;
            asthma.CheckState = CheckState.Unchecked;
            bronchitis.CheckState = CheckState.Unchecked; breathless.CheckState = CheckState.Unchecked;
            constipation.CheckState = CheckState.Unchecked;
            dyspepsia.CheckState = CheckState.Unchecked;
            sexual_dysfunction.CheckState = CheckState.Unchecked;
            diarrhoea.CheckState = CheckState.Unchecked;
            chest_pain.CheckState = CheckState.Unchecked;
            hypertension.CheckState = CheckState.Unchecked;
            depression.CheckState = CheckState.Unchecked; vomiting.CheckState = CheckState.Unchecked;
            infraction.CheckState = CheckState.Unchecked;
            Erythroplakia.CheckState = CheckState.Unchecked;
            leukoplakia.CheckState = CheckState.Unchecked;
            mal_order.CheckState = CheckState.Unchecked;
            mucous.CheckState = CheckState.Unchecked;
            ulcer.CheckState = CheckState.Unchecked;
            dental.CheckState = CheckState.Unchecked;
            stain_teeth.CheckState = CheckState.Unchecked;
            pain_gum.CheckState = CheckState.Unchecked;
            anxiety.CheckState = CheckState.Unchecked;
            schizophrenia.CheckState = CheckState.Unchecked;
            other.CheckState = CheckState.Unchecked;
            diabetes.CheckState = CheckState.Unchecked;
            strock.CheckState = CheckState.Unchecked;
            seizure.CheckState = CheckState.Unchecked;
            weight_gain.CheckState = CheckState.Unchecked;
            weight_loss.CheckState = CheckState.Unchecked;
            //client_no.SelectedIndex = -1;
        }

        private void Result()
        {
            try
            {
                if (cough_sputum.Checked)
                { c_s = true; }
                else
                { c_s = false; }

                if (dry_cough.Checked)
                { d_c = true; }
                else
                { d_c = false; }

                if (sputum_blood.Checked)
                { s_b = true; }
                else
                { s_b = false; }
               
                if (asthma.Checked)
                { asth = true; }
                else
                { asth = false; }

                if (bronchitis.Checked)
                { bronchi = true; }
                else
                { bronchi = false; }

                if (breathless.Checked)
                { b_l = true; }
                else
                { b_l = false; }

                if (blood_stool.Checked)
                { b_s = true; }
                else
                { b_s = false; }

                if (blood_vomit.Checked)
                { b_v = true; }
                else
                { b_v = false; }

                if (constipation.Checked)
                { consti = true; }
                else
                { consti = false; }

                if (dyspepsia.Checked)
                { dys = true; }
                else
                { dys = false; }

                if (diarrhoea.Checked)
                { dia = true; }
                else
                { dia = false; }

                if (vomiting.Checked)
                { vomit = true; }
                else
                { vomit = false; }

                if (chest_pain.Checked)
                { c_p = true; }
                else
                { c_p = false; }

                if (hypertension.Checked)
                { h_t = true; }
                else
                { h_t = false; }

                if (infraction.Checked)
                { myocardial = true; }
                else
                { myocardial = false; }

                if (Erythroplakia.Checked)
                { erythroplakia = true; }
                else
                { erythroplakia = false; }

                if (leukoplakia.Checked)
                { leuko = true; }
                else
                { leuko = false; }

                if (mucous.Checked)
                { sub_mocous = true; }
                else
                { sub_mocous = false; }

                if (mal_order.Checked)
                { mal = true; }
                else
                { mal = false; }

                if (ulcer.Checked)
                { ulcertation = true; }
                else
                { ulcertation = false; }

                if (dental.Checked)
                { dental_caries = true; }
                else
                { dental_caries = false; }

                if (stain_teeth.Checked)
                { staining_teeth = true; }
                else
                { staining_teeth = false; }

                if (pain_gum.Checked)
                { p_g = true; }
                else
                { p_g = false; }

                if (anxiety.Checked)
                { anxie = true; }
                else
                { anxie = false; }

                if (depression.Checked)
                { depress = true; }
                else
                { depress = false; }

                if (schizophrenia.Checked)
                { schizo = true; }
                else
                { schizo = false; }

                if (other.Checked)
                { oth = true; }
                else
                { oth = false; }

                if (cancer.Checked)
                { can = true; }
                else
                { can = false; }

                if (diabetes.Checked)
                { diabe = true; }
                else
                { diabe = false; }

                if (sexual_dysfunction.Checked)
                { sexual = true; }
                else
                { sexual = false; }

                if (strock.Checked)
                { strk = true; }
                else
                { strk = false; }

                if (seizure.Checked)
                { sei = true; }
                else
                { sei = false; }

                if (tb.Checked)
                { tuberculosis = true; }
                else
                { tuberculosis = false; }

                if (weight_gain.Checked)
                { w_g = true; }
                else
                { w_g = false; }

                if (weight_loss.Checked)
                { w_l = true; }
                else
                { w_l = false; }

            }
            finally { }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                phyproblem.Clear();

                Result();
                string phy = string.Format("INSERT INTO phy_problem(client_no,cough_sputum,dry_cough,sputum_blood,asthma,bronchitis,breathless,blood_stool,blood_vomit,constipation,dyspepsia,diarrhoea,vomiting,chest_pain,hypertension,myocardial, erythroplakia, leukoplakia, sub_mocous, mal_order,ulceration,dental_caries, staining_teeth,pain_gum,anxiety,depression,schizophrenia,other,cancer,diabetes,sexual,strock,seizure,tuberculosis,weight_gain,weight_loss) VALUES($CLIENTNO$, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}');", Convert.ToInt32(client_no.Text), c_s, d_c, s_b, asth, bronchi, b_l, b_s, b_v, consti, dys, dia, vomit, c_p, h_t, myocardial, erythroplakia, leuko, sub_mocous, mal, ulcertation, dental_caries, staining_teeth, p_g, anxie, depress, schizo, oth, can, diabe, sexual, strk, sei, tuberculosis, w_g, w_l);
                phyproblem.Append(phy);
                phypr = true;

                if(DevExpress.XtraEditors.XtraMessageBox.Show("Successfully Registered! Do you want to close the dialog now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }                     
                ClearAll();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error"); }
        }
    }
}
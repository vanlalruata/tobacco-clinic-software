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
using Novacode;
using System.Diagnostics;

namespace TCS
{
    public partial class TCCMonthly : DevExpress.XtraEditors.XtraForm
    {

        private int total_client = 0, total_male = 0, total_female = 0, agm10 = 0, agf10 = 0, agt10 = 0, agm16 = 0, agf16 = 0, agt16 = 0,
            agm21 = 0, agf21 = 0, agt21 = 0, agm31 = 0, agf31 = 0, agt31 = 0, agm41 = 0, agf41 = 0, agt41 = 0, agm51 = 0, agf51 = 0, agt51 = 0,
            agm61 = 0, agf61 = 0, agt61 = 0, agm71 = 0, agf71 = 0, agt71 = 0, agm81 = 0, agf81 = 0, agt81 = 0, agm91 = 0, agf91 = 0, agt91 = 0;
        private int nc_sm = 0, nc_sf = 0, nc_slm = 0, nc_slf = 0, nc_bm = 0, nc_bf = 0, nc_tm = 0, nc_tf = 0;
        private int sf = 0, slf = 0, bf = 0, tcm = 0, tcf = 0;
        private int ex_sm = 0, ex_sf = 0, ex_st = 0, ex_slm = 0, ex_slf = 0, ex_slt = 0, ex_bm = 0, ex_bf =0, ex_bt = 0, tcf_l = 0, tcm_l = 0, tcb_l;
        private int lfu_m = 0, lfu_f = 0, lfu_t = 0, crm = 0, crf = 0, crt = 0, crem = 0 , cref = 0, cret = 0, cqm = 0, cqf = 0, cqt = 0;
        private int lc1 = 0, lc2 = 0, lc3 = 0, lc4 = 0, lc5 = 0;
        private int tcsm = 0, tcsf = 0, tcst = 0, tcslm = 0, tcslf = 0, tcslt = 0, tcbm = 0, tcbf = 0, tcbt = 0;

        public TCCMonthly()
        {
            InitializeComponent();
        }

        private void TCCMonthly_Load(object sender, EventArgs e)
        {
            try
            {
                GetYear();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void GetYear()
        {
            try
            {
                if(connection.State == ConnectionState.Closed) { connection.Open(); }
                

                command = new MySqlCommand("SELECT DISTINCT(YEAR(reg_date)) FROM intake_register", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = yearOf.Properties.Items;                
                coll.BeginUpdate();
                coll.Clear();
                while (reader.Read())
                {                    
                    if (coll.Contains(reader[0].ToString()) == false)
                    {
                        coll.Add(reader[0].ToString());
                    }                    
                }
                coll.EndUpdate();
                                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
            finally
            {                
                connection.Close();
            }        
            
        }

        private void currentMonthCommand_Click(object sender, EventArgs e)
        {
            try
            {
                monthOf.SelectedIndex = -1;
                yearOf.SelectedIndex = -1;

                DateTime tod = new DateTime();
                tod = DateTime.Today;
                monthOf.SelectedIndex = tod.Month - 1;
                yearOf.Text = tod.Year.ToString();                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (yearOf.SelectedIndex == -1 || monthOf.SelectedIndex == -1)
                { XtraMessageBox.Show("You must choose the month and the year !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                          
                
                listView1.Clear();
                listView1.Columns.Add("DESCRIPTION", 270, HorizontalAlignment.Center);
                listView1.Columns.Add("QUANTITY", 90, HorizontalAlignment.Right);             


                ListViewItem lvItem = new ListViewItem();

                //Total Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE gender='Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long male = Convert.ToInt64(command.ExecuteScalar());
                lvItem.SubItems[0].Text = "TOTAL MALE";
                lvItem.SubItems.Add(male.ToString());
                listView1.Items.Add(lvItem);
                total_male = (int)male;

                //Total Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE gender='Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long female = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL FEMALE";
                lvItem.SubItems.Add(female.ToString());
                listView1.Items.Add(lvItem);
                total_female = (int)female;

                //Total Male + Female                
                male = male + female;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE & FEMALE";
                lvItem.SubItems.Add(male.ToString());
                listView1.Items.Add(lvItem);
                total_client = (int)male;


                //Age Group 10-15 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 16 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long mten = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 10 - 15 Male";
                lvItem.SubItems.Add(mten.ToString());
                listView1.Items.Add(lvItem);
                agm10 = (int)mten;

                //Age Group 10-15 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 16 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long ften = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 10 - 15 Female";
                lvItem.SubItems.Add(ften.ToString());
                listView1.Items.Add(lvItem);
                agf10 = (int)ften;

                //Age Group 10-15 Male + Female
                mten = mten + ften;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 10 - 15 Total";
                lvItem.SubItems.Add(mten.ToString());
                listView1.Items.Add(lvItem);
                agt10 = (int)mten;

                //Age Group 16-20 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 21 AND age > 15 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long mtwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 16 - 20 Male";
                lvItem.SubItems.Add(mten.ToString());
                listView1.Items.Add(lvItem);
                agm21 = (int)mtwn;

                //Age Group 16-20 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 21 AND age > 15 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long ftwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 16 - 20 Female";
                lvItem.SubItems.Add(ftwn.ToString());
                listView1.Items.Add(lvItem);
                agf21 = (int)ftwn;

                //Age Group 16-20 Male + Female
                mtwn = mtwn + ften;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 16 - 20 Total";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agt21 = (int)mtwn;

                //Age Group 21-30 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age <31 AND age > 20 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long mthr = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 21 - 30 Male";
                lvItem.SubItems.Add(mthr.ToString());
                listView1.Items.Add(lvItem);
                agm31 = (int)mthr;

                //Age Group 21-30 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 31 AND age > 20 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long fthr = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 21 - 30 Female";
                lvItem.SubItems.Add(fthr.ToString());
                listView1.Items.Add(lvItem);
                agf31 = (int)fthr;

                //Age Group 21-30 Male + Female
                mthr = mthr + fthr;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 21 - 30 Total";
                lvItem.SubItems.Add(mthr.ToString());
                listView1.Items.Add(lvItem);
                agt31 = (int)mthr;

                //Age Group 31-40 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 41 AND age > 30 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long mfr = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 31 - 40 Male";
                lvItem.SubItems.Add(mfr.ToString());
                listView1.Items.Add(lvItem);
                agm41 = (int)mfr;

                //Age Group 31-40 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 41 AND age > 30 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long ffr = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 31 - 40 Female";
                lvItem.SubItems.Add(ffr.ToString());
                listView1.Items.Add(lvItem);
                agf41 = (int)ffr;

                //Age Group 31-40 Male + Female
                mfr = mfr + ffr;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 31 - 40 Total";
                lvItem.SubItems.Add(mfr.ToString());
                listView1.Items.Add(lvItem);
                agt41 = (int)mfr;

                //Age Group 41-50Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 51 AND age > 40 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long mfif = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 41 - 50 Male";
                lvItem.SubItems.Add(mfif.ToString());
                listView1.Items.Add(lvItem);
                agm51 = (int)mfif;

                //Age Group 41-50 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 51 AND age > 40 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long ffif = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 41 - 50 Female";
                lvItem.SubItems.Add(ffif.ToString());
                listView1.Items.Add(lvItem);
                agf51 = (int)ffif;

                //Age Group 41-50 Male + Female
                mfif = mfif + ffif;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 41 - 50 Total";
                lvItem.SubItems.Add(mfif.ToString());
                listView1.Items.Add(lvItem);
                agt51 = (int)mfif;

                //Age Group 51-60 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 61 AND age > 50 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long msix = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 51 - 60 Male";
                lvItem.SubItems.Add(msix.ToString());
                listView1.Items.Add(lvItem);
                agm61 = (int)msix;

                //Age Group 51-60 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 61 AND age > 50 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long fsix = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 51 - 60 Female";
                lvItem.SubItems.Add(fsix.ToString());
                listView1.Items.Add(lvItem);
                agf61 = (int)fsix;

                //Age Group 51-60 Male + Female
                msix = msix + fsix;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 51 - 60 Total";
                lvItem.SubItems.Add(msix.ToString());
                listView1.Items.Add(lvItem);
                agt61 = (int)msix;

                //Age Group 61-70 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 71 AND age > 60 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                mtwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 61 - 70 Male";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agm71 = (int)mtwn;

                //Age Group 61-70 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 71 AND age > 60 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                ftwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 61 - 70 Female";
                lvItem.SubItems.Add(ftwn.ToString());
                listView1.Items.Add(lvItem);
                agf71 = (int)ftwn;

                //Age Group 61-70 Male + Female
                mtwn = mtwn + ften;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 61 - 70 Total";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agt71 = (int)mtwn;

                //Age Group 71-80 Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 81 AND age > 70 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                mtwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 71 - 80 Male";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agm81 = (int)mtwn;

                //Age Group 71-80 Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age < 81 AND age > 70 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                ftwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 71 - 80 Female";
                lvItem.SubItems.Add(ftwn.ToString());
                listView1.Items.Add(lvItem);
                agf81 = (int)ftwn;

                //Age Group 71-80 Male + Female
                mtwn = mtwn + ften;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 71 - 80 Total";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agt81 = (int)mtwn;

                //Age Group 80+ Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age > 80 AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                mtwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 80 - 90 Male";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agm91 = (int)mtwn;

                //Age Group 80+ Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE age > 80 AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                ftwn = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 80 - 90 Female";
                lvItem.SubItems.Add(ftwn.ToString());
                listView1.Items.Add(lvItem);
                agf91 = (int)ftwn;

                //Age Group 80 + Male + Female
                mtwn = mtwn + ftwn;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "Age 80 - 90 Total";
                lvItem.SubItems.Add(mtwn.ToString());
                listView1.Items.Add(lvItem);
                agt91 = (int)mtwn;

                // 
                //Addiction New Client
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "CUMULATIVE FIGURE ADDICTION";
                lvItem.SubItems.Add("XXXXXX");
                listView1.Items.Add(lvItem);

                //Total Male Smoker Only
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Smoking' AND gender = 'Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE SMOKER ONLY";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                nc_sm = (int)smk;
                nc_tm += nc_sm;

                //Total Female Smoker Only
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Smoking' AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL FEMALE SMOKER ONLY";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                nc_sf = (int)smk;
                nc_tf += nc_sf;

                //Total Male Smokeless Only
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Smokeless' AND gender ='Male' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long sml = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE SMOKELESS ONLY";
                lvItem.SubItems.Add(sml.ToString());
                listView1.Items.Add(lvItem);
                nc_slm = (int)sml;
                nc_tm += nc_slm;

                //Total FeMale Smokeless Only
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Smokeless' AND gender ='Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                sml = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL FEMALE SMOKELESS ONLY";
                lvItem.SubItems.Add(sml.ToString());
                listView1.Items.Add(lvItem);
                nc_slf = (int)sml;
                nc_tf += nc_slf;

                //Total Male Both               
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Both' AND gender = 'Male'AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                long smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE BOTH";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                nc_bm = (int)smlk;
                nc_tm += nc_bm;

                //Total Female Both               
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM intake_register WHERE diagnosis_dtl='Both' AND gender = 'Female' AND MONTH(reg_date) = {0} AND YEAR(reg_date) = {1}", monthOf.SelectedIndex + 1, yearOf.Text), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE BOTH";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                nc_bf = (int)smlk;
                nc_tf += nc_bf;




                //

                string temdate = string.Format("{0}-{1}-1", yearOf.Text, monthOf.SelectedIndex + 2);
                DateTime dtSelect = new DateTime();
                dtSelect = Convert.ToDateTime(temdate);
                temdate = string.Format("{0}-{1}-1", yearOf.Text, monthOf.SelectedIndex + 1);
                DateTime dtSelMon = new DateTime();
                dtSelMon = Convert.ToDateTime(temdate);


                //Cumulative Figure
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "CUMULATIVE FIGURE CLIENT";
                lvItem.SubItems.Add("XXXXXX");
                listView1.Items.Add(lvItem);

                //Total Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND gender = 'Male' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect)), connection);
                male = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE";
                lvItem.SubItems.Add(male.ToString());
                listView1.Items.Add(lvItem);
                tcm = (int)male;

                //Total Female
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND gender = 'Female' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect)), connection);
                female = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL FEMALE";
                lvItem.SubItems.Add(female.ToString());
                listView1.Items.Add(lvItem);
                tcf = (int)female;

                //Total Male + Female                
                male = male + female;
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL MALE & FEMALE";
                lvItem.SubItems.Add(male.ToString());
                listView1.Items.Add(lvItem);

                //Cumulative Figure Addiction
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "CUMULATIVE FIGURE ADDICTION";
                lvItem.SubItems.Add("XXXXXX");
                listView1.Items.Add(lvItem);

                //Total Smoker Only

                //if last one yearOf
                //command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND diagnosis = 'Smoking' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND diagnosis = 'Smoking' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL SMOKER ONLY";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                sf = (int)smk;



                //Total Smokeless Only
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND diagnosis = 'Smokeless' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                sml = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL SMOKELESS ONLY";
                lvItem.SubItems.Add(sml.ToString());
                listView1.Items.Add(lvItem);
                slf = (int)sml;

                //Total Both               
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND diagnosis = 'Both' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "TOTAL BOTH";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                bf = (int)smlk;


                //Cumulative Existing Client Followup
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FOLLOW UP";
                lvItem.SubItems.Add("XXXXXX");
                listView1.Items.Add(lvItem);

                //Total BOTH Male Existing Client
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Both' AND gender = 'Male' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE Both";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                ex_sm = (int)smk;


                //Total BOTH FeMale Existing Client
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Both' AND gender = 'Female' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE Both";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                ex_sf = (int)smlk;

                //Total BOTH Existing Client                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                ex_st = ex_sm + ex_sf;

                //Total SMOKER Male Existing Client
                //Follow Date kha Current Date a mi tur a nih avang in...follow_date from Follow_up table...kha Condition ah add tur
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Smoking' AND gender = 'Male' AND reg_date < '{0}'", string.Format("{0:yyyy-MM-dd}", dtSelect), "2016-03-31", connection));
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE Smoker";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                ex_slm = (int)smk;                


                //Total SMOKER FeMale Existing Client
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Smoking' AND gender = 'Female' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE Smoker";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                ex_slf = (int)smlk;

                //Total SMOKER Existing Client                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL Smoker";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                ex_slt = ex_slm + ex_slf;

                //Total SMOKELESS Male Existing Client
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Smokeless' AND gender = 'male' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                ex_bm = (int)smk;


                //Total SMOKELESS FeMale Existing Client
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'NEW' AND status <> 'Terminated'  AND status <> 'Lost to Follow-up' AND diagnosis = 'Smokeless' AND gender = 'Female' AND reg_date < '{0}' AND reg_date >= '{1}'", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                ex_bf = (int)smlk;

                //Total SMOKELESS Client                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                ex_bt = ex_bm + ex_bf;



                //Total Counselling Given
                //SMOKER MALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Male' AND diagnosis = 'Smoking'", connection);
                tcsm = Convert.ToInt32(command.ExecuteScalar());

                //SMOKER FEMALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Female' AND diagnosis = 'Smoking'", connection);
                tcsf = Convert.ToInt32(command.ExecuteScalar());

                //Total Smoker
                tcst = tcsm + tcsf;

                //SMOKLESS MALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Male' AND diagnosis = 'Smokeless'", connection);
                tcslm = Convert.ToInt32(command.ExecuteScalar());

                //SMOKLESS FEMALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Female' AND diagnosis = 'Smokeless'", connection);
                tcslf = Convert.ToInt32(command.ExecuteScalar());

                //Total Smokeless
                tcslt = tcslm + tcslf;

                //BOTH MALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Male' AND diagnosis = 'Both'", connection);
                tcbm = Convert.ToInt32(command.ExecuteScalar());

                //BOTH FEMALE
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up WHERE gender = 'Female' AND diagnosis = 'Both'", connection);
                tcbf = Convert.ToInt32(command.ExecuteScalar());

                //Total BOTH
                tcbt = tcbm + tcbf;





                //Total Client Followup Last One Year Male
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status <> 'Lost to Follow-up' AND gender = 'Male' AND reg_date < '{0}' AND reg_date >= '{1}' ", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE 1 Year";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                tcm_l = (int)smk;


                //Total Client Followup Last One Year FeMale
                command = new MySqlCommand(string.Format("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status <> 'Lost to Follow-up' AND gender = 'Female' AND reg_date < '{0}' AND reg_date >= '{1}' ", string.Format("{0:yyyy-MM-dd}", dtSelect), string.Format("{0:yyyy-MM-dd}", dtSelMon.AddMonths(-12))), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                tcf_l = (int)smlk;

                //Total Client Followup Last One Year Total               
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                tcb_l = tcm_l + tcf_l;

                //Total Client Lost Followup Last One Year Male
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Lost to Follow-up' AND gender = 'Male' AND follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE 1 Year";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                lfu_m = (int)smk;


                //Total BClient Lost Followup Last One Year FeMale
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Lost to Follow-up' AND gender = 'Female' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lfu_f = (int)smlk;

                //Total Client Lost Followup Last One Year Total               
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                lfu_t = lfu_m + lfu_f;


                //Does not own Phone or Number
                //Phone Connectivity Problem
                //Call Not Picking
                //Not Reachable
                //Others
                //Total Client Lost Followup Last One Year 
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status = 'Lost to Follow-up' AND detail = 'Does not own Phone or Number' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lc1 = (int)smlk;

                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status = 'Lost to Follow-up' AND detail = 'Phone Connectivity Problem' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lc2 = (int)smlk;

                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status = 'Lost to Follow-up' AND detail = 'Call Not Picking' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lc3 = (int)smlk;

                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status = 'Lost to Follow-up' AND detail = 'Not Reachable' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lc4 = (int)smlk;

                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status = 'Lost to Follow-up' AND detail = 'Others' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                lc5 = (int)smlk;


                //Total Client RELAPSE Last One Year Male
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Relapse' AND gender = 'Male' AND follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE 1 Year";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                crm = (int)smk;


                //Total BClient RELAPSE Last One Year FeMale
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Relapse' AND gender = 'Female' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                crf = (int)smlk;

                //Total Client RELAPSE Last One Year Male                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                crt = crm + crf;

                //Total Client REDUCE Last One Year Male
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Reduce' AND gender = 'Male' AND follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE 1 Year";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                crem = (int)smk;


                //Total BClient REDUCE Last One Year FeMale
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Reduce' AND gender = 'Female' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                cref = (int)smlk;

                //Total Client REDUCE  Last One Year Male                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                cret = crem + cref;

                //Total Client QUIT Last One Year Male
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Quit' AND gender = 'Male' AND follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT MALE 1 Year";
                lvItem.SubItems.Add(smk.ToString());
                listView1.Items.Add(lvItem);
                cqm = (int)smk;


                //Total BClient QUIT Last One Year FeMale
                command = new MySqlCommand("SELECT COUNT(client_no) FROM follow_up_status WHERE status <> 'Terminated' AND status <> 'NEW' AND status = 'Quit' AND gender = 'Female' AND  follow_date >= " + string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddMonths(-12)), connection);
                smlk = Convert.ToInt64(command.ExecuteScalar());
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT FEMALE 1 Year";
                lvItem.SubItems.Add(smlk.ToString());
                listView1.Items.Add(lvItem);
                cqf = (int)smlk;

                //Total Client QUIT  Last One Year Male                
                lvItem = new ListViewItem();
                lvItem.SubItems[0].Text = "EXISTING CLIENT TOTAL";
                lvItem.SubItems.Add((smk + smlk).ToString());
                listView1.Items.Add(lvItem);
                cqt = cqm + cqf;

                //Get

            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally
            {
                connection.Close();
            }
        }

        private void LoadtoList()
        {

        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Columns.Count < 1) { XtraMessageBox.Show("Cannot Save any report since tere is no item to be fetched!", "Error"); return; }
                string fileNameTemplate = "";
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Docx | *.docx";
                    sfd.InitialDirectory = "D:\\TCC\\";
                    sfd.FileName = string.Format("TCCReport{0}{1}", monthOf.Text, yearOf.Text);
                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        fileNameTemplate = sfd.FileName;
                    }
                }

                
                // Let's save the file with a meaningful name, including the 
                // applicant name and the letter date:
                string outputFileName = fileNameTemplate;

                // Grab a reference to our document template:
                DocX letter = DocX.Load(@"TCCReportTemplate.docx");

                // Perform the replace:
                letter.ReplaceText("%centername%", Properties.Settings.Default.CenterName);
                letter.ReplaceText("%TC%", total_client.ToString());
                letter.ReplaceText("%F%", total_female.ToString());
                letter.ReplaceText("%M%", total_male.ToString());

                letter.ReplaceText("%a1%", agm10.ToString());
                letter.ReplaceText("%a2%", agf10.ToString());
                letter.ReplaceText("%a3%", agt10.ToString());

                letter.ReplaceText("%a4%", agm16.ToString());
                letter.ReplaceText("%a5%", agf16.ToString());
                letter.ReplaceText("%a6%", agt16.ToString());

                letter.ReplaceText("%a7%", agm21.ToString());
                letter.ReplaceText("%a8%", agf21.ToString());
                letter.ReplaceText("%a9%", agt21.ToString());

                letter.ReplaceText("%b1%", agm31.ToString());
                letter.ReplaceText("%b2%", agf31.ToString());
                letter.ReplaceText("%b3%", agt31.ToString());

                letter.ReplaceText("%b4%", agm41.ToString());
                letter.ReplaceText("%b5%", agf41.ToString());
                letter.ReplaceText("%b6%", agt41.ToString());

                letter.ReplaceText("%b7%", agm51.ToString());
                letter.ReplaceText("%b8%", agf51.ToString());
                letter.ReplaceText("%b9%", agt51.ToString());

                letter.ReplaceText("%c1%", agm61.ToString());
                letter.ReplaceText("%c2%", agf61.ToString());
                letter.ReplaceText("%c3%", agt61.ToString());

                letter.ReplaceText("%c4%", agm71.ToString());
                letter.ReplaceText("%c5%", agf71.ToString());
                letter.ReplaceText("%c6%", agt71.ToString());

                letter.ReplaceText("%c7%", agm81.ToString());
                letter.ReplaceText("%c8%", agf81.ToString());
                letter.ReplaceText("%c9%", agt81.ToString());

                letter.ReplaceText("%x%", (agm10 + agm21 + agm31 + agm41 + agm51 + agm61 + agm71+ agm81).ToString());
                letter.ReplaceText("%y%", (agf10 + agf21 + agf31 + agf41 + agf51 + agf61 + agf71 + agf81).ToString());
                letter.ReplaceText("%z%", (agm10 + agm21 + agm31 + agm41 + agm51 + agm61 + agm71 + agm81 + agf10 + agf21 + agf31 + agf41 + agf51 + agf61 + agf71 + agf81).ToString());

                letter.ReplaceText("%nc1%", nc_sm.ToString());
                letter.ReplaceText("%nc2%", nc_sf.ToString());
                letter.ReplaceText("%nc3%", nc_slm.ToString());
                letter.ReplaceText("%nc4%", nc_slf.ToString());
                letter.ReplaceText("%nc5%", nc_bm.ToString());
                letter.ReplaceText("%nc6%", nc_bf.ToString());
                letter.ReplaceText("%nc7%", nc_tm.ToString());
                letter.ReplaceText("%nc8%", nc_tf.ToString());

                letter.ReplaceText("%ec1%", ex_slm.ToString());
                letter.ReplaceText("%ec2%", ex_slf.ToString());
                letter.ReplaceText("%et1%", ex_slt.ToString());

                letter.ReplaceText("%ec3%", ex_bm.ToString());
                letter.ReplaceText("%ec4%", ex_bf.ToString());
                letter.ReplaceText("%et2%", ex_bt.ToString());

                letter.ReplaceText("%ec5%", ex_sm.ToString());
                letter.ReplaceText("%ec6%", ex_sf.ToString());
                letter.ReplaceText("%et3%", ex_st.ToString());

                letter.ReplaceText("%ec7%", (ex_sm + ex_slm + ex_bm).ToString());
                letter.ReplaceText("%ec8%", (ex_sf + ex_slf + ex_bf).ToString());
                letter.ReplaceText("%et4%", (ex_st + ex_slt + ex_bt).ToString());

                letter.ReplaceText("%m1%", tcm.ToString());
                letter.ReplaceText("%f1%", tcf.ToString());
                letter.ReplaceText("%mft%", (tcm + tcf).ToString());

                letter.ReplaceText("%sf1%", sf.ToString());
                letter.ReplaceText("%sf2%", slf.ToString());
                letter.ReplaceText("%sf3%", bf.ToString());

                letter.ReplaceText("%wef%", string.Format(@"Upto {0}, {1}", monthOf.Text, yearOf.Text));

                letter.ReplaceText("%FFM%", tcm_l.ToString());
                letter.ReplaceText("%FFF%", tcf_l.ToString());
                letter.ReplaceText("%FFT%", tcb_l.ToString());

                int t_male = lfu_m + tcm_l;
                letter.ReplaceText("%ncfm%", (((float)tcm_l / (float)t_male) * 100).ToString("00.00"));

                int t_female = lfu_f + tcf_l;
                letter.ReplaceText("%ncff%", (((float)tcf_l / (float)t_female) * 100).ToString("00.00"));

                int t_client = lfu_t + tcb_l;
                letter.ReplaceText("%ncft%", (((float)tcb_l / (float)t_client) * 100).ToString("00.00"));


                letter.ReplaceText("%LFM%", lfu_m.ToString());
                letter.ReplaceText("%LFF%", lfu_f.ToString());
                letter.ReplaceText("%LFT%", lfu_t.ToString());

                letter.ReplaceText("%RRM%", crm.ToString());
                letter.ReplaceText("%RRF%", crf.ToString());
                letter.ReplaceText("%RRT%", crt.ToString());

                letter.ReplaceText("%RUM%", crem.ToString());
                letter.ReplaceText("%RUF%", cref.ToString());
                letter.ReplaceText("%RUT%", cret.ToString());

                letter.ReplaceText("%QRM%", cqm.ToString());
                letter.ReplaceText("%QRF%", cqf.ToString());
                letter.ReplaceText("%QRT%", cqt.ToString());

                //Reason
                letter.ReplaceText("%dwp%", lc1.ToString());
                letter.ReplaceText("%pcp%", lc2.ToString());
                letter.ReplaceText("%dpc%", lc3.ToString());
                letter.ReplaceText("%nrp%", lc4.ToString());
                letter.ReplaceText("%wrn%", lc5.ToString());
                letter.ReplaceText("%losttotal%", (lc1 + lc2 + lc3 + lc4 + lc5).ToString());

                //Lost to folloup Percentage tcm_l   tcf_l  tcb_l   lfu_m lfu_f   lfu_t
                letter.ReplaceText("%t1%", (((float)lfu_m / (tcm_l + lfu_m)) * 100).ToString("00.00"));
                letter.ReplaceText("%t2%", (((float)lfu_f / (tcf_l + lfu_f)) * 100).ToString("00.00"));
                letter.ReplaceText("%t3%", (((float)lfu_t / (tcb_l + lfu_t)) * 100).ToString("00.00"));

                //Reduce tcm_l   crem  cref cret
                letter.ReplaceText("%t4%", (((float)crem / (float)tcm_l) * 100).ToString("00.00"));
                letter.ReplaceText("%t5%", (((float)cref / (float)tcf_l) * 100).ToString("00.00"));
                letter.ReplaceText("%t6%", (((float)cret / (float)tcb_l) * 100).ToString("00.00"));

                //Quit tcm_l   crem  cref cret
                letter.ReplaceText("%t7%", (((float)cqm / (float)tcm_l) * 100).ToString("00.00"));
                letter.ReplaceText("%t8%", (((float)cqf / (float)tcf_l) * 100).ToString("00.00"));
                letter.ReplaceText("%t9%", (((float)cqt / (float)tcb_l) * 100).ToString("00.00"));

                //Relapse tcm_l    crm   crf crt   
                letter.ReplaceText("%s1%", (((float)crm / (float)tcm_l) * 100).ToString("00.00"));
                letter.ReplaceText("%s2%", (((float)crf / (float)tcf_l) * 100).ToString("00.00"));
                letter.ReplaceText("%s3%", (((float)crt / (float)tcb_l) * 100).ToString("00.00"));


                //Yet to be developed
                letter.ReplaceText("%tc1%", tcsm.ToString());
                letter.ReplaceText("%tc2%", tcsf.ToString());
                letter.ReplaceText("%tc3%", tcslm.ToString());
                letter.ReplaceText("%tc4%", tcslf.ToString());
                letter.ReplaceText("%tc5%", tcbm.ToString());
                letter.ReplaceText("%tc6%", tcbf.ToString());
                letter.ReplaceText("%tc7%", (tcsm + tcslm + tcbm) . ToString());
                letter.ReplaceText("%tc8%", (tcsf + tcslf + tcbf).ToString());
                letter.ReplaceText("%tt1%", tcst.ToString());
                letter.ReplaceText("%tt2%", tcslt.ToString());
                letter.ReplaceText("%tt3%", tcbt.ToString());
                letter.ReplaceText("%tt4%", (tcst + tcslt + tcbt).ToString());

                // Save as New filename:
                letter.SaveAs(outputFileName);

                // Open in word:
                Process.Start("WINWORD.EXE", string.Format("\"{0}\"", outputFileName));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
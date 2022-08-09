using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ConnectionString;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Novacode;
using System.Threading.Tasks;

namespace TCS
{
    public partial class mainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        PharmoStock ps;
        PharmoIssue pi;
        FollowUp fl;
        IntakeRegister it;
        ClientDetailForm cdf;
        CenterInfoForm cif;
        PhysicalProblem pp;
        TobaccoUse tu;
        Substances sus;
        Severity se;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.mySkin.ToString());


                this.Size = Properties.Settings.Default.mySize;
                this.Location = Properties.Settings.Default.myLocation;

                if(this.Size == new Size(1002, 729))
                {
                    this.Width = Screen.PrimaryScreen.Bounds.Width - 10;
                    this.Height = Screen.PrimaryScreen.Bounds.Height - 40;
                }             
                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Properties.Settings.Default.mySkin = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName.ToString();
                Properties.Settings.Default.myLocation = this.Location;
                Properties.Settings.Default.mySize = this.Size;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void about_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                About ab = new About();
                ab.ShowInTaskbar = false;                
                ab.ShowDialog();

            }
            catch (Exception ex)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
                alertControl1.ShowCloseButton = true;
                alertControl1.Show(this, "Error!", ex.Message);
            }
        }

        private void setting_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                AppSettings aps = new AppSettings();
                aps.ShowInTaskbar = false;
                aps.ShowDialog();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private Form ShowOrActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }
            return form;
        }

        private void phar_stock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps = ShowOrActiveForm(ps, typeof(PharmoStock)) as PharmoStock;
                ps.save_btn.Visible = true;
                ps.modify_btn.Visible = false;
                ps.remove_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = ShowOrActiveForm(pi, typeof(PharmoIssue)) as PharmoIssue;
                pi.save_btn.Visible = true;
                pi.modify_btn.Visible = false;
                pi.remove_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void FollowUp_Btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                fl = ShowOrActiveForm(fl, typeof(FollowUp)) as FollowUp;
                fl.modify_btn.Visible = false;
                fl.save_btn.Visible = true;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void client_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                it = ShowOrActiveForm(it, typeof(IntakeRegister)) as IntakeRegister;
                it.client_no.Enabled = false;
                it.ModifyButton.Visible = false;
                it.RemoveButton.Visible = false;
                it.save_btn.Visible = true;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void phar_mod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps = ShowOrActiveForm(ps, typeof(PharmoStock)) as PharmoStock;
                ps.save_btn.Visible = false;
                ps.modify_btn.Visible = true;
                ps.remove_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void phar_del_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ps = ShowOrActiveForm(ps, typeof(PharmoStock)) as PharmoStock;
                ps.save_btn.Visible = false;
                ps.modify_btn.Visible = false;
                ps.remove_btn.Visible = true;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void phar_det_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PharStockDetail psd = new PharStockDetail();
                psd.ShowInTaskbar = false;
                psd.ShowDialog();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void Issue_Mod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = ShowOrActiveForm(pi, typeof(PharmoIssue)) as PharmoIssue;
                pi.save_btn.Visible = false;
                pi.modify_btn.Visible = true;
                pi.remove_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void Issue_Del_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = ShowOrActiveForm(pi, typeof(PharmoIssue)) as PharmoIssue;
                pi.save_btn.Visible = false;
                pi.modify_btn.Visible = false;
                pi.remove_btn.Visible = true;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void Issue_Det_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PharIssueDetail pid = new PharIssueDetail();
            pid.ShowInTaskbar = false;
            pid.ShowDialog();
        }

        private void follow_modi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                fl = ShowOrActiveForm(fl, typeof(FollowUp)) as FollowUp;
                fl.modify_btn.Visible = true;
                fl.save_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void Client_Modi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void Client_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                it = ShowOrActiveForm(it, typeof(IntakeRegister)) as IntakeRegister;
                it.client_no.Enabled = true;
                it.ModifyButton.Visible = false;
                it.RemoveButton.Visible = true;
                it.save_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void Client_Detail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cdf = ShowOrActiveForm(cdf, typeof(ClientDetailForm)) as ClientDetailForm;                
                    //DetailSearch myControl = new DetailSearch();
                    //DevExpress.XtraEditors.XtraDialog.Show(myControl, "Search in", MessageBoxButtons.OK);                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void exit_Button_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            
        }

        private void abtButton_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            try
            {
                About ab = new About();
                ab.ShowInTaskbar = false;
                ab.ShowDialog();

            }
            catch (Exception ex)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
                alertControl1.ShowCloseButton = true;
                alertControl1.Show(this, "Error!", ex.Message);
            }
        }

        private void email_button_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mailto:vanlalruata.hnamte@gmail.com");
            }
            catch (Exception ex)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
                alertControl1.ShowCloseButton = true;
                alertControl1.Show(this, "Error!", ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CenterNo = center_no.Text;
                Properties.Settings.Default.CenterCode = center_code.Text;
                Properties.Settings.Default.CenterName = center_name.Text;
                Properties.Settings.Default.Email = email.Text;
                Properties.Settings.Default.Contact = contact.Text;
                Properties.Settings.Default.Save();
                DevExpress.XtraEditors.XtraMessageBox.Show("Saved Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
                alertControl1.ShowCloseButton = true;
                alertControl1.Show(this, "Error!", ex.Message);
            }
        }

        private void backstageViewControl1_Showing(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Reload();
                
                center_no.Text = Properties.Settings.Default.CenterNo ;
                center_code.Text = Properties.Settings.Default.CenterCode ;
                center_name.Text = Properties.Settings.Default.CenterName ;
                email.Text = Properties.Settings.Default.Email ;
                contact.Text = Properties.Settings.Default.Contact ;                
            }
            catch (Exception ex)
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
                alertControl1.ShowCloseButton = true;
                alertControl1.Show(this, "Error!", ex.Message);
            }
        }

        private void centerInfo_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cif = ShowOrActiveForm(cif, typeof(CenterInfoForm)) as CenterInfoForm;                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void tcc_Monthly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //ClientReport cr = new ClientReport();
                //ReportClient cr = new ReportClient();

                TCCMonthly cr = new TCCMonthly();
                cr.ShowInTaskbar = false;
                cr.ShowDialog();


            }
            catch(Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

       

        private void client_mody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                it = ShowOrActiveForm(it, typeof(IntakeRegister)) as IntakeRegister;
                it.client_no.Enabled = true;
                it.ModifyButton.Visible = true;
                it.RemoveButton.Visible = false;
                it.save_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void tobacco_use_mody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tu = ShowOrActiveForm(tu, typeof(TobaccoUse)) as TobaccoUse;
                tu.client_no.Enabled = true;
                tu.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                
                tu.save_btn.Visible = false;
                tu.addButton.Visible = true;

                if(connection.State == ConnectionState.Closed) { connection.Open(); }
                command = new MySql.Data.MySqlClient.MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = tu.client_no.Properties.Items;

                coll.BeginUpdate();
                coll.Clear();

                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }
                coll.EndUpdate();

                reader.Close();
                connection.Close();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void tobacco_se_mody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                se = ShowOrActiveForm(se, typeof(Severity)) as Severity;
                se.client_no.Enabled = true;
                se.dignosis_box.Enabled = true;
                se.dignosis_box.Visible = false;
                se.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                se.inedit = true;
                se.save_btn.Visible = false;
                se.modify_btn.Visible = true;
                se.diagnosis = "";
                se.labelControl18.Text = "Name : ";
                se.LoadClient();       
                
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void substance_mody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                sus = ShowOrActiveForm(sus, typeof(Substances)) as Substances;
                sus.client_no.Enabled = true;
                sus.modify_btn.Visible = true;
                sus.save_btn.Visible = false;
                sus.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;



                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                command = new MySql.Data.MySqlClient.MySqlCommand("SELECT DISTINCT(client_no) FROM intake_register", connection);
                reader = command.ExecuteReader();

                ComboBoxItemCollection coll = sus.client_no.Properties.Items;

                coll.BeginUpdate();
                coll.Clear();

                while (reader.Read())
                {
                    coll.Add(reader[0].ToString());
                }
                coll.EndUpdate();

                reader.Close();
                connection.Close();
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void phy_prb_mody_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pp = ShowOrActiveForm(pp, typeof(PhysicalProblem)) as PhysicalProblem;
                pp.client_no.Enabled = true;
                pp.modify_btn.Visible = true;               
                pp.save_btn.Visible = false;
                pp.client_no.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void client_del_button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                it = ShowOrActiveForm(it, typeof(IntakeRegister)) as IntakeRegister;
                it.client_no.Enabled = true;
                it.ModifyButton.Visible = false;
                it.RemoveButton.Visible = true;
                it.save_btn.Visible = false;
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
        }

        private void BackUpButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                using (SaveFileDialog sv = new SaveFileDialog())
                {
                    sv.Filter = "SQL File | *.sql";
                    sv.InitialDirectory = "D:\\TCC\\";
                    sv.Title = "Backup Save File Location";
                    sv.FileName = "Backup_TCC_" + string.Format("{0:dd-MMM-yyyy}", DateTime.Today);

                    if(!sv.CheckPathExists == true)
                    {
                        System.IO.Directory.CreateDirectory("D:\\TCC\\");
                    }

                    if(sv.ShowDialog() == DialogResult.OK)
                    {
                        MySqlConnectionStringBuilder str = new MySqlConnectionStringBuilder();
                        str.Server = Properties.Settings.Default.dbServer;
                        str.UserID = Properties.Settings.Default.dbUser;
                        str.Password = Properties.Settings.Default.dbPassword;
                        str.Database = Properties.Settings.Default.dbName;


                        using (MySqlConnection con = new MySqlConnection(str.ToString()))
                        {
                            using (MySqlCommand com = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(com))
                                {
                                    com.Connection = con;
                                    con.Open();
                                    mb.ExportToFile(sv.FileName);
                                    con.Close();
                                }
                            }
                        }                       
                    }
                }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
        }
        

        private void ReStoreButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //if (connection.State == ConnectionState.Closed) { connection.Open(); }

                using (OpenFileDialog sv = new OpenFileDialog())
                {
                    sv.Filter = "SQL File | *.sql";
                    sv.InitialDirectory = "D:\\TCC\\";
                    sv.Title = "Restore Database";                    
                   
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        RestoreDatabase(sv.FileName);
                    }
                }
            }
            catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!"); }
            finally { connection.Close(); }
        }

        private void RestoreDatabase(string path)
        {
            if(MessageBox.Show("Are you sure to restore the database?\n\nDoing this will overwrite all the previous data!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Bla Bla
                MySqlConnectionStringBuilder str = new MySqlConnectionStringBuilder();
                str.Server = Properties.Settings.Default.dbServer;
                str.UserID = Properties.Settings.Default.dbUser;
                str.Password = Properties.Settings.Default.dbPassword;
                str.Database = Properties.Settings.Default.dbName;


                using (MySqlConnection con = new MySqlConnection(str.ToString()))
                {
                    using (MySqlCommand com = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(com))
                        {
                            com.Connection = con;
                            con.Open();
                            mb.ImportFromFile(path);
                            con.Close();
                        }
                    }
                }
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string constring = "server=localhost;user=root;pwd=1234;database=test1;";
            //string file = "Y:\\backup.sql";
            //using (MySqlConnection conn = new MySqlConnection(constring))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand())
            //    {
            //        using (MySqlBackup mb = new MySqlBackup(cmd))
            //        {
            //            cmd.Connection = conn;
            //            conn.Open();
            //            mb.ExportInfo.AddCreateDatabase = true;
            //            mb.ExportInfo.ExportTableStructure = true;
            //            mb.ExportInfo.ExportRows = true;
            //            mb.ExportToFile(file);                        
            //        }
            //    }
            //}
        }

        private void allQuitterButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Quit'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "QUITTER LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\quitter_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void nqlButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();
                StringBuilder addict = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status, it.diagnosis_dtl FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status <> 'Quit'", connection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    clientno.AppendLine("----------");

                    name.AppendLine(string.Format("{0}",reader[1].ToString()));
                    name.AppendLine("-------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    contact.AppendLine("--------------------------");

                    locality.AppendLine(reader[3].ToString());
                    locality.AppendLine("-------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    status.AppendLine("--------------------");

                    addict.AppendLine(reader[5].ToString());
                    addict.AppendLine("------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"anql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%addic%", addict.ToString());
                letter.ReplaceText("%header%", "NON-QUITTER LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\anql_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        
        }

        private void QuitterButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Quit'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "QUITTER LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\quitter_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void reduceButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Reduce'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "REDUCE USE LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\red_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void relaspeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Relapse'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "RELAPSE LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\rel_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void nochangeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'No Change'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "NO CHANGE USE LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\ncu_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LostFollowupButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Lost to Follow-up'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "LOST TO FOLLOWUP LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\ltfu_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void TerminatedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'Terminated'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "TERMINATED LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\terminaed_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void thingTODOButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.status = 'NEW'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "NEW CLIENT LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\ncl_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void allClientButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "ALL CLIENT LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\allclient_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void maleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();
                StringBuilder slli = new StringBuilder();

                int slno = 0;

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register WHERE gender = 'Male'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

                    slno += 1;

                    slli.AppendLine(slno.ToString());
                }
                reader.Close();



                DocX letter = DocX.Load(@"gender.docx");

                // Perform the replace:
                letter.ReplaceText("%no%", slli.ToString());
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "MALE CLIENT LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\maleclient_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void femaleButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();
                StringBuilder slli = new StringBuilder();

                int slno = 0;

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT client_no, client_name, contact, address, diagnosis_dtl FROM intake_register WHERE gender = 'Female'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

                    slno += 1;

                    slli.AppendLine(slno.ToString());
                }
                reader.Close();



                DocX letter = DocX.Load(@"gender.docx");

                // Perform the replace:
                letter.ReplaceText("%no%", slli.ToString());
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "FEMALE CLIENT LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\femaleclient_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void smokeTypeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.diagnosis = 'Smoking'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "SMOKE FORM LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\smoker_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void smokelesstypeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.diagnosis = 'Smokeless'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "SMOKELESS FORM LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\smoker_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void bothtypeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StringBuilder clientno = new StringBuilder();
                StringBuilder name = new StringBuilder();
                StringBuilder contact = new StringBuilder();
                StringBuilder locality = new StringBuilder();
                StringBuilder status = new StringBuilder();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                command = new MySqlCommand("SELECT it.client_no, it.client_name, it.contact, it.address, fs.status FROM intake_register it JOIN follow_up_status fs WHERE fs.client_no = it.client_no AND fs.diagnosis = 'Both'", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientno.AppendLine(reader[0].ToString());
                    //clientno.AppendLine("-----------");

                    name.AppendLine(reader[1].ToString());
                    //name.AppendLine("-------------------------------------------------------------");

                    contact.AppendLine(reader[2].ToString());
                    //contact.AppendLine("------------------------------");

                    locality.AppendLine(reader[3].ToString());
                    //locality.AppendLine("-------------------------------------------------------------------");

                    status.AppendLine(reader[4].ToString());
                    //status.AppendLine("------------------------");
                }
                reader.Close();



                DocX letter = DocX.Load(@"nql.docx");

                // Perform the replace:
                letter.ReplaceText("%sl%", clientno.ToString());
                letter.ReplaceText("%name%", name.ToString());
                letter.ReplaceText("%cont%", contact.ToString());
                letter.ReplaceText("%addr%", locality.ToString());
                letter.ReplaceText("%stat%", status.ToString());
                letter.ReplaceText("%header%", "SMOKE AND SMOKELESS FORM LIST");

                if (!Directory.Exists("D:\\TCC\\")) { Directory.CreateDirectory("D:\\TCC\\"); }

                var t = Task<string>.Factory.StartNew(() =>
                {
                    return string.Format("D:\\TCC\\smoker_{0}.docx", string.Format("{0:dd-MM-yyyy}", DateTime.Now));
                });

                letter.SaveAs(t.Result);
                Process.Start("winword.exe", t.Result);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tcc_Quarterly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (connection.State == ConnectionState.Closed) { connection.Open(); }
            //using (MySqlTransaction trans = connection.BeginTransaction())
            //{
            //    try
            //    {

            //        command = new MySqlCommand("UPDATE follow_up JOIN intake_register SET follow_up.diagnosis = intake_register.diagnosis_dtl, follow_up.gender = intake_register.gender WHERE follow_up.client_no = intake_register.client_no", connection, trans);
            //        command.ExecuteNonQuery();

            //        trans.Commit();

            //        XtraMessageBox.Show("Done!");

            //    }
            //    catch (Exception ex) { DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); trans.Rollback(); }
            //    finally { connection.Close(); }
            //}
        }
    }
}

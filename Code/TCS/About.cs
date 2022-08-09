using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace TCS
{
    public partial class About : DevExpress.XtraEditors.XtraForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            try
            {       
                byte[] name = {86,0,97,0,110,0,108,0,97,0,108,0,114,0,117,0,97,0,116,0,97,0,32,0,72,0,110,0,97,0,109,0,116,0,101,0};
                byte[] email = { 118, 0, 97, 0, 110, 0, 108, 0, 97, 0, 108, 0, 114, 0, 117, 0, 97, 0, 116, 0, 97, 0, 46, 0, 104, 0, 110, 0, 97, 0, 109, 0, 116, 0, 101, 0, 64, 0, 103, 0, 109, 0, 97, 0, 105, 0, 108, 0, 46, 0, 99, 0, 111, 0, 109, 0};
                byte[] contact = { 43, 0, 57, 0, 49, 0, 32, 0, 56, 0, 48, 0, 49, 0, 52, 0, 57, 0, 57, 0, 57, 0, 55, 0, 48, 0, 52, 0 };

                labelControl2.Text = Encoding.Unicode.GetString(name).ToString();
                emailControl.Text = Encoding.Unicode.GetString(email).ToString();
                labelControl4.Text = Encoding.Unicode.GetString(contact).ToString();

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error!");
            }
        }

        private void emailControl_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:vanlalruata.hnamte@gmail.com");
        }
    }
}
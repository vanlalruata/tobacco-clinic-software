using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static ConnectionString;
using MySql.Data.MySqlClient;

namespace TCS
{
    public partial class ReportClient : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int client_no = 0;
        public ReportClient()
        {
            InitializeComponent();
        }

        private void ReportClient_Load(object sender, EventArgs e)
        {
            try
            {
                adapter = new MySqlDataAdapter(string.Format("SELECT * FROM intake_register WHERE Client_No = {0}", client_no), connection);

                DataSet sourceDataSet = new DataSet();
                adapter.Fill(sourceDataSet);


                
            }
            catch (Exception ex) { }
        }
    }
}
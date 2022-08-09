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

namespace TCS
{
    public partial class PharStockDetail : DevExpress.XtraEditors.XtraForm
    {
        public PharStockDetail()
        {
            InitializeComponent();
        }

        private void PharStockDetail_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                RetrieveAll();
               
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {                              
                connection.Close();
            }
        }

        private void RetrieveAll()
        {
            int x = 0;
            string[] sb = new string[100];
            if(connection.State == ConnectionState.Closed) { connection.Open(); }
            

            listView1.Clear();

            command = new MySqlCommand("SELECT DISTINCT(Medicine_Name) FROM phar_stock", connection);
            reader = command.ExecuteReader();

            listView1.Columns.Add("", 100);

            while (reader.Read())
            {
                listView1.Columns.Add(reader[0].ToString(), 100);
                sb[x] = reader[0].ToString();
                x += 1;
            }



            if (!reader.IsClosed) { reader.Close(); }



            ListViewItem lvItem = new ListViewItem();
            lvItem.SubItems[0].Text = "TOTAL RECORD";

            int k = 0;
            int a = 0;
            int y = sb.Length;
            string[] med = new string[y];
            while(y > 0)
            {
                string name = sb[a];
                command = new MySqlCommand("SELECT Quantity FROM phar_stock WHERE Medicine_Name = '" + name + "'", connection);
                reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    k += Convert.ToInt32(reader[0]);
                }

                lvItem.SubItems.Add(k.ToString());

                y--;
                a++;
                k = 0;
                if (!reader.IsClosed) { reader.Close(); }
            }

            listView1.Items.Add(lvItem);

            


        }
    }
}
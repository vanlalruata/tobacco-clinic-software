using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection connection = new MySqlConnection();
        private MySqlCommand command = new MySqlCommand();
        private MySqlConnectionStringBuilder conb = new MySqlConnectionStringBuilder();

        private void test_button_Click(object sender, EventArgs e)
        {
            try
            {               
                conb.Server = "localhost";                
                conb.UserID = usertext.Text;
                conb.Password = passtext.Text;

                connection = new MySqlConnection(conb.ToString());
               

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                if(connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successfully connected! You can continue now!","Success");
                    EX_Button.Visible = true;
                }
                else { EX_Button.Visible = false; }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!"); EX_Button.Visible = false;
            }
            finally { connection.Close(); }

        }

        private void EX_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                using (MySqlTransaction trans = connection.BeginTransaction())
                {
                    try
                    {
                        //Back up the database first    and   Check the Database Exist!!


                        //Creating Table Etc         
                        command = new MySqlCommand("DROP DATABASE IF EXISTS dtcc; CREATE DATABASE dtcc; USE dtcc;", connection, trans);
                        //command = new MySqlCommand("USE dtcc;", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("CREATE TABLE IF NOT EXISTS `center_info` (`Center_No` varchar(11) NOT NULL,  `Center_Code` varchar(255) DEFAULT NULL,  `Center_Name` varchar(255) DEFAULT NULL,  `Contact_Number` varchar(255) DEFAULT NULL,  `Email_Address` varchar(255) DEFAULT NULL,  `IsDefault` enum('True','False') DEFAULT 'False',  PRIMARY KEY(`Center_No`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;", connection, trans);
                        command.ExecuteNonQuery();

                        //Aizawl West
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES ('01', 'AZLW', 'Aizawl West', '0000000000', 'smokefreemizoram@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Lunglei
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('02', 'LLI', 'Lunglei', '00000000000', 'tcplunglei@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('04', 'CPI', 'Champhai', '8413843622', 'ntcpchamphai@gmail.com', 'True'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('03', 'SHA', 'Saiha', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('05', 'KLB', 'Kolasib', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('06', 'SER', 'Serchhip', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('07', 'LTL', 'Lawngtlai', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Champhai
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('08', 'MMT', 'Mamit', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Aizawl East A
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('09A', 'AZLE', 'MSCI Aizawl', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();
                        //Aizawl East B
                        command = new MySqlCommand("INSERT INTO `center_info` VALUES('09B', 'AZLE', 'SRH Falkawn', '8413843622', 'ntcpchamphai@gmail.com', 'False'); ", connection, trans);
                        command.ExecuteNonQuery();



                        command = new MySqlCommand("DROP TABLE IF EXISTS `detail_tobacco_use`; CREATE TABLE IF NOT EXISTS `detail_tobacco_use` ( `center_code` varchar(10) DEFAULT NULL,  `center_no` varchar(11) DEFAULT NULL,  `client_no` int(11) NOT NULL,  `smoking_type` varchar(255) NOT NULL,  `tobacco_product` varchar(255) NOT NULL,  `age_onset` int(11) DEFAULT NULL,  `years_of_regular` int(11) DEFAULT NULL,  `avg_in_chew` int(11) DEFAULT NULL,  `brandName` varchar(255) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `follow_up`; CREATE TABLE IF NOT EXISTS `follow_up` ( `client_no` int(11) NOT NULL,  `visit_no` varchar(255) NOT NULL,  `visiting_date` date NOT NULL,  `use_status` varchar(255) NOT NULL,  `Treatment` varchar(255) DEFAULT NULL,  `contine_test` varchar(10) NOT NULL DEFAULT 'Not Done',  `CO_Level` varchar(255) DEFAULT NULL,  `diagnosis` varchar(10) DEFAULT NULL,  `gender` varchar(10) DEFAULT NULL,  `center_no` varchar(10) DEFAULT NULL,  `center_code` varchar(10) DEFAULT NULL, `slno` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `follow_up_status`; CREATE TABLE IF NOT EXISTS `follow_up_status` ( `client_no` int(11) NOT NULL,  `center_no` varchar(10) DEFAULT NULL,  `center_code` varchar(10) DEFAULT NULL,  `reg_date` date DEFAULT NULL,  `follow_date` date DEFAULT NULL,  `diagnosis` varchar(255) DEFAULT NULL,  `gender` varchar(255) NOT NULL,  `status` varchar(255) NOT NULL,  `detail` varchar(255) DEFAULT NULL,  PRIMARY KEY(`client_no`)) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `intake_register`; CREATE TABLE IF NOT EXISTS `intake_register` ( `client_no` int(11) NOT NULL AUTO_INCREMENT,  `center_no` varchar(255) NOT NULL,  `center_code` varchar(255) DEFAULT NULL,  `reg_date` date NOT NULL,  `client_name` varchar(255) NOT NULL,  `age` int(11) DEFAULT NULL,  `gender` varchar(10) DEFAULT 'Male',  `address` varchar(255) DEFAULT NULL,  `contact` varchar(255) DEFAULT NULL,  `alternatenumber` varchar(255) DEFAULT NULL,  `education` varchar(255) DEFAULT NULL,  `marital_status` varchar(255) DEFAULT NULL,  `occupation` varchar(255) DEFAULT NULL,  `referred_by` varchar(255) DEFAULT NULL,  `initcause` varchar(255) DEFAULT NULL,  `monthly_exp` int(11) DEFAULT NULL,  `alcohol_pattern` varchar(255) DEFAULT NULL,  `avgdrinking` varchar(255) DEFAULT NULL,  `quit_attempt` int(6) DEFAULT NULL,  `othersubstance` varchar(10) DEFAULT 'No',  `familihistorydtl` varchar(255) DEFAULT NULL,  `historysymptom` varchar(255) DEFAULT NULL,  `oralcavity` varchar(255) DEFAULT NULL,  `weight_phy` varchar(255) DEFAULT NULL,  `height_phy` varchar(255) DEFAULT NULL,  `pulse_rate` varchar(255) DEFAULT NULL,  `bpsystolic` varchar(255) DEFAULT NULL,  `diastolic` varchar(255) DEFAULT NULL,  `CO_analyst` varchar(10) DEFAULT 'Not Done',  `CO_level` varchar(255) DEFAULT NULL,  `treatment` varchar(255) DEFAULT NULL,  `otherremark` varchar(255) DEFAULT NULL,  `diagnosis_dtl` varchar(100) DEFAULT NULL,  PRIMARY KEY(`client_no`,`center_no`)) ENGINE = InnoDB AUTO_INCREMENT = 1 DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `intake_substance`; CREATE TABLE IF NOT EXISTS `intake_substance` ( `center_no` varchar(10) NOT NULL,  `center_code` varchar(10) NOT NULL,  `client_no` int(11) NOT NULL,  `details` varchar(255) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `phar_issue`; CREATE TABLE `phar_issue` (  `Client_No` int(11) NOT NULL,  `Issue_Date` date NOT NULL,  `Medicine` varchar(255) NOT NULL,  `exp_date` varchar(255) DEFAULT NULL,  `Quantity` int(11) NOT NULL,  `Batch_Detail` varchar(255) DEFAULT NULL,  `Remark` varchar(255) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `phar_stock`; CREATE TABLE `phar_stock` (  `ID` int(11) NOT NULL AUTO_INCREMENT,  `Stock_Date` date NOT NULL,  `Manufac_Date` varchar(255) DEFAULT '',  `Medicine_Name` varchar(255) NOT NULL,  `Exp_Date` varchar(255) NOT NULL,  `Quantity` int(11) NOT NULL,  `Price` decimal(10, 2) DEFAULT NULL,  `Batch_Detail` varchar(255) DEFAULT '',  `Medicine_Rating` tinyint(4) DEFAULT NULL,  `Remark` varchar(255) DEFAULT '',  PRIMARY KEY(`ID`)) ENGINE = InnoDB AUTO_INCREMENT = 01 DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `phy_problem`; CREATE TABLE `phy_problem` (  `client_no` int(11) NOT NULL,  `cough_sputum` varchar(10) DEFAULT NULL,  `dry_cough` varchar(10) DEFAULT NULL,  `sputum_blood` varchar(10) DEFAULT NULL,  `asthma` varchar(10) DEFAULT NULL,  `bronchitis` varchar(10) DEFAULT NULL,  `breathless` varchar(10) DEFAULT NULL,  `blood_stool` varchar(10) DEFAULT NULL,  `blood_vomit` varchar(10) DEFAULT NULL,  `constipation` varchar(10) DEFAULT NULL,  `dyspepsia` varchar(10) DEFAULT NULL,  `diarrhoea` varchar(10) DEFAULT NULL,  `vomiting` varchar(10) DEFAULT NULL,  `chest_pain` varchar(10) DEFAULT NULL,  `hypertension` varchar(10) DEFAULT NULL,  `myocardial` varchar(10) DEFAULT NULL,  `erythroplakia` varchar(10) DEFAULT NULL,  `leukoplakia` varchar(10) DEFAULT NULL,  `sub_mocous` varchar(10) DEFAULT NULL,  `mal_order` varchar(10) DEFAULT NULL,  `ulceration` varchar(10) DEFAULT NULL,  `dental_caries` varchar(10) DEFAULT NULL,  `staining_teeth` varchar(10) DEFAULT NULL,  `pain_gum` varchar(10) DEFAULT NULL,  `anxiety` varchar(10) DEFAULT NULL,  `depression` varchar(10) DEFAULT NULL,  `schizophrenia` varchar(10) DEFAULT NULL,  `other` varchar(10) DEFAULT NULL,  `cancer` varchar(10) DEFAULT NULL,  `diabetes` varchar(10) DEFAULT NULL,  `sexual` varchar(10) DEFAULT NULL,  `strock` varchar(10) DEFAULT NULL,  `seizure` varchar(10) DEFAULT NULL,  `tuberculosis` varchar(10) DEFAULT NULL,  `weight_gain` varchar(10) DEFAULT NULL,  `weight_loss` varchar(10) DEFAULT NULL,  PRIMARY KEY(`client_no`)) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `scale_smokeless`; CREATE TABLE IF NOT EXISTS `scale_smokeless` ( `centerno` varchar(10) DEFAULT NULL,  `centercode` varchar(10) DEFAULT NULL,  `client_no` int(255) NOT NULL,  `normal_sleep` varchar(255) DEFAULT NULL,  `sick_use` varchar(255) DEFAULT NULL,  `per_week` varchar(255) DEFAULT NULL,  `swallow` varchar(255) DEFAULT NULL,  `all_time` varchar(255) DEFAULT NULL,  `two_hour` varchar(255) DEFAULT NULL,  `score_total` int(11) DEFAULT NULL,  PRIMARY KEY(`client_no`)) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `scale_smoker`; CREATE TABLE IF NOT EXISTS `scale_smoker` ( `centerno` varchar(10) DEFAULT NULL,  `centercode` varchar(10) DEFAULT NULL,  `client_no` int(255) NOT NULL,  `how_soon` varchar(255) DEFAULT NULL,  `find_diff` varchar(255) DEFAULT NULL,  `hate_to_giveup` varchar(255) DEFAULT NULL,  `stay_in_bed` varchar(255) DEFAULT NULL,  `smoke_a_day` varchar(255) DEFAULT NULL,  `rest_a_day` varchar(255) DEFAULT NULL,  `score_total` int(11) DEFAULT NULL,  PRIMARY KEY(`client_no`)) ENGINE = InnoDB DEFAULT CHARSET = latin1; ", connection, trans);
                        command.ExecuteNonQuery();

                        command = new MySqlCommand("DROP TABLE IF EXISTS `subcomorbid`; CREATE TABLE `subcomorbid` (  `centerno` varchar(10) DEFAULT NULL,  `centercode` varchar(10) DEFAULT NULL,  `clientno` varchar(255) DEFAULT NULL,  `disorder` varchar(255) DEFAULT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1;", connection, trans);
                        command.ExecuteNonQuery();

                        //command = new MySqlCommand("ALTER TABLE `follow_up` ADD(`slno` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT); ", connection, trans);
                        //command.ExecuteNonQuery();

                        trans.Commit();

                        MessageBox.Show("Successfully completed!", "Done!");
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message, "Error"); trans.Rollback(); }
                    finally { connection.Close(); }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                EX_Button.Visible = false;
            }
            finally { connection.Close(); this.Close(); }
        }
    }
}

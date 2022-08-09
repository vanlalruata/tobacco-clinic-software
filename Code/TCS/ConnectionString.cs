using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


    
    public static class ConnectionString
    {
        //MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
        public static MySqlConnection connection = new MySqlConnection(string.Format("server={3};uid={0};pwd={1};database={2};", TCS.Properties.Settings.Default.dbUser, TCS.Properties.Settings.Default.dbPassword, TCS.Properties.Settings.Default.dbName, TCS.Properties.Settings.Default.dbServer));
        public static MySqlCommand command = new MySqlCommand();
        public static MySqlDataReader reader;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();


    public static bool t_use = false, substa = false, seve = false, phypr = false;

    public static StringBuilder scale_smoke = new StringBuilder();
    public static StringBuilder scale_smokeless = new StringBuilder();
    public static StringBuilder tobaccouse = new StringBuilder();    
    public static StringBuilder substancex = new StringBuilder();
    public static StringBuilder phyproblem = new StringBuilder();
    }


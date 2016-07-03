using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.OOP
{
    public class Database
    {
        public MySqlConnection baglanti;
        public MySqlCommand com;//varialbe for command


        public Database(){
            String connectionString = "Server=localhost; Port=3306; Database=mydb; Uid=root;";
            baglanti = new MySqlConnection(connectionString);
        }

        public void startDB(){

            if (baglanti != null && baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        public void stopDB()
        {
            if (baglanti != null && baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }

        }

        public MySqlCommand SqlCommand(string query)
        {
            startDB();
            var mySqlCommand = new MySqlCommand(query, baglanti);
            return mySqlCommand;
        }

        public DataTable GetData(string query)
        {
            startDB();
            var dataTable = new DataTable();
            var dataSet = new DataSet();
            var dataAdapter = new MySqlDataAdapter { SelectCommand = SqlCommand(query) };

            dataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }

        public bool Execute(MySqlCommand cmd)
        {
            startDB();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                    return true;
                else
                    return false;
            }
            catch(MySqlException ex)
            {
                return false;
                ex.ToString();
            }
        }


    



      


    }
}
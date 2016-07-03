using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.OOP
{
   
    public class Person
    {
        public int _ssn;
        public string _name;
        public string _surname;
        public int _age;
        public string _email;
        public string _phonenumber;
        public string _type;
        public string _password;
        Database db = new Database();

        public Person(int ssn, string name, string surname, int age, string email, string phonenumber, string type, string password)
        {
            this._ssn = ssn;
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._email = email;
            this._phonenumber = phonenumber;
            this._type = type;
            this._password = password;

        }

        public bool Register()
        {
            MySqlCommand cmd;
            try{
            string query = "INSERT INTO person (SSN,Name,Surname,Age,Email,PhoneNumber,Type,Password) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            cmd = db.SqlCommand(query);
            cmd.Parameters.AddWithValue("@param1", _ssn);
            cmd.Parameters.AddWithValue("@param2", _name);
            cmd.Parameters.AddWithValue("@param3", _surname);
            cmd.Parameters.AddWithValue("@param4", _age);
            cmd.Parameters.AddWithValue("@param5", _email);
            cmd.Parameters.AddWithValue("@param6", _phonenumber);
            cmd.Parameters.AddWithValue("@param7", _type);
            cmd.Parameters.AddWithValue("@param8", _password);
            bool result = db.Execute(cmd);
            if (result)
                return true;
            else
                return false;
            }
            catch{
                return false;
            }
        }




   }

    
}
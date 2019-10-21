using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace property_master.Models
{
    public class UserInfo 
    {

        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            
            return con; // return the created connection
        }

        public User getuser(string email)
        {
            User user = new User();
            var con = this.CreateConnection();
            string cmdText = $"select * from users where email LIKE '{email}'";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            var result = cmd.ExecuteReader();
         
            while(result.Read())
            {
                user.id = Convert.ToInt32(result["id"]);
                user.firstName = result["firstname"].ToString();
                user.lastName = result["lastname"].ToString();
                user.profile_photo = result["profile_photo"].ToString();
                user.email = result["email"].ToString();
                user.password = result["password"].ToString();
            }

            con.Close();
            return user;


        }








    }


}
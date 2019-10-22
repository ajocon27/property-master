using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
namespace property_master.Models
{
    public class PropertyInfo 
    {

        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            
            return con; // return the created connection
        }
        public List<Property> getproperty(string email)
        {
           
            User user=new User();
            var con = this.CreateConnection();
            var con2 = this.CreateConnection();
            var con3 = this.CreateConnection();
            string cmdText = $"select * from users where email='{email}'";
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
            
            
            List<Property> properties = new List<Property>();      
            string cmdText1 = $"select * from properties where user_id={user.id}";
            MySqlCommand cmd1 = new MySqlCommand(cmdText1, con2);
            var result1 = cmd1.ExecuteReader();
             
            while(result1.Read())
            {
                Property property = new Property();
                property.property_id = Convert.ToInt32(result1["property_id"]);
                property.photo_group_id = Convert.ToInt32(result1["photo_group_id"]);
                property.property_name = result1["property_name"].ToString();
                property.description = result1["description"].ToString();
              
                string cmdText2 = $"select * from photos where photo_group_id={ property.photo_group_id} and main=1 ";
                MySqlCommand cmd2 = new MySqlCommand(cmdText2, con3);
                var result2 = cmd2.ExecuteReader();
                while(result2.Read())
                {      
                    property.main_photo = result2["photo_url"].ToString();  
                }
                



                properties.Add(property);
            }
            con.Close();
            con2.Close();
            con3.Close();
            return properties;


        }

    }
}
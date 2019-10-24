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


                con3.Close();
                con3.Open();
                properties.Add(property);
            }
            con.Close();
            con2.Close();
           
            return properties;
        }
        public string getall(string id)
        {
            var con = this.CreateConnection();
            List<Property> properties = new List<Property>();
            string cmdText1 = $"select * from properties where user_id ="+id+" order by property_id DESC LIMIT 1";
            MySqlCommand cmd1 = new MySqlCommand(cmdText1, con);
            var result1 = cmd1.ExecuteReader();
            Property property = new Property();
            while (result1.Read())
            {
                
                property.property_id = Convert.ToInt32(result1["property_id"]);
            }

            return property.property_id.ToString();
        }

        public Property getpropertyview(string id)
        {
            var con = this.CreateConnection();
            Property property = new Property();
            string cmdText1 = $"select * from properties where property_id ="+id;
                       
            using (MySqlCommand cmd = new MySqlCommand(cmdText1, con))
            {
                var result1 = cmd.ExecuteReader();
                while (result1.Read())
                {
                            
                    property.property_id = Convert.ToInt32(result1["property_id"]);
                    property.property_name= Convert.ToString(result1["property_name"]);
                    property.price= Convert.ToDouble(result1["price"]);
                    property.address= Convert.ToString(result1["address"]);
                    property.city= Convert.ToString(result1["city"]);
                    property.province= Convert.ToString(result1["province"]);
                    property.land_size=Convert.ToDouble(result1["land_size"]);
                    property.likes= Convert.ToInt32(result1["likes"]);
                    property.description= Convert.ToString(result1["description"]);
                    property.bathroom= Convert.ToString(result1["bathrooms"]);
                    property.bedrooms= Convert.ToString(result1["bedrooms"]);
                    property.address2= Convert.ToString(result1["address2"]);
                    property.postalcode= Convert.ToString(result1["postalcode"]);
                    property.category= Convert.ToString(result1["category"]);
                    property.user_id= Convert.ToInt32(result1["user_id"]);

                }
                
            }
            string cmdText3 = $"select * from users where id ="+property.user_id.ToString();
                       
            using (MySqlCommand cmd = new MySqlCommand(cmdText3, con))
            {
                var result1 = cmd.ExecuteReader();
                User owner= new User();
                while (result1.Read())
                {
                        owner.id= Convert.ToInt32(result1["id"]);         
                        owner.firstName= Convert.ToString(result1["firstname"]);  
                        owner.lastName= Convert.ToString(result1["lastname"]);
                        owner.email= Convert.ToString(result1["email"]);
                }
                property.owner=owner;
                
            }

            string cmdText2 = $"select * from photos where photo_group_id ="+id;
            using (MySqlCommand cmd = new MySqlCommand(cmdText2, con))
            {
                  var result1 = cmd.ExecuteReader();
                List<Photo> photos= new List<Photo>();
                while (result1.Read())
                {
                    Photo p= new Photo();   
                    p.photo_url=Convert.ToString(result1["photo_url"]);
                    photos.Add(p);
                }
                property.photos=photos;
            }            

            return property;
        }
        public List<Property> getproperty()
        {
           
            User user=new User();
          
            var con2 = this.CreateConnection();
            var con3 = this.CreateConnection();
          
  
            
            List<Property> properties = new List<Property>();      
            string cmdText1 = $"select * from properties ORDER BY timestamp ASC";
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


                con3.Close();
                con3.Open();
                properties.Add(property);
            }
           
            con2.Close();
           
            return properties;
        }
        public List<Property> searchpropertybyprov(string province,double min,double max)
        {
           
            User user=new User();
          
            var con2 = this.CreateConnection();
            var con3 = this.CreateConnection();
            string cmdText1="";

            
            List<Property> properties = new List<Property>(); 

            if(province!=null )
            {
                 cmdText1 = $"select * from properties where province like '{province}' ORDER BY timestamp ASC";
               
            }
            else if(province=="Choose Province" && min!=0)
            {
                if(max==0)
                {
                    max=1000000;
                }
                 cmdText1 = $"select * from properties where price >= '{min}' and price <='{max}' ORDER BY timestamp ASC";
               
            }
            
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


                con3.Close();
                con3.Open();
                properties.Add(property);
            }
           
            con2.Close();
           
            return properties;
        }



     }
}
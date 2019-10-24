using System.Collections.Generic;
namespace property_master.Models
{
    public class Property
    {
            
        public int property_id {get; set;}
         public int user_id {get; set;}
        public string property_name {get; set;}
        public double price {get; set;}
        public string address {get; set;}
        public string city {get; set;}
        public string province {get; set;}   
        public double land_size {get; set;} 
        public int likes {get; set;} 
        public string description {get; set;} 
        public int photo_group_id {get; set;} 
        public string bathroom {get; set;} 
        public string bedrooms {get; set;}
        public string address2 {get; set;} 
        public string postalcode {get; set;} 
        public string category {get; set;} 
        public string main_photo {get; set;} 
         public List<Photo> photos {get; set;} 
         public User owner {get; set;}
    }

}
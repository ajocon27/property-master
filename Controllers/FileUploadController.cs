using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using property_master.Models;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace property_master.Controllers
{
    public class FileUploadController : Controller
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=property-master;user=root;password=1234;port=3306"; // declaring a connection string
            MySqlConnection con = new MySqlConnection(connection); // creating the connection
            con.Open(); // openning the connection
            return con; // return the created connection
        }
        [HttpPost]
        public IActionResult uploadfile(ICollection<IFormFile> file_data,int photogroupid)
        {   
            
            var con = this.CreateConnection();   
            string pictureUrl = null;

            UserInfo user = new UserInfo();
            var us = HttpContext.Session.GetString("user");
            ViewData["profile_photo"] = user.getuser(us).profile_photo;
            ViewData["firstname"] = user.getuser(us).firstName;
            ViewData["lastname"] = user.getuser(us).lastName;
            ViewData["email"] = user.getuser(us).email;
            ViewData["password"] = user.getuser(us).password;
            PropertyInfo properties= new PropertyInfo();
                

            
            string userid=user.getuser(us).id.ToString(); 

            string userlist="1";
            string dir="wwwroot/images/"+userid+"/"+userlist;
            ArrayList dir2 = new ArrayList();
            ArrayList initialPreview1  = new ArrayList();
            int i=0;
            int keys=1;
           
            int photogroup=photogroupid;
            string url;
  
            if(file_data!=null)
            {
 
                foreach(var p in file_data)
                {
                    
                    var fileName = Path.GetFileName(p.FileName);
                    Directory.CreateDirectory(dir);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @dir, fileName);
                    
                    var stream = new FileStream(filePath, FileMode.Create);
                    p.CopyTo(stream);
                    pictureUrl = dir + fileName;
                    //saving to JSON
                    dir2.Add("'https://localhost:5001/images/"+userid+"/"+userlist+"/"+fileName+"'");
                    url="https://localhost:5001/images/"+userid+"/"+userlist+"/"+fileName;
                    initialPreview1.Add("{caption: '"+fileName+"', downloadUrl: '"+dir2[i]+"', width: '120px', key: "+keys.ToString()+"}");
                    string cmdText = $"insert into photos(photo_name,photo_url,photo_group_id) values('{fileName}','{url}',{photogroup})";
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);

                    cmd.ExecuteNonQuery();

                    i++;
                    keys++;
                }
                
            }
            var initialPreviewConfig = JsonConvert.SerializeObject(initialPreview1);
           
            string initialPreview = string.Join(",", dir2);
          
            string test="initialPreview: ["+initialPreview+"],initialPreviewConfig: "+initialPreviewConfig+",initialPreviewThumbTags:{append: true}";
                         
            return Json(test);
        }
 
        
 
 
    }

}
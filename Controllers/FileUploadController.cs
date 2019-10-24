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
        public IActionResult uploadfile(ICollection<IFormFile> file_data,int photogroupid,int key)
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
            //get properties
            string userid=user.getuser(us).id.ToString();
            PropertyInfo properties= new PropertyInfo();
            int count=0;

            
             

            string userlist=properties.getall(userid);
            string dir="wwwroot/images/"+userid+"/"+userlist;
            ArrayList dir2 = new ArrayList();
            ArrayList initialPreview1  = new ArrayList();
            int i=0;
            int keys=1;
            
            int photogroup=photogroupid;
            string url;
            bool checkmain=false;
            string cmdText=null;
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
                    if(checkmain)
                    {
                         cmdText = $"update properties set photo_group_id='{photogroup}' where property_id={userlist}; insert into photos(photo_name,photo_url,photo_group_id,main) values('{fileName}','{url}',{photogroup},2); select COUNT(*) count from photos where photo_group_id='{photogroup} and main=1'";
                    }
                    else
                    {
                       cmdText = $"update properties set photo_group_id='{photogroup}' where property_id={userlist}; insert into photos(photo_name,photo_url,photo_group_id,main) values('{fileName}','{url}',{photogroup},1); select COUNT(*) count from photos where photo_group_id='{photogroup} and main=1'";
                    }
                    
                    using (MySqlCommand cmd = new MySqlCommand(cmdText, con))
                    {
                        var result1 = cmd.ExecuteReader();
                        while (result1.Read())
                        {
                                    
                           count = Convert.ToInt32(result1["count"]);
                        }

                    }


                   
                    if(count==1)
                    {
                       checkmain=true;        

                    }
                    i++;
                    keys++;
                }
                
            }
            var initialPreviewConfig = JsonConvert.SerializeObject(initialPreview1);
           
            string initialPreview = string.Join(",", dir2);
          
            string test="'{initialPreview: ["+initialPreview+"],initialPreviewConfig: "+initialPreviewConfig+",initialPreviewThumbTags:{append: true}'}";
                         
            return Json(test);
        }
         [HttpPost]
        public IActionResult filedelete()
        {   


            return View();
        }
 
 
    }

}
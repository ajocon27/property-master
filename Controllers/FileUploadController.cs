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

namespace property_master.Controllers
{
    public class FileUploadController : Controller
    {

        [HttpPost]
        public IActionResult uploadfile(ICollection<IFormFile> file_data)
        {   
            

            string pictureUrl = null;

            string userid="1";
            string userlist="1";
            string dir="wwwroot/images/"+userid+"/"+userlist;
            string dir2=null;
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
                    dir2="https://localhost:5001/images/"+userid+"/"+userlist+fileName;
                }
                
                

            }

            string test="initialPreview: ['"+dir2+"'],initialPreviewConfig: [{caption: 'test.jpg', downloadUrl: '"+dir2+"', width: '120px', key: 1}],initialPreviewThumbTags:{append: true}";
            // string test="{link':'<div class=\"alert alert-success\"><a class=\"btn btn-sm btn-success\" href=\"/uploads/resized.png\">Click here</a> to view / download your resized image file.</div>}";
                        
            return Json(test);
        }
 
        
 
 
    }

}
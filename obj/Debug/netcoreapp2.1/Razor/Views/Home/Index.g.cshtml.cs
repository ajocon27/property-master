#pragma checksum "D:\Documents\programs\property-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d071fa9c5ae108ad6b13ae59c36095a0f43eb13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Documents\programs\property-master\Views\_ViewImports.cshtml"
using property_master;

#line default
#line hidden
#line 2 "D:\Documents\programs\property-master\Views\_ViewImports.cshtml"
using property_master.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d071fa9c5ae108ad6b13ae59c36095a0f43eb13a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f430225ddc483c03fb52cf078286582e5b0931", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var properties = (List<Property>)ViewBag.list;

#line default
#line hidden
            BeginContext(97, 2265, true);
            WriteLiteral(@"          
<div class=""container"">
 <section class=""jumbotron text-center"" id=""section-bg"" style=""background-image: url('https://localhost:5001/images/Background.jpg');height: 100%;background-position: center;background-repeat: no-repeat;background-size: cover;"">
        <div class=""container"" style=height:70vh; "">
          <h1 class=""jumbotron-heading font-weight-bold"" style=""color:white;padding-top:7%;"">Search 312,922 listings from trusted Realtors</h1>
          <p class=""lead text-light"" ></p>
           
            <p>
             
              <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
                <label class=""btn btn-secondary active"" id=""residential"">
                  <input type=""radio"" name=""options"" id=""option1"" autocomplete=""off"" checked> Residential
                </label>
                <label class=""btn btn-secondary"" id=""commercial"">
                  <input type=""radio"" name=""options"" autocomplete=""off""> Commercial
                </label>
    ");
            WriteLiteral(@"
              </div>
            </p>

   <div class=""input-group mb-3"">
  
</div>

<div class=""input-group input-group-lg"">


  <select class=""custom-select col-6"" id=""inputGroupSelect01"" name=""province"">
    <option selected>Choose Province</option>
    <option value=""British Columbia"">British Columbia</option>
    <option value=""Manitoba"">Manitoba</option>
    <option value=""New Brunswick"">New Brunswick</option>
    <option value=""Ontario"">Ontario</option>
    <option value=""Saskatchewan"">Saskatchewan</option>
    <option value=""Quebec"">Quebec</option>
  </select>
  
    <input type=""text"" class=""form-control col-4"" placeholder=""Minimum Price"" aria-label="""" name=""minprice"" aria-describedby=""basic-addon1"">


    
  <input type=""text"" class=""form-control col-4"" placeholder=""Maximum Price"" aria-label="""" name=""maxprice"" aria-describedby=""basic-addon1"">  

  <div class=""input-group-append"">
    <button class=""btn btn-light"" type=""submit"">Search
      
    </button>
   
  </div>
");
            WriteLiteral("  \r\n</div>\r\n      \r\n        </div>\r\n      </section>\r\n</form>\r\n      <div class=\"album py-5 bg-light\">\r\n        <div class=\"container\">\r\n          <div>\r\n            \r\n          </div>\r\n\r\n          <div class=\"row\">\r\n");
            EndContext();
#line 67 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
             foreach (var p in properties)
            {
                
            

#line default
#line hidden
            BeginContext(2453, 127, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n              <div class=\"card mb-4 box-shadow\">\r\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2580, "\"", 2599, 1);
#line 73 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
WriteAttributeValue("", 2586, p.main_photo, 2586, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2600, 107, true);
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                   <h5 class=\"card-title\">");
            EndContext();
            BeginContext(2708, 15, false);
#line 75 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
                                     Write(p.property_name);

#line default
#line hidden
            EndContext();
            BeginContext(2723, 46, true);
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
            EndContext();
            BeginContext(2770, 13, false);
#line 76 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
                                  Write(p.description);

#line default
#line hidden
            EndContext();
            BeginContext(2783, 158, true);
            WriteLiteral("</p>\r\n                  <div class=\"d-flex justify-content-between align-items-center\">\r\n                    <div class=\"btn-group\">\r\n                      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2941, "\"", 2993, 2);
            WriteAttributeValue("", 2948, "home/view_property?property_id=", 2948, 31, true);
#line 79 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
WriteAttributeValue("", 2979, p.property_id, 2979, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2994, 113, true);
            WriteLiteral(" role=\"button\" class=\"btn btn-sm btn-outline-secondary\">View</a>\r\n                    \r\n                       <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3107, "\"", 3154, 2);
            WriteAttributeValue("", 3114, "view_property?property_id=", 3114, 26, true);
#line 81 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
WriteAttributeValue("", 3140, p.property_id, 3140, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3155, 209, true);
            WriteLiteral(" role=\"button\" class=\"btn btn-sm btn-outline-secondary\">Edit</a>\r\n                     \r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
            EndContext();
#line 88 "D:\Documents\programs\property-master\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3379, 683, true);
            WriteLiteral(@"          </div>
        </div>
      </div>

</div>
      <script>

     

          $(document).ready(function () {
            //your code here
            $('#commercial').on('click', function() {
                      $('#section-bg').css('background-image', 'url(/images/Background1.jpg)');
                 
                  });
                      $('#residential').on('click', function() {
                      $('#section-bg').css('background-image', 'url(/images/Background.jpg)');
                      
                  });
          });
     </script>
<style>
  .body-content {
    padding-left:0px;
    padding-right: 0px;
}


</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "c:\Users\Aj\Desktop\programs\property-master\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ee3b7cd149d4e792d0c84837a8f72ef747ec23"
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
#line 1 "c:\Users\Aj\Desktop\programs\property-master\Views\_ViewImports.cshtml"
using property_master;

#line default
#line hidden
#line 2 "c:\Users\Aj\Desktop\programs\property-master\Views\_ViewImports.cshtml"
using property_master.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ee3b7cd149d4e792d0c84837a8f72ef747ec23", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f430225ddc483c03fb52cf078286582e5b0931", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\Aj\Desktop\programs\property-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 11177, true);
            WriteLiteral(@"
 <section class=""jumbotron text-center"" id=""section-bg"" style=""background-image: url('images/Background.jpg');height: 100%;background-position: center;background-repeat: no-repeat;background-size: cover;"">
        <div class=""container"" style=height:70vh; "">
          <h1 class=""jumbotron-heading font-weight-bold"" style=""color:white;padding-top:7%;"">Search 312,922 listings from trusted Realtors</h1>
          <p class=""lead text-light"" ></p>
          <form>
            <p>
              <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
                <label class=""btn btn-secondary active"" id=""residential"">
                  <input type=""radio"" name=""options"" id=""option1"" autocomplete=""off"" checked> Residential
                </label>
                <label class=""btn btn-secondary"" id=""commercial"">
                  <input type=""radio"" name=""options"" autocomplete=""off""> Commercial
                </label>
    
              </div>
            </p>

   <div class=""input-grou");
            WriteLiteral(@"p mb-3"">
  
</div>
<div class=""input-group input-group-lg"">

  <select class=""custom-select col-4"" id=""inputGroupSelect01"">
    <option selected>Choose City </option>
    <option value=""1"">One</option>
    <option value=""2"">Two</option>
    <option value=""3"">Three</option>
  </select>
  <select class=""custom-select col-4"" id=""inputGroupSelect01"">
    <option selected>Choose Province</option>
    <option value=""1"">One</option>
    <option value=""2"">Two</option>
    <option value=""3"">Three</option>
  </select>
    <select class=""custom-select col-2"" id=""inputGroupSelect01"">
    <option selected>Min Price</option>
    <option value=""1"">One</option>
    <option value=""2"">Two</option>
    <option value=""3"">Three</option>
  </select>
      <select class=""custom-select col-2"" id=""inputGroupSelect01"">
    <option selected>Max Price</option>
    <option value=""1"">One</option>
    <option value=""2"">Two</option>
    <option value=""3"">Three</option>
  </select>
  <div class=""input-group-appen");
            WriteLiteral(@"d"">
    <button class=""btn btn-light"" type=""button"">Search
      
    </button>
    
  </div>
  
</div>
          </form>
        </div>
      </section>

      <div class=""album py-5 bg-light"">
        <div class=""container"">
          <div>
            
          </div>

          <div class=""row"">
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondar");
            WriteLiteral(@"y"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
             ");
            WriteLiteral(@"     </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>

            <div class=""col-md-4"">
    ");
            WriteLiteral(@"          <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""");
            WriteLiteral(@"Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card wi");
            WriteLiteral(@"th supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>

            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
        ");
            WriteLiteral(@"          <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
 ");
            WriteLiteral(@"                     <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 box-shadow"">
                <img class=""card-img-top"" src=""/images/Thumbnail.svg"" alt=""Card image cap"">
                <div class=""card-body"">
                  <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                  <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""btn-group"">
                      <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                      ");
            WriteLiteral(@"<button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    </div>
                    <small class=""text-muted"">9 mins</small>
                  </div>
                </div>
              </div>
            </div>
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

#pragma checksum "d:\Documents\programs\property-master\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc798a899d5379a190809bf337ffd6db75b7bcc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "d:\Documents\programs\property-master\Views\_ViewImports.cshtml"
using property_master;

#line default
#line hidden
#line 2 "d:\Documents\programs\property-master\Views\_ViewImports.cshtml"
using property_master.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc798a899d5379a190809bf337ffd6db75b7bcc9", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f430225ddc483c03fb52cf078286582e5b0931", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "d:\Documents\programs\property-master\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(43, 176, true);
            WriteLiteral("\r\n<div class=\"container mt-md-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-7 mx-auto my-3 p-3 bg-white rounded shadow-sm \">\r\n            <h2>Details</h2>\r\n           ");
            EndContext();
            BeginContext(219, 1380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b23688db6e431fbdf3a9ab6ab51f28", async() => {
                BeginContext(225, 1367, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">First Name</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder="""">
                    
                </div> 
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Last Name</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder="""">
                   
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Email address</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder="""">
                   
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputPassword1"" class=""float-left"">Password</label>
              ");
                WriteLiteral(@"      <a href=""""> <label for=""exampleInputPassword1"" class=""float-right"">Change Password</label></a>
                    <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"" readonly>
                </div>
 
                <button type=""submit"" class=""btn btn-primary"">Save</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1599, 263, true);
            WriteLiteral(@"

        </div>
        <div class=""col-md-5 mx-auto  mx-auto my-3 p-3 bg-white rounded shadow-sm"">
            <div class=""row mx-auto"">
                <div class=""col mt-md-5"">
                    <div class=""text-center "">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 1862, "\'", 1894, 1);
#line 39 "d:\Documents\programs\property-master\Views\Home\Profile.cshtml"
WriteAttributeValue("", 1868, ViewData["profile_photo"], 1868, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1895, 1153, true);
            WriteLiteral(@" class=""img-circle img-thumbnail rounded mx-auto"" alt=""avatar"">
                    </div>
                </div>
            </div>
            <div class=""row mx-auto"">
                <div class=""col mt-md-3"">
                    <div class=""text-center"">
                        <button type=""button"" id=""uploadButton"" class=""btn btn-outline-secondary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">Upload Profile Photo </button>       
                       
                    </div>
                </div>
            </div>  

        </div>

    </div>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Change Profile Photo</h5>
        <button type=""button"" class=""close"" data");
            WriteLiteral("-dismiss=\"modal\" aria-label=\"Close\">\r\n          <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n      </div>\r\n       ");
            EndContext();
            BeginContext(3048, 599, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72e4706d4abd4c1882c54340d77d2e4d", async() => {
                BeginContext(3090, 550, true);
                WriteLiteral(@"
      <div class=""modal-body"">
         
            <div class=""form-group"">
                <label for=""exampleFormControlFile1"">Choose a Photo</label>
                <<input type=""file"" class=""form-control"" name=""picture"" placeholder=""Picture"">
            </div>


           




      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""submit"" class=""btn btn-primary"">Save changes</button>
         
      </div>
      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3647, 30, true);
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>");
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

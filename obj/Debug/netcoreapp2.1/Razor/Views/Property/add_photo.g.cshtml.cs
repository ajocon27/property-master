#pragma checksum "d:\Documents\programs\property-master\Views\Property\add_photo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6c7b9395d43acc2961e48b4d750c45d921f3739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Property_add_photo), @"mvc.1.0.view", @"/Views/Property/add_photo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Property/add_photo.cshtml", typeof(AspNetCore.Views_Property_add_photo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c7b9395d43acc2961e48b4d750c45d921f3739", @"/Views/Property/add_photo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f430225ddc483c03fb52cf078286582e5b0931", @"/Views/_ViewImports.cshtml")]
    public class Views_Property_add_photo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "d:\Documents\programs\property-master\Views\Property\add_photo.cshtml"
  
    ViewData["Title"] = "Upload Photos";    
    



#line default
#line hidden
            BeginContext(63, 942, true);
            WriteLiteral(@"<div class=""container-fluid "">
          <div class=""row "">
            <div class=""col-md-10 mx-auto"">
                <div class=""card text-center"" style=""margin-top:5%;"">
                <div class=""card-header"">
                <h5 class=""card-title"">Add photos to attract interest to your ad</h5>
                </div>
                <div class=""card-body"">
                
                    
                        <div class=""row file"">
                           
                                <div class=""file-loading"">
                                    <input id=""input-fas-25"" type=""file"" multiple>
                                </div>
                            
                        </div>


                   
                    
                </div>
                </div>
            </div>
          </div>
</div>
<script>
$(document).ready(function() {
    var photo_group_id=");
            EndContext();
            BeginContext(1006, 26, false);
#line 35 "d:\Documents\programs\property-master\Views\Property\add_photo.cshtml"
                  Write(ViewData["photo_group_id"]);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 768, true);
            WriteLiteral(@";
 
    $(""#input-fas-25"").fileinput({
        theme:""fas"",
        uploadUrl: ""/FileUpload/uploadfile"",
        maxFileCount: 5,
        initialPreviewAsData: true,
        uploadAsync: false,
        deleteUrl: ""/site/file-delete"",
        overwriteInitial: true,
        maxFileSize: 500,
        uploadExtraData: {
            photogroupid: photo_group_id,
        } 
  
}).on('filebatchuploadsuccess', function(event, data) {
       var form = data.form, files = data.files, extra = data.extra,
        response = data.response, reader = data.reader;

});
$("".file"").find('.file-input').addClass( ""col "" );
  $("".file"").find('.file-preview').addClass( ""row "" );
 $("".file"").find('.file-drop-zone').addClass( ""col "" );
});




</script>");
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
#pragma checksum "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c48612f1a9144e87ba369f9fa10a74236ee767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
using WebUI.Dtos.ServicesDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c48612f1a9144e87ba369f9fa10a74236ee767", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultServiceDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Hizmet Başlagı </th>\r\n        <th>Sil </th>\r\n        <th>Güncelle </th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
                   Write(item.ServicesRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 515, "\"", 565, 2);
            WriteAttributeValue("", 522, "/Services/DeleteServices/", 522, 25, true);
#nullable restore
#line 21 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
WriteAttributeValue("", 547, item.ServicesRoom, 547, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 630, "\"", 680, 2);
            WriteAttributeValue("", 637, "/Services/UpdateServices/", 637, 25, true);
#nullable restore
#line 22 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
WriteAttributeValue("", 662, item.ServicesRoom, 662, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Güncelle</a></td>\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\90537\source\repos\OtelAPİ\FrontEnd\WebUI\Views\Services\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n\r\n<a href=\"/Services/AddService\" class=\"btn btn-danger\"></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultServiceDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

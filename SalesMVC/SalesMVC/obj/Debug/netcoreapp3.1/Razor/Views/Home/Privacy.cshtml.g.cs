#pragma checksum "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f851c7f755dc8c0cb39436766d3843be56d099de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\_ViewImports.cshtml"
using SalesMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\_ViewImports.cshtml"
using SalesMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f851c7f755dc8c0cb39436766d3843be56d099de", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5de553d9510b1c5870c51e43778d9d94769541", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 6 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml"
 for (int i = 0; i <= 60; i++)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <br><td>Number =  ");
#nullable restore
#line 9 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml"
                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 10 "H:\Desenvolvimento\_Codigo-Fonte\SalesWebMvc\SalesMVC\SalesMVC\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n");
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

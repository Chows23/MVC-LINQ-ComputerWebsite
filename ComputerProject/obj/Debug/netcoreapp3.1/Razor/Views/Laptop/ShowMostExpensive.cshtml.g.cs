#pragma checksum "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\Laptop\ShowMostExpensive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9dbdac136df7fcbb859efca97637537e462d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptop_ShowMostExpensive), @"mvc.1.0.view", @"/Views/Laptop/ShowMostExpensive.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\_ViewImports.cshtml"
using ComputerProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\_ViewImports.cshtml"
using ComputerProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9dbdac136df7fcbb859efca97637537e462d3d", @"/Views/Laptop/ShowMostExpensive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7265c228db0d06a761cf989af00cbf4f10161adc", @"/Views/_ViewImports.cshtml")]
    public class Views_Laptop_ShowMostExpensive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laptop>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>\r\n    Show most expensive laptop\r\n</h3>\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\Laptop\ShowMostExpensive.cshtml"
                          Write(Model.Brand.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Brand name</h6>\r\n        <p class=\"card-text\">Laptop Id: ");
#nullable restore
#line 12 "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\Laptop\ShowMostExpensive.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Price: ");
#nullable restore
#line 12 "C:\Users\USER\Desktop\BackEnd\MVC-LINQ\ComputerProject\ComputerProject\Views\Laptop\ShowMostExpensive.cshtml"
                                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$.</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laptop> Html { get; private set; }
    }
}
#pragma warning restore 1591

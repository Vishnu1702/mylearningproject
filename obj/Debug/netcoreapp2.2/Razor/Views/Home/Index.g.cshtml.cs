#pragma checksum "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c743c52046ca61546940b6ee1d490b6082e1e45"
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
#line 1 "/home/vishnu/mylearningproject/MaadiSweets/Views/_ViewImports.cshtml"
using MAADISWEETS;

#line default
#line hidden
#line 2 "/home/vishnu/mylearningproject/MaadiSweets/Views/_ViewImports.cshtml"
using MAADISWEETS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c743c52046ca61546940b6ee1d490b6082e1e45", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9834540fe6555a0edbae4bb6edf302d260fffdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MAADISWEETS.HomeViewModel.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 6, true);
            WriteLiteral("    \n\n");
            EndContext();
#line 4 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
      
        Layout = "_Layout";
    

#line default
#line hidden
            BeginContext(95, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(104, 11, false);
#line 7 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(115, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 9 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
     foreach (var sweet in Model.Sweets)
    {

#line default
#line hidden
            BeginContext(169, 179, true);
            WriteLiteral("        <div class=\"col-sm-4 col-lg-4 col-md-4\">\n\n            <div class =\"thumbnail\">\n                <img src=\" \">\n                <div class=\"caption\">\n                    <h3>");
            EndContext();
            BeginContext(349, 13, false);
#line 16 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
                   Write(sweet.SweetId);

#line default
#line hidden
            EndContext();
            BeginContext(362, 30, true);
            WriteLiteral("</h3>\n                    <h3>");
            EndContext();
            BeginContext(393, 15, false);
#line 17 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
                   Write(sweet.SweetName);

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("</h3>\n        </div>\n            </div>\n        </div>\n");
            EndContext();
#line 21 "/home/vishnu/mylearningproject/MaadiSweets/Views/Home/Index.cshtml"
        
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MAADISWEETS.HomeViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\SangFor.LHT\GitHub_Test\SangFor.LHT\WebCore.MVC.20210801\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9e3a2b396caec39857098be8c15f8288603f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebCore.MVC._20210801.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(WebCore.MVC._20210801.Pages.Pages_About), null)]
namespace WebCore.MVC._20210801.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\SangFor.LHT\GitHub_Test\SangFor.LHT\WebCore.MVC.20210801\Pages\_ViewImports.cshtml"
using WebCore.MVC._20210801;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9e3a2b396caec39857098be8c15f8288603f03", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab45a9da28749a3ab2dd44d933d490e3f0b9756", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\SangFor.LHT\GitHub_Test\SangFor.LHT\WebCore.MVC.20210801\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(67, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(72, 17, false);
#line 6 "D:\SangFor.LHT\GitHub_Test\SangFor.LHT\WebCore.MVC.20210801\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(89, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(101, 13, false);
#line 7 "D:\SangFor.LHT\GitHub_Test\SangFor.LHT\WebCore.MVC.20210801\Pages\About.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(114, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

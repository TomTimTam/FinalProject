#pragma checksum "/Users/thomas_cooper/RiderProjects/FinalProject/FinalProject/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61133aea0e4204e1897f3b5e3582113828f629b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(FinalProject.Pages.Pages_Index), null)]
namespace FinalProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/thomas_cooper/RiderProjects/FinalProject/FinalProject/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/thomas_cooper/RiderProjects/FinalProject/FinalProject/Pages/_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 3 "/Users/thomas_cooper/RiderProjects/FinalProject/FinalProject/Pages/_ViewImports.cshtml"
using FinalProject.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61133aea0e4204e1897f3b5e3582113828f629b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ab4760238798a72044cda7e6e8384a7f699293", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/thomas_cooper/RiderProjects/FinalProject/FinalProject/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 459, true);
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-md-3"">
        <h2>Second</h2>
    </div>
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core Razor Pages</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
</div>
<div class=""row>"">
    <div class=""col-md-3"">
        <h2>First
           </h2>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

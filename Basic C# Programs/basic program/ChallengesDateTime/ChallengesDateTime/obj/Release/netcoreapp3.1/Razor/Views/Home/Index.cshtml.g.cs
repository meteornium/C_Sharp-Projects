#pragma checksum "C:\Users\adamk\Documents\GitHub\C_Sharp_TTA_Projects\Basic C# Programs\basic program\ChallengesDateTime\ChallengesDateTime\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1365e3829012d06289be04d4f826917f675ef106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\adamk\Documents\GitHub\C_Sharp_TTA_Projects\Basic C# Programs\basic program\ChallengesDateTime\ChallengesDateTime\Views\_ViewImports.cshtml"
using ChallengesDateTime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\adamk\Documents\GitHub\C_Sharp_TTA_Projects\Basic C# Programs\basic program\ChallengesDateTime\ChallengesDateTime\Views\Home\Index.cshtml"
using ChallengesDateTime.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1365e3829012d06289be04d4f826917f675ef106", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb962979be885397d9f96913d1de7983223b9b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<currentTimes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""jumbotron"">
    <div class=""row no-gutters m-3"">
        <div class=""card-header text-center"">
            <h2 class=""m-1"">Current Time OnLoad:</h2>
        </div>
        <div class=""card-body"">
            <div class=""col"">
                <h4 class=""text-center"">");
#nullable restore
#line 11 "C:\Users\adamk\Documents\GitHub\C_Sharp_TTA_Projects\Basic C# Programs\basic program\ChallengesDateTime\ChallengesDateTime\Views\Home\Index.cshtml"
                                   Write(Model.TheTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<currentTimes> Html { get; private set; }
    }
}
#pragma warning restore 1591

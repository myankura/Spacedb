#pragma checksum "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67f65950e55338cd1cc4d1d81eab8395690d9e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Launches_Index), @"mvc.1.0.view", @"/Views/Launches/Index.cshtml")]
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
#line 1 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\_ViewImports.cshtml"
using Spacedb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\_ViewImports.cshtml"
using Spacedb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\_ViewImports.cshtml"
using Spacedb.BusinessLogic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67f65950e55338cd1cc4d1d81eab8395690d9e1", @"/Views/Launches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebaa87209fa915af1bfb24d5f06d79e50a518229", @"/Views/_ViewImports.cshtml")]
    public class Views_Launches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
  
    ViewData["Title"] = "Launches";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    #launchTable {\r\n        font-size: 14pt;\r\n        text-align: center;\r\n        box-shadow: 5px 5px 20px #808080;\r\n    }\r\n\r\n        #launchTable th {\r\n            background-color: blue;\r\n            color: white;\r\n        }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67f65950e55338cd1cc4d1d81eab8395690d9e13697", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Space.db</h1>
    </div>
    <div>
        <h3>All Launches</h3>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-striped table-bordered table-sm"" id=""launchTable"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th class=""th-md"" style=""text-align: center"">Mission Patch</th>
                        <th class=""th-md"" style=""text-align: center"">Launch Window</th>
                        <!--<th class=""th-md"" style=""text-align: center"">Launch Time</th>-->
                        <th class=""th-md"" style=""text-align: center"">Mission</th>
                        <th class=""th-md"" style=""text-align: center"">Rocket Name</th>
                        <th class=""th-md"" style=""text-align: center"">Success</th>
                        <th class=""th-md"" style=""text-align: center"">Payload Mass</th>
                        <th class=""th-md"" style=""text-");
                WriteLiteral("align: center\">Launchpad</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                     for (var i = (ViewBag.launchDetails.Count - 1); i >= 0; i--)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 44 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                         if (ViewBag.launchDetails[i].SmallPatchUrl != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td style=\"vertical-align: middle\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1765, "\"", 1820, 1);
#nullable restore
#line 47 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
WriteAttributeValue("", 1771, Html.Raw(ViewBag.launchDetails[i].SmallPatchUrl), 1771, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1821, "\"", 1827, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"100\">\r\n                        </td>\r\n");
#nullable restore
#line 49 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td><!--API returned null.--></td>\r\n");
#nullable restore
#line 53 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(Formatters.LaunchWindowFormatter(ViewBag.launchDetails[i].Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 58 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(ViewBag.launchDetails[i].MissionName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(ViewBag.launchDetails[i].Rocket);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(Formatters.LaunchOutcomeFormatter(ViewBag.launchDetails[i].LaunchOutcome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(Formatters.PayloadFormatter(@ViewBag.launchDetails[i].PayloadWeight));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle\">\r\n                            ");
#nullable restore
#line 70 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                       Write(Formatters.LaunchpadFormatter(ViewBag.launchDetails[i].Launchpad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Mike\source\repos\Spacedb\Spacedb\Views\Launches\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <!--<th></th>-->
                    </tr>
                </tfoot>
            </table>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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

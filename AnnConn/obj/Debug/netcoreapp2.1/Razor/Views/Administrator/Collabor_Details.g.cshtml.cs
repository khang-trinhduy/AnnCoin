#pragma checksum "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c7fa08eebd2820d82cc46dac71a1bce7580a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Collabor_Details), @"mvc.1.0.view", @"/Views/Administrator/Collabor_Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/Collabor_Details.cshtml", typeof(AspNetCore.Views_Administrator_Collabor_Details))]
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
#line 1 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\_ViewImports.cshtml"
using AnnConn;

#line default
#line hidden
#line 2 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\_ViewImports.cshtml"
using AnnConn.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c7fa08eebd2820d82cc46dac71a1bce7580a03", @"/Views/Administrator/Collabor_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a4701c150d83101e6b3825f6b672c5f37eeb4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Collabor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnnConn.Models.Collaborators>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Collabor_Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Collaborators", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
  
    ViewData["Title"] = "Collabor";

#line default
#line hidden
            BeginContext(83, 128, true);
            WriteLiteral("\r\n<h2>Collabor</h2>\r\n\r\n<div>\r\n    <h4>Collaborators</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(212, 41, false);
#line 14 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(297, 37, false);
#line 17 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(334, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Họ & tên\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(429, 40, false);
#line 23 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.fullName));

#line default
#line hidden
            EndContext();
            BeginContext(469, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Password\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(564, 40, false);
#line 29 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(604, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            TT hiển thị\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 38, false);
#line 35 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.office));

#line default
#line hidden
            EndContext();
            BeginContext(740, 104, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Thời gian gia nhập\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 40, false);
#line 41 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.joinDate));

#line default
#line hidden
            EndContext();
            BeginContext(885, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Giới tính\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(981, 38, false);
#line 47 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.gender));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Ngày sinh\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1114, 40, false);
#line 53 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            CMND/TCC/HC\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1252, 36, false);
#line 59 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.cmnd));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nơi cấp\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1382, 37, false);
#line 65 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.place));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Ngày cấp\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1514, 35, false);
#line 71 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.day));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Tên CTy\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1643, 43, false);
#line 77 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.office_name));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Lĩnh vực\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1780, 37, false);
#line 83 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.field));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Vị trí\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1909, 40, false);
#line 89 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.position));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Số nhà\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2042, 37, false);
#line 95 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.house));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n           Quốc gia\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2173, 38, false);
#line 101 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.nation));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Thành phố\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2307, 36, false);
#line 107 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.city));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Quận/Huyện\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2440, 40, false);
#line 113 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.district));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Phường/Xã\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2576, 36, false);
#line 119 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.town));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Mã bưu điện\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2710, 35, false);
#line 125 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.zip));

#line default
#line hidden
            EndContext();
            BeginContext(2745, 89, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            SĐT\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2835, 37, false);
#line 131 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Chính sách\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2969, 38, false);
#line 137 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
       Write(Html.DisplayFor(model => model.policy));

#line default
#line hidden
            EndContext();
            BeginContext(3007, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3054, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f52eda6635414c08983b62cd371741ce", async() => {
                BeginContext(3109, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 142 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\Collabor_Details.cshtml"
                                    WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3117, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3125, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8296acda7a8426b98101b0b20e300f3", async() => {
                BeginContext(3155, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3171, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnnConn.Models.Collaborators> Html { get; private set; }
    }
}
#pragma warning restore 1591
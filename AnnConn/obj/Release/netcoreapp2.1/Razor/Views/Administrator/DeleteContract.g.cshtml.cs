#pragma checksum "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5902be87039aef845cea4ee0c18827e681a91720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_DeleteContract), @"mvc.1.0.view", @"/Views/Administrator/DeleteContract.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrator/DeleteContract.cshtml", typeof(AspNetCore.Views_Administrator_DeleteContract))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5902be87039aef845cea4ee0c18827e681a91720", @"/Views/Administrator/DeleteContract.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a4701c150d83101e6b3825f6b672c5f37eeb4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_DeleteContract : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnnConn.Models.Contracts>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contract", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Contracts</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(248, 44, false);
#line 15 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.collabor));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 40, false);
#line 18 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.collabor));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 41, false);
#line 21 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.pDate));

#line default
#line hidden
            EndContext();
            BeginContext(461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(505, 37, false);
#line 24 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.pDate));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 44, false);
#line 27 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.customer));

#line default
#line hidden
            EndContext();
            BeginContext(630, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(674, 40, false);
#line 30 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.customer));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(758, 41, false);
#line 33 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(799, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(843, 37, false);
#line 36 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(880, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(924, 41, false);
#line 39 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1009, 37, false);
#line 42 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1090, 40, false);
#line 45 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1174, 36, false);
#line 48 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1254, 45, false);
#line 51 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.condition));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1343, 41, false);
#line 54 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.condition));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1428, 38, false);
#line 57 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.s1));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1510, 34, false);
#line 60 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.s1));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1588, 38, false);
#line 63 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.d1));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1670, 34, false);
#line 66 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.d1));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1748, 38, false);
#line 69 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.f1));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1830, 34, false);
#line 72 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.f1));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1908, 40, false);
#line 75 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.day1));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1992, 36, false);
#line 78 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.day1));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2072, 38, false);
#line 81 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.r1));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2154, 34, false);
#line 84 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.r1));

#line default
#line hidden
            EndContext();
            BeginContext(2188, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2232, 39, false);
#line 87 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.dl1));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2315, 35, false);
#line 90 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.dl1));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2394, 38, false);
#line 93 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.c1));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2476, 34, false);
#line 96 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.c1));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2554, 38, false);
#line 99 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.s2));

#line default
#line hidden
            EndContext();
            BeginContext(2592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2636, 34, false);
#line 102 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.s2));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2714, 38, false);
#line 105 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.d2));

#line default
#line hidden
            EndContext();
            BeginContext(2752, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2796, 34, false);
#line 108 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.d2));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2874, 38, false);
#line 111 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.f2));

#line default
#line hidden
            EndContext();
            BeginContext(2912, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2956, 34, false);
#line 114 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.f2));

#line default
#line hidden
            EndContext();
            BeginContext(2990, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3034, 40, false);
#line 117 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.day2));

#line default
#line hidden
            EndContext();
            BeginContext(3074, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3118, 36, false);
#line 120 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.day2));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3198, 38, false);
#line 123 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.r2));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3280, 34, false);
#line 126 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.r2));

#line default
#line hidden
            EndContext();
            BeginContext(3314, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3358, 39, false);
#line 129 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.dl2));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3441, 35, false);
#line 132 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.dl2));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3520, 38, false);
#line 135 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.c2));

#line default
#line hidden
            EndContext();
            BeginContext(3558, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3602, 34, false);
#line 138 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.c2));

#line default
#line hidden
            EndContext();
            BeginContext(3636, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3680, 38, false);
#line 141 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.s3));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3762, 34, false);
#line 144 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.s3));

#line default
#line hidden
            EndContext();
            BeginContext(3796, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3840, 38, false);
#line 147 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.d3));

#line default
#line hidden
            EndContext();
            BeginContext(3878, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3922, 34, false);
#line 150 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.d3));

#line default
#line hidden
            EndContext();
            BeginContext(3956, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4000, 38, false);
#line 153 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.f3));

#line default
#line hidden
            EndContext();
            BeginContext(4038, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4082, 34, false);
#line 156 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.f3));

#line default
#line hidden
            EndContext();
            BeginContext(4116, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4160, 40, false);
#line 159 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.day3));

#line default
#line hidden
            EndContext();
            BeginContext(4200, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4244, 36, false);
#line 162 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.day3));

#line default
#line hidden
            EndContext();
            BeginContext(4280, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4324, 38, false);
#line 165 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.r3));

#line default
#line hidden
            EndContext();
            BeginContext(4362, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4406, 34, false);
#line 168 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.r3));

#line default
#line hidden
            EndContext();
            BeginContext(4440, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4484, 39, false);
#line 171 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.dl3));

#line default
#line hidden
            EndContext();
            BeginContext(4523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4567, 35, false);
#line 174 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.dl3));

#line default
#line hidden
            EndContext();
            BeginContext(4602, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4646, 38, false);
#line 177 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayNameFor(model => model.c3));

#line default
#line hidden
            EndContext();
            BeginContext(4684, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4728, 34, false);
#line 180 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
       Write(Html.DisplayFor(model => model.c3));

#line default
#line hidden
            EndContext();
            BeginContext(4762, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(4796, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc109a9259be4bea8399cbdaf7295e15", async() => {
                BeginContext(4822, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4832, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2a7abf350cc48cda74bcd6102846aac", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 185 "C:\Users\trinh\source\repos\AnnConn\AnnConn\Views\Administrator\DeleteContract.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4868, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4952, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a3aec45979485aa51901538ccd6ae2", async() => {
                    BeginContext(4977, 12, true);
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
                BeginContext(4993, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5006, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnnConn.Models.Contracts> Html { get; private set; }
    }
}
#pragma warning restore 1591

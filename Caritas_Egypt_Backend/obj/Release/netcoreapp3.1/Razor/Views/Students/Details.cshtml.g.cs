#pragma checksum "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d87b760d97714453ae61a1aaeebe47b1196463f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
#line 1 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\_ViewImports.cshtml"
using Caritas_Egypt_Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\_ViewImports.cshtml"
using Caritas_Egypt_Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d87b760d97714453ae61a1aaeebe47b1196463f", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39892519cab7587322e3b609830679f099ad0539", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Caritas_Egypt_Backend.Models.Student>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceCardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.ServiceCardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NationalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.NationalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InSchool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.InSchool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SchoolName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SchoolName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SchoolYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SchoolYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GotAJobPlacement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.GotAJobPlacement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JopType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.JopType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JopPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.JopPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JopAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.JopAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n      \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d87b760d97714453ae61a1aaeebe47b1196463f13462", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 102 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Students\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d87b760d97714453ae61a1aaeebe47b1196463f15613", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Caritas_Egypt_Backend.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d8fb4186052842b64a2274eebf47baa0ad4227"
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
#nullable restore
#line 1 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d8fb4186052842b64a2274eebf47baa0ad4227", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39892519cab7587322e3b609830679f099ad0539", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								<div class=""card card-custom"">
									<div class=""card-header flex-wrap border-0 pt-6 pb-0"">
										<div class=""card-title"">
										</div>
									</div>
									<div class=""card-body"">
										<!--begin: Search Form-->
										<!--begin: Datatable-->
");
            WriteLiteral("\t\t\t<a href=\"/Users/index\" class=\"btn btn-primary btn-lg btn-block\">Users</a>\r\n");
            WriteLiteral(@"			<a href=""/CoursePrices/Index"" class=""btn btn-primary btn-lg btn-block"">Course Prices</a>
			<a href=""/Languages/Index"" class=""btn btn-primary btn-lg btn-block"">Languages</a>
			<a href=""/SessionTimes/Index"" class=""btn btn-primary btn-lg btn-block"">Session Times </a>
			<a href=""/Branches/Index"" class=""btn btn-primary btn-lg btn-block"">Branch</a>
			<a  href=""/Services/Index"" class=""btn btn-success btn-lg btn-block"">Services</a>
			<a  href=""/ServiceTypes/Index"" class=""btn btn-success btn-lg btn-block"">Service Types</a>
");
            WriteLiteral("<a href=\"/TypeOfDisabilities/Index\" class=\"btn btn-primary btn-lg btn-block\">Type Of Disabilities</a>\r\n<a href=\"/StudentNationalities/Index\" class=\"btn btn-success btn-lg btn-block\">Student Nationalities</a>\r\n");
            WriteLiteral("<a href=\"/Trainers/Index\" class=\"btn btn-primary btn-lg btn-block\">Trainers</a>\r\n<a href=\"/Students/Index\" class=\"btn btn-success btn-lg btn-block\">Students</a>\r\n");
            WriteLiteral("\r\n\t </div>\r\n\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

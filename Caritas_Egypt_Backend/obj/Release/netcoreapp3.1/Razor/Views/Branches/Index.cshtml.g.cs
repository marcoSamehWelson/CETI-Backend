#pragma checksum "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33a528ef7029a996daff0272ec848edf66b45cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a528ef7029a996daff0272ec848edf66b45cd5", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39892519cab7587322e3b609830679f099ad0539", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Caritas_Egypt_Backend.Models.Branch>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex; gap:8px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info font-weight-bolder font-size-sm mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--begin::Row-->
								<div class=""row"">
									<div class=""col-lg-12 col-xxl-12"">
										<!--begin::Advance Table Widget 9-->
										<div class=""card card-custom card-stretch gutter-b"">
											<!--begin::Header-->
											<div class=""card-header border-0 py-5"">
												<h3 class=""card-title align-items-start flex-column"">
													<span class=""card-label font-weight-bolder text-dark"">Branches</span>
													<span class=""text-muted mt-3 font-weight-bold font-size-sm""></span>
												</h3>
												<div class=""card-toolbar"" style=""gap: 8px"">
													  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a528ef7029a996daff0272ec848edf66b45cd56040", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 881, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"submit\" value=\"Search\" class=\"btn btn-info font-weight-bolder font-size-sm w-100\" />\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a528ef7029a996daff0272ec848edf66b45cd58153", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
												</div>
											</div>
											<!--end::Header-->
											<!--begin::Body-->
											<div class=""card-body pt-0 pb-3"">
												<div class=""tab-content"">
													<!--begin::Table-->
													<div class=""table-responsive"">
														<table class=""table table-head-custom table-vertical-center table-head-bg table-borderless"">
															<thead>
																<tr class=""text-left"">
																	<th style=""min-width: 250px"" class=""pl-7"">
																		<span class=""text-dark-75"">الاسم </span>
																	</th>																	
                                                                   <th> </th>
																</tr>
															</thead>
	                                                       	<tbody>
");
#nullable restore
#line 42 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
                                                                     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                       <tr>
                                                                         <td class=""pl-0 py-0"">
		                                                             	  <span class=""text-dark-75 font-weight-bolder d-block font-size-lg"">");
#nullable restore
#line 45 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
                                                                                                                                         Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                         </td>
    
                                                                         <td class=""pl-0 py-2"">
               
               
				<a class=""btn btn-info font-weight-bolder font-size-sm w-100""");
            BeginWriteAttribute("href", " href=\"", 2656, "\"", 2689, 2);
            WriteAttributeValue("", 2663, "/Branches/Edit?id=", 2663, 18, true);
#nullable restore
#line 51 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
WriteAttributeValue("", 2681, item.Id, 2681, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\t\t\t\t<a class=\"btn btn-info font-weight-bolder font-size-sm w-100 mt-2\"");
            BeginWriteAttribute("href", " href=\"", 2771, "\"", 2807, 2);
            WriteAttributeValue("", 2778, "/Branches/Details?id=", 2778, 21, true);
#nullable restore
#line 52 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
WriteAttributeValue("", 2799, item.Id, 2799, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n\t\t\t\t<a class=\"btn btn-danger font-weight-bolder font-size-sm w-100 mt-2\"");
            BeginWriteAttribute("href", " href=\"", 2894, "\"", 2929, 2);
            WriteAttributeValue("", 2901, "/Branches/Delete?id=", 2901, 20, true);
#nullable restore
#line 53 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
WriteAttributeValue("", 2921, item.Id, 2921, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n                                                                       </tr>\r\n");
#nullable restore
#line 56 "D:\Marco\CETI_Backend\CETI-Backend\Caritas_Egypt_Backend\Views\Branches\Index.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </tbody>
														</table>
													</div>
													<!--end::Table-->
												</div>
											</div>
											<!--end::Body-->
										</div>
										<!--end::Advance Table Widget 9-->
									</div>
								</div>
								<!--end::Row-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Caritas_Egypt_Backend.Models.Branch>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02929eee40510fe2772c69ed2ffed7e7d51cca66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\_ViewImports.cshtml"
using Caritas_Egypt_Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\_ViewImports.cshtml"
using Caritas_Egypt_Backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02929eee40510fe2772c69ed2ffed7e7d51cca66", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39892519cab7587322e3b609830679f099ad0539", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Caritas_Egypt_Backend.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info font-weight-bolder font-size-sm mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info font-weight-bolder font-size-sm w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info font-weight-bolder font-size-sm w-100 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger font-weight-bolder font-size-sm w-100 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<!--begin::Row-->
								<div class=""row"">
									<div class=""col-lg-12 col-xxl-12"">
										<!--begin::Advance Table Widget 9-->
										<div class=""card card-custom card-stretch gutter-b"">
											<!--begin::Header-->
											<div class=""card-header border-0 py-5"">
												<h3 class=""card-title align-items-start flex-column"">
													<span class=""card-label font-weight-bolder text-dark"">Students</span>
													<span class=""text-muted mt-3 font-weight-bold font-size-sm""></span>
												</h3>
												<div class=""card-toolbar"">
													    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02929eee40510fe2772c69ed2ffed7e7d51cca666919", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n");
            WriteLiteral(@"												</div>
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
																	<th >
																		<span class=""text-dark-75"">");
#nullable restore
#line 41 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                                              Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t <th> ");
#nullable restore
#line 43 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>");
#nullable restore
#line 44 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n          <th> ");
#nullable restore
#line 45 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
          Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th> ");
#nullable restore
#line 46 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.NationalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>  ");
#nullable restore
#line 47 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
             Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n       \r\n            <th> ");
#nullable restore
#line 49 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.JopType));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>");
#nullable restore
#line 50 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JopPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n            <th>");
#nullable restore
#line 51 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JopAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th> ");
#nullable restore
#line 52 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
            Write(Html.DisplayNameFor(model => model.TypeOfDisability));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th></th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 57 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 60 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\"> ");
#nullable restore
#line 63 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\"> ");
#nullable restore
#line 66 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n      \r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 70 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 73 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.NationalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 76 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n       \r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 80 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.JopType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 83 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.JopPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 86 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.JopAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n         \r\n            <td class=\"pl-0 py-0\">\r\n\t\t\t\t<span class=\"text-dark-75 font-weight-bolder d-block font-size-lg\">");
#nullable restore
#line 90 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                              Write(Html.DisplayFor(modelItem => item.TypeOfDisability.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n            <td class=\"pl-0 py-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02929eee40510fe2772c69ed2ffed7e7d51cca6617577", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                                                  WriteLiteral(item.ID);

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
            WriteLiteral(" \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02929eee40510fe2772c69ed2ffed7e7d51cca6619910", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                                                          WriteLiteral(item.ID);

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
            WriteLiteral(" \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02929eee40510fe2772c69ed2ffed7e7d51cca6622254", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
                                                                                                           WriteLiteral(item.ID);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 98 "C:\Users\MarcoWelson\source\Marco\Caritas_Egypt_Backend\Caritas_Egypt_Backend\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
														
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
								<!--end::Row-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Caritas_Egypt_Backend.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591

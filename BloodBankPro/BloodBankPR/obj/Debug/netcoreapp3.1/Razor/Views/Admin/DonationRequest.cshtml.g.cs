#pragma checksum "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DonationRequest), @"mvc.1.0.view", @"/Views/Admin/DonationRequest.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\_ViewImports.cshtml"
using BloodBankPR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\_ViewImports.cshtml"
using BloodBankPR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb70", @"/Views/Admin/DonationRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c60ce5c37d0c480b2f35d565a956f04fffeb26ec020110bba8c4c30cf5518f9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_DonationRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BloodBankPR.Models.DonationRequestDetails>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DonationRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-material"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Donations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn waves-effect waves-light btn-primary btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
  
    Layout = "_LayoutAdmin";
    var list = ViewBag.book as List<BloodBankPR.Models.Book>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""pcoded-content"">
    <div class=""page-header"">
        <div class=""page-block"">
            <div class=""row align-items-center"">
                <div class=""col-md-8"">
                    <div class=""page-header-title"">
                        <h5 class=""m-b-10"">Blood Dontion Request </h5>
                        <p class=""m-b-0"">Display All Donation Request</p>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <ul class=""breadcrumb-title"">
                        <li class=""breadcrumb-item"">
                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb706220", async() => {
                WriteLiteral(" <i class=\"fa fa-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </li>\n                        <li class=\"breadcrumb-item\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb707536", async() => {
                WriteLiteral("Donation Request");
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
            WriteLiteral(@"
                        </li>
                        <li class=""breadcrumb-item"">

                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class=""pcoded-inner-content"">
        <!-- Main-body start -->
        <div class=""main-body"">
            <div class=""page-wrapper"">
                <!-- Page-body start -->
                <div class=""page-body"">
                    <div class=""card"">
                        <h5 style=""margin:5px;"">Filltering Donation Request</h5>
                        <div class=""card-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb709368", async() => {
                WriteLiteral(@"
                                <div class=""form-group form-default col-3"" style=""display:inline-block;"">
                                    <label class=""float-label"" style=""margin-left:5px;"">Reqester Name</label>
                                    <input type=""text"" name=""reqName"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 1940, "\"", 1951, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <span class=""form-bar""></span>

                                </div>
                                <div class=""form-group form-default col-3"" style=""display:inline-block;"">
                                    <label class=""float-label"" style=""margin-left:5px;"">Required Quantity</label>
                                    <input type=""number"" name=""qnt"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 2369, "\"", 2380, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <span class=""form-bar""></span>

                                </div>
                                <div class=""form-group form-default col-3"" style=""display:inline-block;"">


                                    <div class=""col-sm-12"">
                                        <label class=""float-label"" style=""margin-left:5px;"">Required Book</label>
                                        <input type=""number"" name=""BookName"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 2869, "\"", 2880, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <span class=""form-bar""></span>
                                        
                                    </div>

                                </div>
                                <button type=""submit"" class=""btn btn-info btn-round waves-effect waves-light col-2"">Search</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                    <!-- Basic table card start -->
                    <div class=""card"">
                        <div class=""card-header"">

                                <div class=""card-header-right"">
                                    <ul class=""list-unstyled card-option"">
                                        <li><i class=""fa fa fa-wrench open-card-option""></i></li>
                                        <li><i class=""fa fa-window-maximize full-card""></i></li>
                                        <li><i class=""fa fa-minus minimize-card""></i></li>
                                        <li><i class=""fa fa-refresh reload-card""></i></li>
");
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""card-block table-border-style"">
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>Id</th>
                                                <th>Requester Name</th>
                                                <th>RequiredUnit</th>
                                                <th>BloodType</th>
                                                <th>Donation End At</th>
                                                <th>Details</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 97 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
                                         foreach(var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                                <th scope=\"row\">");
#nullable restore
#line 100 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
                                                           Write(item.DonationRequests.Book);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                <td>");
#nullable restore
#line 101 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
                                               Write(item.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                
                                              
                                                
                                                <td>
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1f49077c8ac654339bc7d8a85b1dd2e617faa0e4fe047ef5075243e16ffb7015886", async() => {
                WriteLiteral("<i class=\"icofont icofont-eye-alt\"></i>Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
                                                                                WriteLiteral(item.DonationRequests.Book);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                </td>\n                                            </tr>\n");
#nullable restore
#line 109 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Admin\DonationRequest.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        
                                         
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                    </div>
                    <!-- Page-body end -->
                </div>
            </div>
            <!-- Main-body end -->

            <div id=""styleSelector"">
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BloodBankPR.Models.DonationRequestDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
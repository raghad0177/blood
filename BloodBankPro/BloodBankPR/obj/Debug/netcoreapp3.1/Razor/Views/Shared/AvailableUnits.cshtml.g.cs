#pragma checksum "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "beb7f477c8b602c5a4ed05bf8cda88abb23330b89419c85c994a5ecdacaffab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AvailableUnits), @"mvc.1.0.view", @"/Views/Shared/AvailableUnits.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"beb7f477c8b602c5a4ed05bf8cda88abb23330b89419c85c994a5ecdacaffab0", @"/Views/Shared/AvailableUnits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c60ce5c37d0c480b2f35d565a956f04fffeb26ec020110bba8c4c30cf5518f9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_AvailableUnits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
  
    Layout = "_LayoutDoctor";
    var oNeg = ViewBag.oNeg;
    var oPlus = ViewBag.oPlus;
    var bNeg = ViewBag.bNeg;
    var bPlus = ViewBag.bPlus;
    var abNeg = ViewBag.abNeg;
    var abPlus = ViewBag.abPlus;
    var aPlus = ViewBag.aPlus;
    var aNeg = ViewBag.aNeg;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""pcoded-content"">
    <!-- Page-header start -->
    <div class=""page-header"">
        <div class=""page-block"">
            <div class=""row align-items-center"">
                <div class=""col-md-8"">
                    <div class=""page-header-title"">
                        <h5 class=""m-b-10"">Available units</h5>
                        <p class=""m-b-0""></p>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <ul class=""breadcrumb-title"">
                        <li class=""breadcrumb-item"">
                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb7f477c8b602c5a4ed05bf8cda88abb23330b89419c85c994a5ecdacaffab04703", async() => {
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
            WriteLiteral(@"
                        </li>
                        <li class=""breadcrumb-item"">
                            <a href=""#!"">Available units</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- Page-header end -->
    <div class=""pcoded-inner-content"">
        <!-- Main-body start -->
        <div class=""main-body"">
            <div class=""page-wrapper"">
                <!-- Page-body start -->
                <div class=""page-body"">
                    <div class=""row"">
                        <!-- task, page, download counter  start -->
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 53 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(oNeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        O -
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 75 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(oPlus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        O +
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 97 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(bNeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        B -
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 119 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(bPlus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        B +
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 141 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(abNeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        AB -
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 163 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(abPlus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        AB +
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 185 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(aPlus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        A +
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""card"">
                                <div class=""card-block"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-8"">
                                            <h4 class=""text-c-red"">");
#nullable restore
#line 207 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Shared\AvailableUnits.cshtml"
                                                              Write(aNeg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <h6 class=""text-muted m-b-0"">Unit Ready to Use</h6>
                                        </div>
                                        <div class=""col-4 text-right"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""#ff5252"" class=""bi bi-droplet-fill"" viewBox=""0 0 16 16"">
                                                <path d=""M8 16a6 6 0 0 0 6-6c0-1.655-1.122-2.904-2.432-4.362C10.254 4.176 8.75 2.503 8 0c0 0-6 5.686-6 10a6 6 0 0 0 6 6ZM6.646 4.646l.708.708c-.29.29-1.128 1.311-1.907 2.87l-.894-.448c.82-1.641 1.717-2.753 2.093-3.13Z"" />
                                            </svg>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-footer bg-c-red"">
                                    <div class=""row align-items-center"" style=""align-content:center;color:white;font-");
            WriteLiteral(@"size=22px;"">
                                        A -
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Page-body end -->
            </div>
            <div id=""styleSelector""> </div>
        </div>
    </div>
</div>");
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

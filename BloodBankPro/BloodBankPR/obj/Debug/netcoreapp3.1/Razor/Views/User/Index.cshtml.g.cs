#pragma checksum "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "182ea3b5da2380ffeb64228a3457ea7842f4e4dcfe1da2964c8da284faff3140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"182ea3b5da2380ffeb64228a3457ea7842f4e4dcfe1da2964c8da284faff3140", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c60ce5c37d0c480b2f35d565a956f04fffeb26ec020110bba8c4c30cf5518f9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\User\Index.cshtml"
  
    Layout = "_LayoutUser";
    var u1 = ViewBag.dons;
    var u2 = ViewBag.units;
    var u3 = ViewBag.donation;
    var u4 = ViewBag.bloodRequest;
    var donInm = ViewBag.donationInMonth;
    var unitInm = ViewBag.unitsInMonth;
    var sum = unitInm + donInm;

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
                        <h5 class=""m-b-10"">Dashboard</h5>
                        <p class=""m-b-0"">Welcome Name</p>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <ul class=""breadcrumb-title"">
                        <li class=""breadcrumb-item"">
                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182ea3b5da2380ffeb64228a3457ea7842f4e4dcfe1da2964c8da284faff31404632", async() => {
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
                            <a href=""#!"">Dashboard</a>
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
                        <div class=""col-xl-3 col-md-6"">
                           
                        </div>
                        <div class=""col-xl-3 col-md-6"">
                           
                        </div>
                        <div class=""col-xl-3 col-md-6"">
                           
                        </div>
                        <div class=""col-xl-3 col-md-6"">
");
            WriteLiteral(@"                            
                        </div>
                        <!-- task, page, download counter  end -->
                        <!--  sale analytics start -->

                        <div class=""col-xl-12 col-md-12"">
                            <div class=""card quater-card"">
                                <div class=""card-block"">
                                    <h6 class=""text-muted m-b-15"">Total Operation This Month</h6>
                                    <h4>");
#nullable restore
#line 63 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\User\Index.cshtml"
                                   Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n                                    <p clunitInm ass=\"text-muted\"></p>\n                                    <h5>");
#nullable restore
#line 65 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\User\Index.cshtml"
                                   Write(donInm);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <p class=""text-muted"">Donation Request<span class=""f-right""></span></p>
                                    <div class=""progress""><div class=""progress-bar bg-c-blue"" style=""width: 80%""></div></div>
                                   
                                </div>
                            </div>


                        </div>
                        <!--  sale analytics end -->
                        <!--  project and team member start -->

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

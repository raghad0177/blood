#pragma checksum "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Home\ConfitmOTP.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7cc574c2a91d914faeff1de7217a5122088c2e8000ec897ca8838deeeccaef4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConfitmOTP), @"mvc.1.0.view", @"/Views/Home/ConfitmOTP.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7cc574c2a91d914faeff1de7217a5122088c2e8000ec897ca8838deeeccaef4c", @"/Views/Home/ConfitmOTP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c60ce5c37d0c480b2f35d565a956f04fffeb26ec020110bba8c4c30cf5518f9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ConfitmOTP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfitmOTP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Bloods/register.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:350px;width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Home\ConfitmOTP.cshtml"
  
    var list = ViewBag.errors as List<string>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Section: Design Block -->
<section class=""text-center text-lg-start"">
    <style>
        .cascading-right {
            margin-right: -50px;
        }

    </style>

    <!-- Jumbotron -->
    <div class=""container"" style=""margin-top:25px;"">
        <div class=""row g-0 align-items-center"">
            <div class=""col-lg-6 mb-5 mb-lg-0"">
                <div class=""card cascading-right"" style=""
            background: hsla(0, 0%, 100%, 0.55);
            backdrop-filter: blur(30px);
            "">
                    <div class=""card-body p-5 shadow-5 text-center"">
                        <h2 class=""fw-bold mb-5"">Confirm Password Change</h2>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc574c2a91d914faeff1de7217a5122088c2e8000ec897ca8838deeeccaef4c6190", async() => {
                WriteLiteral(@"


                            <!-- Email input -->
                            <div class=""form-outline mb-4"">
                                <label class=""form-label"" for=""form3Example3"" style=""float:left;"">Verification Code</label>
                                <input type=""number"" maxlength=""6"" id=""form3Example3"" name=""otp"" class=""form-control"" />

                            </div>

                            <!-- Password input -->
                            <div class=""form-outline mb-4"">
                                <label class=""form-label"" for=""form3Example4"" style=""float:left;"">New Password</label>
                                <input type=""password"" id=""form3Example4"" class=""form-control"" name=""newPass"" pattern=""(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!-\/]).{8,}"" title=""Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters"" />

                            </div>

                            <!-- Password input -->
                        ");
                WriteLiteral(@"    <div class=""form-outline mb-4"">
                                <label class=""form-label"" for=""form3Example4"" style=""float:left;"">Confirm Password</label>
                                <input type=""password"" id=""form3Example4"" class=""form-control"" name=""confirmPassword"" pattern=""(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!-\/]).{8,}"" title=""Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters"" />

                            </div>
                            

                            <!-- Submit button -->
                            <button type=""submit"" class=""btn btn-danger btn-block mb-4"">
                                Confirm
                            </button>
");
#nullable restore
#line 55 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Home\ConfitmOTP.cshtml"
                             foreach (var item in list)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text-danger\">");
#nullable restore
#line 57 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Home\ConfitmOTP.cshtml"
                                                  Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 58 "C:\Users\user\OneDrive\Desktop\bloodbank\BloodBankPro\BloodBankPR\Views\Home\ConfitmOTP.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n\n            <div class=\"col-lg-6 mb-5 mb-lg-0\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7cc574c2a91d914faeff1de7217a5122088c2e8000ec897ca8838deeeccaef4c10742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <!-- Jumbotron -->\n</section>\n<!-- Section: Design Block -->");
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

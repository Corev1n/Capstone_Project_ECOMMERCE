#pragma checksum "D:\Capstone-Project-BackUp(12-11-2021)\QuickShop\QuickShop\QuickShop\Views\Employee\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e25b0888acc36703bc87bcf42e3614a086afe63b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_New), @"mvc.1.0.view", @"/Views/Employee/New.cshtml")]
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
#line 1 "D:\Capstone-Project-BackUp(12-11-2021)\QuickShop\QuickShop\QuickShop\Views\_ViewImports.cshtml"
using QuickShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Capstone-Project-BackUp(12-11-2021)\QuickShop\QuickShop\QuickShop\Views\_ViewImports.cshtml"
using QuickShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25b0888acc36703bc87bcf42e3614a086afe63b", @"/Views/Employee/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356effaf6a5c4f3af812be49426d9e8b1a802cf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-start"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Capstone-Project-BackUp(12-11-2021)\QuickShop\QuickShop\QuickShop\Views\Employee\New.cshtml"
  
    ViewData["Title"] = "New User";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card z-index-0 fadeIn3 fadeInBottom bg shadow-dark"">
    <div class=""card-header p-3 pt-2"">
        <div class=""icon icon-lg icon-shape bg-gradient-warning shadow-warning text-center border-radius-xl mt-n4 position-absolute"">
            <i class=""material-icons opacity-10"">
                add
            </i>
        </div>
    </div>
    <div class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25b0888acc36703bc87bcf42e3614a086afe63b5058", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-8"">
                    <h5 class=""font-weight-bold mt-3 mb-0 "">Personal Details</h5>
                    <div class=""input-group input-group-outline my-3"">
                        <label class=""form-label"">Name</label>
                        <input type=""email"" class=""form-control"">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Birth Date</label>
                        <input type=""date"" class=""form-control "">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <select class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25b0888acc36703bc87bcf42e3614a086afe63b6118", async() => {
                    WriteLiteral("Gender");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25b0888acc36703bc87bcf42e3614a086afe63b7247", async() => {
                    WriteLiteral("Male");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <h5 class=""font-weight-bold mt-4 "">Contact Details</h5>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Phone #</label>
                        <input type=""text"" class=""form-control "">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Email</label>
                        <input type=""text"" class=""form-control "">
                    </div>
                    <h5 class=""font-weight-bold mt-4 "">Local Adress</h5>
                    <div class=""input-group input-group-outline my-3"">
                        <label class=""form-label"">Address Line 1</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label");
                WriteLiteral(@" class=""form-label"">Address Line 2</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">City</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Provice</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                    <h5 class=""font-weight-bold mt-4 "">Credentials</h5>

                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Password</label>
                        <input type=""password"" class=""form-control "">
                    </div>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=");
                WriteLiteral(@"""form-label"">Confirm Password</label>
                        <input type=""password"" class=""form-control "">
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <h5 class=""font-weight-bold mt-4 "">Photo</h5>
                    <div class=""input-group input-group-outline mb-3"">
                        <label class=""form-label"">Password</label>
                        <input type=""password"" class=""form-control "">
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"text-right\">\r\n            <button type=\"button\" class=\"btn btn-block bg-gradient-success my-4 mb-2\">Save</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

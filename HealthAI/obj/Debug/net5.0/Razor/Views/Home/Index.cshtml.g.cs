#pragma checksum "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78546f89b53691f76139f28b7456b82d5cd9ba22"
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
#line 1 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\_ViewImports.cshtml"
using HealthAI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\_ViewImports.cshtml"
using HealthAI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78546f89b53691f76139f28b7456b82d5cd9ba22", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e645e99aeb637866c43a96f8da004a5993ce785", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthAI.Models.ViewModels.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_IndividualProductCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""text-center"">

    <!-- Background image -->
    <div class=""bg-image d-flex justify-content-center align-items-center text-white""
         style="" background-image: url('https://www.premedicine-berlin.de/en/wp-content/uploads/2019/08/tchietchien.jpeg'); height: 60vh; "">

        <div class=""col-md-5 p-lg-5 mx-auto my-5"">
            <h1 class=""display-4 fw-normal"">Our clinic</h1>
            <p class=""lead fw-normal"">And an even wittier subheading to boot. Jumpstart your marketing efforts with this example based on Apple’s marketing pages.</p>
            <a class=""btn btn-outline-light"" href=""#"">Coming soon</a>
        </div>
    </div>
    <!-- Background image -->
    <!--Pricing-->
    <div class=""pricing-header p-3 pb-md-4 mx-auto text-center"">
        <h1 class=""display-4 fw-normal"">Pricing</h1>
        <p class=""fs-5 text-muted"">Quickly build an effective pricing table for your potential customers with this Bootstrap example. It’s built with default Bootstrap components");
            WriteLiteral(@" and utilities with little customization.</p>
    </div>

    <main>
        <div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm"">
                    <div class=""card-header py-3"">
                        <h4 class=""my-0 fw-normal"">Free</h4>
                    </div>
                    <div class=""card-body"">
                        <h1 class=""card-title pricing-card-title"">$0<small class=""text-muted fw-light"">/mo</small></h1>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>10 users included</li>
                            <li>2 GB of storage</li>
                            <li>Email support</li>
                            <li>Help center access</li>
                        </ul>
                        <button type=""button"" class=""w-100 btn btn-lg btn-outline-primary"">Sign up for free</button>
                    </div>
                </div>
");
            WriteLiteral(@"            </div>
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm"">
                    <div class=""card-header py-3"">
                        <h4 class=""my-0 fw-normal"">Pro</h4>
                    </div>
                    <div class=""card-body"">
                        <h1 class=""card-title pricing-card-title"">$15<small class=""text-muted fw-light"">/mo</small></h1>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>20 users included</li>
                            <li>10 GB of storage</li>
                            <li>Priority email support</li>
                            <li>Help center access</li>
                        </ul>
                        <button type=""button"" class=""w-100 btn btn-lg btn-primary"">Get started</button>
                    </div>
                </div>
            </div>
            <div class=""col"">
                <div class=""card mb-4 rounded-3 shadow-sm border-primary"">");
            WriteLiteral(@"
                    <div class=""card-header py-3 text-white bg-primary border-primary"">
                        <h4 class=""my-0 fw-normal"">Enterprise</h4>
                    </div>
                    <div class=""card-body"">
                        <h1 class=""card-title pricing-card-title"">$29<small class=""text-muted fw-light"">/mo</small></h1>
                        <ul class=""list-unstyled mt-3 mb-4"">
                            <li>30 users included</li>
                            <li>15 GB of storage</li>
                            <li>Phone and email support</li>
                            <li>Help center access</li>
                        </ul>
                        <button type=""button"" class=""w-100 btn btn-lg btn-primary"">Contact us</button>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <!--Pricing-->

</div>

<!--Our services-->
<hr>

<div class=""pricing-header p-3 pb-md-4 mx-auto text-center"">
    <h1 class=""disp");
            WriteLiteral(@"lay-4 fw-normal"">Our services</h1>
    <p class=""fs-5 text-muted"">Quickly build an effective pricing table for your potential customers with this Bootstrap example. It’s built with default Bootstrap components and utilities with little customization.</p>
</div>

<div class=""container"">
    <div class=""text-center"">
        <button class=""btn btn-dark filter-button"" data-filter=""all"">All</button>
");
#nullable restore
#line 93 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
         foreach (var obj in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-outline-secondary filter-button\" data-filter=\"");
#nullable restore
#line 95 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
                                                                            Write(obj.Name.Replace(' ','_'));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                ");
#nullable restore
#line 96 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
           Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n");
#nullable restore
#line 98 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 102 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
         foreach (var prod in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78546f89b53691f76139f28b7456b82d5cd9ba229487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 104 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = prod;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\Arthur\source\repos\HealthAI\HealthAI\Views\Home\Index.cshtml"
            //display all product
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<!--Our services-->\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".filter-button"").click(function () {
                var value = $(this).attr('data-filter');
                if (value == ""all"") {
                    $('.filter').show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $('.filter').filter('.' + value).show('3000');
                }
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthAI.Models.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

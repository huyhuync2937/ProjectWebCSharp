#pragma checksum "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddCategory), @"mvc.1.0.view", @"/Views/Admin/AddCategory.cshtml")]
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
#line 1 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b", @"/Views/Admin/AddCategory.cshtml")]
    #nullable restore
    public class Views_Admin_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/templatemo-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
  
    ViewBag.checkPage = 2;
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b4802", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b5064", async() => {
                    WriteLiteral(@"
        <meta charset=""UTF-8"" />
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
        <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
        <title>Product Page - Admin HTML Template</title>
        <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:400,700"" />
        <!-- https://fonts.google.com/specimen/Roboto -->
        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b5747", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <!-- https://fontawesome.com/ -->\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b7034", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <!-- https://getbootstrap.com/ -->\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b8322", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <!--\r\n                  Product Admin CSS Template\r\n                  https://templatemo.com/tm-524-product-admin\r\n        -->\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f29e1e8e979b5ea0ab4d6804e09dafbe466a9b11173", async() => {
                WriteLiteral(@"
   
    <div class=""container tm-mt-big tm-mb-big"">
        <div class=""row"">
            <div class=""col-xl-9 col-lg-10 col-md-12 col-sm-12 mx-auto"">
                <div class=""tm-bg-primary-dark tm-block tm-block-h-auto"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h2 class=""tm-block-title d-inline-block"">Add category</h2>
                        </div>
                    </div>
                    <div class=""row tm-edit-product-row"">
                        <div class=""col-xl-6 col-lg-6 col-md-12"">
                            <form action=""/Admin/DoAddNewCategory"" method=""post"" class=""tm-edit-product-form"">
                                <div class=""form-group mb-3"">
                                    <label for=""name"">
                                        Add new category
                                    </label>
                                    <input id=""name"" name=""Category.TypeName"" type=""text"" class=""");
                WriteLiteral("form-control validate\" />\r\n                                </div>\r\n                                    <div style=\"color: red;text-align: center\">");
#nullable restore
#line 50 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
                                                                          Write(ViewBag.mess1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                <button type=""submit"" class=""btn btn-primary btn-block text-uppercase"">
                                    Add new category
                                </button>
                            </form>

                        </div>
                        <div class=""col-xl-6 col-lg-6 col-md-12 mx-auto mb-4"">
                            <form action=""/Admin/DoAddNewType"" method=""post"" class=""tm-edit-product-form"">
                                <input name=""type"" value=""1""");
                BeginWriteAttribute("hidden", " hidden=\"", 2772, "\"", 2781, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                                <div class=""form-group mb-3"">
                                    <div class=""form-group mb-3"">
                                        <label for=""name"">Add new type of Category</label>
                                        <select name=""Category.ParentId"" class=""custom-select tm-select-accounts"" id=""category"">
");
#nullable restore
#line 65 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
                                             foreach (Category category in Model)
                                            {
                                                if (category.ParentId == 0)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <option");
                BeginWriteAttribute("value", " value=\"", 3456, "\"", 3480, 1);
#nullable restore
#line 69 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
WriteAttributeValue("", 3464, category.TypeId, 3464, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 69 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
                                                                                Write(category.TypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 70 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"

                                                }
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </select>
                                    </div>
                                    <label for=""name"">
                                        Add new type of Category
                                    </label>
                                    <input id=""name"" name=""typeNew"" type=""text"" class=""form-control validate"" />
                                </div>
                                    <div style=""color: red;text-align: center"">");
#nullable restore
#line 80 "D:\.NET program\FirstWeb\Project2\Views\Admin\AddCategory.cshtml"
                                                                          Write(ViewBag.mess2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                <button type=""submit"" class=""btn btn-primary btn-block text-uppercase"">
                                    Add new type
                                </button>
                            </form>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
    <footer class=""tm-footer row tm-mt-small"">
        <div class=""col-12 font-weight-light"">
            <p class=""text-center text-white mb-0 px-4 small"">
                Copyright &copy; <b>2018</b> All rights reserved.

                Design: <a rel=""nofollow noopener"" href=""https://templatemo.com"" class=""tm-footer-link"">Template Mo</a>
            </p>
        </div>
    </footer>

    <!--    <script src=""js/jquery-3.3.1.min.js""></script>
         https://jquery.com/download/
        <script src=""jquery-ui-datepicker/jquery-ui.min.js""></script>
         https://jqueryui.com/download/
        <script src=""js/bootstrap");
                WriteLiteral(".min.js\"></script>\r\n         https://getbootstrap.com/ -->\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

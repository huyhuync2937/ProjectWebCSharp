#pragma checksum "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0575203bbdc4935086f64d8d49b7b9e3056fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateProduct), @"mvc.1.0.view", @"/Views/Admin/UpdateProduct.cshtml")]
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
#line 1 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0575203bbdc4935086f64d8d49b7b9e3056fa0", @"/Views/Admin/UpdateProduct.cshtml")]
    #nullable restore
    public class Views_Admin_UpdateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetail>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/jquery-ui-datepicker/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/templatemo-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/jquery-ui-datepicker/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
  
    ViewBag.checkPage = 2;
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0575203bbdc4935086f64d8d49b7b9e3056fa06663", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <title>Add Product - Dashboard HTML Template</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:400,700"" />
    <!-- https://fonts.google.com/specimen/Roboto -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0575203bbdc4935086f64d8d49b7b9e3056fa07313", async() => {
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
                WriteLiteral("\r\n    <!-- https://fontawesome.com/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0575203bbdc4935086f64d8d49b7b9e3056fa08532", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- http://api.jqueryui.com/datepicker/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0575203bbdc4935086f64d8d49b7b9e3056fa09849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- https://getbootstrap.com/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f0575203bbdc4935086f64d8d49b7b9e3056fa011069", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--\r\n          Product Admin CSS Template\r\n          https://templatemo.com/tm-524-product-admin\r\n    -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0575203bbdc4935086f64d8d49b7b9e3056fa013077", async() => {
                WriteLiteral(@"

    <div class=""container tm-mt-big tm-mb-big"">
        <div class=""row"">
            <div class=""col-xl-9 col-lg-10 col-md-12 col-sm-12 mx-auto"">
                <div class=""tm-bg-primary-dark tm-block tm-block-h-auto"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h2 class=""tm-block-title d-inline-block"">Add Product</h2>
                        </div>
                    </div>
                    <form action=""/Admin/DoUpdateProduct"" method=""post"" class=""tm-edit-product-form"">

                        <div class=""row tm-edit-product-row"">
                            <div class=""col-xl-6 col-lg-6 col-md-12"">
                                <input name=""ProductId""");
                BeginWriteAttribute("value", " value=\"", 1875, "\"", 1899, 1);
#nullable restore
#line 45 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 1883, Model.ProductId, 1883, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("hidden", " hidden=\"", 1900, "\"", 1909, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""form-group mb-3"">
                                    <label for=""name"">
                                        Product Name
                                    </label>
                                    <input id=""name""");
                BeginWriteAttribute("value", " value=\"", 2184, "\"", 2218, 1);
#nullable restore
#line 50 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 2192, Model.Product.ProductName, 2192, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Name"" type=""text"" class=""form-control validate"" required />
                                </div>
                                <div class=""row"">

                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""stock"">
                                            Import Price
                                        </label>
                                        <input id=""stock""");
                BeginWriteAttribute("value", " value=\"", 2692, "\"", 2726, 1);
#nullable restore
#line 58 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 2700, Model.Product.ImportPrice, 2700, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""ImportPrice"" pattern=""[0-9]+"" type=""text"" class=""form-control validate""
                                               required />
                                    </div>
                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""stock"">
                                            Sell Price
                                        </label>
                                        <input id=""stock""");
                BeginWriteAttribute("value", " value=\"", 3221, "\"", 3253, 1);
#nullable restore
#line 65 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 3229, Model.Product.SellPrice, 3229, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""SellPrice"" pattern=""[0-9]+"" type=""text"" class=""form-control validate""
                                               required />
                                    </div>
                                </div>
                                <div class=""form-group mb-3"">
                                    <label for=""description"">Description</label>
                                    <textarea name=""Description""");
                BeginWriteAttribute("value", " value=\"", 3685, "\"", 3711, 1);
#nullable restore
#line 71 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 3693, Model.Description, 3693, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control validate\" rows=\"3\" required>");
#nullable restore
#line 71 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
                                                                                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                                </div>
                                <div class=""form-group mb-3"">
                                    <label for=""category"">Category</label>
                                    <select name=""TypeID"" class=""custom-select tm-select-accounts"" id=""category"">
");
#nullable restore
#line 76 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
                                         foreach (Category category in ViewBag.categories)
                                        {
                                            if (category.ParentId != 0)
                                            {
                                                if (category.TypeId == Model.TypeId)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <option selected");
                BeginWriteAttribute("value", " value=\"", 4546, "\"", 4570, 1);
#nullable restore
#line 82 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 4554, category.TypeId, 4554, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 82 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
                                                                                         Write(category.TypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 83 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
                                                }
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <option");
                BeginWriteAttribute("value", " value=\"", 4867, "\"", 4891, 1);
#nullable restore
#line 87 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 4875, category.TypeId, 4875, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 87 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
                                                                                Write(category.TypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 88 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"

                                                }
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        }

                                    </select>
                                </div>
                                <div class=""row"">

                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""stock"">
                                            Brand
                                        </label>
                                        <input");
                BeginWriteAttribute("value", " value=\"", 5501, "\"", 5521, 1);
#nullable restore
#line 101 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 5509, Model.Brand, 5509, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""stock"" name=""Brand"" type=""text"" class=""form-control validate"" required />
                                    </div>
                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""stock"">
                                            Origin
                                        </label>
                                        <input");
                BeginWriteAttribute("value", " value=\"", 5941, "\"", 5962, 1);
#nullable restore
#line 107 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 5949, Model.Origin, 5949, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""stock"" name=""Origin"" type=""text"" class=""form-control validate"" required />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""expire_date"">
                                            Date add
                                        </label>
                                        <input");
                BeginWriteAttribute("value", " value=\"", 6482, "\"", 6537, 1);
#nullable restore
#line 115 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 6490, Model.Product.DateAdd.ToString().Split(" ")[0], 6490, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""DateAdd"" type=""text"" class=""form-control validate"" placeholder=""DD/MM/YYYY"" pattern=""\d{1,2}/\d{1,2}/\d{4}""
                                        data-large-mode=""true"" />
                                    </div>
                                    <div class=""form-group mb-3 col-xs-12 col-sm-6"">
                                        <label for=""stock"">
                                            Units In Stock
                                        </label>
                                        <input id=""stock""");
                BeginWriteAttribute("value", " value=\"", 7079, "\"", 7119, 1);
#nullable restore
#line 122 "D:\.NET program\FirstWeb\Project2\Views\Admin\UpdateProduct.cshtml"
WriteAttributeValue("", 7087, Model.Product.NumberOfInventory, 7087, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""NumberOfInventory"" type=""text"" pattern=""[0-9]+"" class=""form-control validate"" required />
                                    </div>
                                </div>

                            </div>
                            <div class=""col-xl-6 col-lg-6 col-md-12 mx-auto mb-4"">
                                <div class=""tm-product-img-dummy mx-auto"">
                                    <i class=""fas fa-cloud-upload-alt tm-upload-icon""
                                       onclick=""document.getElementById('fileInput').click();""></i>
                                </div>
                                <div class=""custom-file mt-3 mb-3"">
                                    <input id=""fileInput"" type=""file"" style=""display:none;"" />
                                    <input type=""button"" class=""btn btn-primary btn-block mx-auto"" value=""UPLOAD PRODUCT IMAGE""
                                           onclick=""document.getElementById('fileInput').click();"" />
                   ");
                WriteLiteral(@"             </div>
                            </div>
                            <div class=""col-12"">
                                <button type=""submit"" class=""btn btn-primary btn-block text-uppercase"">Update Product Now</button>
                            </div>
                        </div>
                    </form>

                </div>
            </div>
        </div>
    </div>
    <footer class=""tm-footer row tm-mt-small"">
        <div class=""col-12 font-weight-light"">
            <p class=""text-center text-white mb-0 px-4 small"">
                Copyright &copy; <b>2018</b> All rights reserved.

                Design: <a rel=""nofollow noopener"" href=""https://templatemo.com"" class=""tm-footer-link"">Template More</a>
            </p>
        </div>
    </footer>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0575203bbdc4935086f64d8d49b7b9e3056fa026730", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- https://jquery.com/download/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0575203bbdc4935086f64d8d49b7b9e3056fa027875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- https://jqueryui.com/download/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0575203bbdc4935086f64d8d49b7b9e3056fa029022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- https://getbootstrap.com/ -->\r\n    <script>\r\n        $(function () {\r\n            $(\"#expire_date\").datepicker();\r\n        });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7136f33a329be523509a30d4a9e94c323ac0b1a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_OurShop), @"mvc.1.0.view", @"/Views/Guest/OurShop.cshtml")]
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
#line 1 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7136f33a329be523509a30d4a9e94c323ac0b1a3", @"/Views/Guest/OurShop.cshtml")]
    #nullable restore
    public class Views_Guest_OurShop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontlib/owlcarousel/assets/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mail/jqBootstrapValidation.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mail/contact.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7136f33a329be523509a30d4a9e94c323ac0b1a36293", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>ATP Cosmetics Shop </title>
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">

    <meta content=""Free HTML Templates"" name=""keywords"">
    <meta content=""Free HTML Templates"" name=""description"">

    <!-- Favicon -->
    <link href=""img/favicon.ico"" rel=""icon"">

    <!-- Google Web Fonts -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap""
          rel=""stylesheet"">

    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" rel=""stylesheet"">

    <!-- Libraries Stylesheet -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7136f33a329be523509a30d4a9e94c323ac0b1a37418", async() => {
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
                WriteLiteral("\r\n\r\n    <!-- Customized Bootstrap Stylesheet -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7136f33a329be523509a30d4a9e94c323ac0b1a38649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7136f33a329be523509a30d4a9e94c323ac0b1a310623", async() => {
                WriteLiteral(@"
    <!-- Topbar Start -->
    <!-- Page Header End -->

    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <!-- Shop Sidebar Start -->
            <div class=""col-lg-3 col-md-12"">
                <!-- Price Start -->
                <div class=""border-bottom mb-4 pb-4"">
                    <h5 class=""font-weight-semi-bold mb-4"">Thương hiệu</h5>
                    <form>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                            <label class=""custom-control-label"" for=""price-all"">Tất cả</label>
                        </div>

                    </form>
                </div>
                <!-- Price End -->
                <!-- Color Start -->
                <div class=""border-bottom mb-4 pb-4"">
                    <h5 class=""font-weight-semi-bold mb-4"">Xu");
                WriteLiteral(@"ất xứ</h5>
                    <form>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""color-all"">
                            <label class=""custom-control-label"" for=""price-all"">Tất cả</label>
                            <span class=""badge border font-weight-normal"">1000</span>
                        </div>

                    </form>
                </div>
                <!-- Color End -->
                <!-- Size Start -->
                <div class=""mb-5"">
                    <h5 class=""font-weight-semi-bold mb-4"">Giá</h5>
                    <form>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" checked id=""size-all"">
                            <label class=""custom-");
                WriteLiteral(@"control-label"" for=""size-all"">Tất cả</label>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                            <label class=""custom-control-label"" for=""size-1"">0 - 100.000</label>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-2"">
                            <label class=""custom-control-label"" for=""size-2"">100.000 - 200.000</label>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-3"">
                       ");
                WriteLiteral(@"     <label class=""custom-control-label"" for=""size-3"">200.000 - 300.000</label>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-4"">
                            <label class=""custom-control-label"" for=""size-4"">300.000 - 400.000</label>
                        </div>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                            <label class=""custom-control-label"" for=""size-5"">Trên 400.000</label>
                        </div>
                    </form>
                </div>
                <!-- Size End -->
            </div>
            <!-- Shop Sidebar End -->
            <!-- Shop Product Start -->
            <div class=");
                WriteLiteral(@"""col-lg-9 col-md-12"">
                <div class=""row pb-3"">
                    <div class=""col-12 pb-1"">
                        <div class="" align-items-center justify-content-between mb-4"">
                            <div class=""dropdown ml-4"">
                                <button class=""btn border dropdown-toggle"" type=""button"" id=""triggerId""
                                        data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    Sort by
                                </button>
                                <div class=""dropdown-content dropdown-menu-right"" aria-labelledby=""triggerId"">
                                    <a class=""dropdown-item"" href=""#"">Latest</a>
                                    <a class=""dropdown-item"" href=""#"">Popularity</a>
                                    <a class=""dropdown-item"" href=""#"">Best Rating</a>
                                </div>
                            </div>
                        <");
                WriteLiteral("/div>\r\n                    </div>\r\n");
#nullable restore
#line 116 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                     if (ViewBag.productDetail==null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>Don\'t have product</div>\r\n");
#nullable restore
#line 119 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                    }
                    else
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                         foreach (ProductDetail productDetail in ViewBag.productDetail)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-lg-4 col-md-6 col-sm-12 pb-1"">

                                <div class=""card product-item border-0 mb-4"">
                                    <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">

                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7136f33a329be523509a30d4a9e94c323ac0b1a317565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6966, "~/images/", 6966, 9, true);
#nullable restore
#line 131 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
AddHtmlAttributeValue("", 6975, productDetail.Product.Image, 6975, 28, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                                        <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 134 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                                                  Write(productDetail.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                        <div class=\"d-flex justify-content-center\">\r\n                                            <h6>");
#nullable restore
#line 136 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                           Write(productDetail.Product.SellPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
                                        </div>
                                    </div>
                                    <div class=""card-footer d-flex justify-content-between bg-light border"">
                                        <a href=""/User/DisplayDetailProduct?type=1&Detail=${pr.productID}"" class=""btn btn-sm text-dark p-0""><i class=""fas fa-eye text-primary mr-1""></i>View Detail</a>
");
#nullable restore
#line 142 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                         if (productDetail.Product.NumberOfInventory == 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Out of stock</a>\r\n");
#nullable restore
#line 145 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a href=\"AddProductToCart?type=1&AddCartProductID=${pr.productID}\" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Add To Cart</a>\r\n");
#nullable restore
#line 149 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 155 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-12 pb-1\">\r\n                            <nav aria-label=\"Page navigation\">\r\n");
#nullable restore
#line 159 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                 if ((int)ViewData["CurrentPage"] != 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 9045, "\"", 9108, 3);
                WriteAttributeValue("", 9052, "/Guest/OurShop?TypeID=", 9052, 22, true);
#nullable restore
#line 161 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9074, ViewData["CurrentProduct"], 9074, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9101, "&Page=1", 9101, 7, true);
                EndWriteAttribute();
                WriteLiteral(">First</a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 9159, "\"", 9241, 4);
                WriteAttributeValue("", 9166, "/Guest/OurShop?TypeID=", 9166, 22, true);
#nullable restore
#line 162 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9188, ViewData["CurrentProduct"], 9188, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9215, "&Page=", 9215, 6, true);
#nullable restore
#line 162 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9221, ViewData["PrePage"], 9221, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Pre</a>\r\n");
#nullable restore
#line 163 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 9327, "\"", 9413, 4);
                WriteAttributeValue("", 9334, "/Guest/OurShop?TypeID=", 9334, 22, true);
#nullable restore
#line 167 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9356, ViewData["CurrentProduct"], 9356, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9383, "&Page=", 9383, 6, true);
#nullable restore
#line 167 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9389, ViewData["CurrentPage"], 9389, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 167 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                                                                                                     Write(ViewData["CurrentPage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 169 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                 if ((int)ViewData["TotalPage"] != (int)ViewData["CurrentPage"])
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 9618, "\"", 9701, 4);
                WriteAttributeValue("", 9625, "/Guest/OurShop?TypeID=", 9625, 22, true);
#nullable restore
#line 171 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9647, ViewData["CurrentProduct"], 9647, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9674, "&Page=", 9674, 6, true);
#nullable restore
#line 171 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9680, ViewData["NextPage"], 9680, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Next</a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 9751, "\"", 9835, 4);
                WriteAttributeValue("", 9758, "/Guest/OurShop?TypeID=", 9758, 22, true);
#nullable restore
#line 172 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9780, ViewData["CurrentProduct"], 9780, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9807, "&Page=", 9807, 6, true);
#nullable restore
#line 172 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
WriteAttributeValue("", 9813, ViewData["TotalPage"], 9813, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Last</a>\r\n");
#nullable restore
#line 173 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </nav>\r\n                        </div>\r\n");
#nullable restore
#line 177 "D:\.NET program\FirstWeb\Project2\Views\Guest\OurShop.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <!-- Shop Product End -->
            </div>
        </div>



        <!-- Footer Start -->
        <!-- Footer End -->
        <!-- Back to Top -->
        <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>


        <!-- JavaScript Libraries -->
        <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
        <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
        <script src=""lib/easing/easing.min.js""></script>
        <script src=""lib/owlcarousel/owl.carousel.min.js""></script>

        <!-- Contact Javascript File -->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7136f33a329be523509a30d4a9e94c323ac0b1a328565", async() => {
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7136f33a329be523509a30d4a9e94c323ac0b1a329669", async() => {
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
                WriteLiteral("\r\n\r\n        <!-- Template Javascript -->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7136f33a329be523509a30d4a9e94c323ac0b1a330817", async() => {
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

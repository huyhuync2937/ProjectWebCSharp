#pragma checksum "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b160cc2c5a95c93127d0931b911197d382a6b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DisplayUser), @"mvc.1.0.view", @"/Views/Admin/DisplayUser.cshtml")]
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
#line 1 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b160cc2c5a95c93127d0931b911197d382a6b5", @"/Views/Admin/DisplayUser.cshtml")]
    #nullable restore
    public class Views_Admin_DisplayUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/templatemo-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reportsPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
  
    ViewBag.checkPage = 3;
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b160cc2c5a95c93127d0931b911197d382a6b56243", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <title>Product Page - Admin HTML Template</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:400,700"" />
    <!-- https://fonts.google.com/specimen/Roboto -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45b160cc2c5a95c93127d0931b911197d382a6b56890", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45b160cc2c5a95c93127d0931b911197d382a6b58109", async() => {
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
                WriteLiteral("\r\n    <!-- https://getbootstrap.com/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45b160cc2c5a95c93127d0931b911197d382a6b59329", async() => {
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
                WriteLiteral("\r\n    <!--\r\n              Product Admin CSS Template\r\n              https://templatemo.com/tm-524-product-admin\r\n    -->\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b160cc2c5a95c93127d0931b911197d382a6b511344", async() => {
                WriteLiteral(@"
   
    <div class=""col-12 tm-block-col"">
        <div class=""tm-bg-primary-dark tm-block tm-block-taller tm-block-scroll"">
            <h2 class=""tm-block-title"">Orders List</h2>
            <table class=""table"">
                <thead>

                    <tr>
                        <th scope=""col"">User name </th>
                        <th scope=""col"">Adddress</th>
                        <th scope=""col"">Birthday</th>
                        <th scope=""col"">Phone</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Admin</th>
                        <th scope=""col"">Hide</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 50 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                     foreach (User user in ViewBag.userList)
                    {
                        if (user.UserDetail != null)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <th scope=\"row\"><b>");
#nullable restore
#line 56 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                              Write(user.UserDetail.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></th>\r\n                                <td>");
#nullable restore
#line 57 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                               Write(user.UserDetail.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td><b>");
#nullable restore
#line 58 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                  Write(user.UserDetail.Birthday);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 59 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                  Write(user.UserDetail.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                                <td><b>");
#nullable restore
#line 60 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                  Write(user.UserDetail.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></td>\r\n                                <td>\r\n");
#nullable restore
#line 62 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                     if(user.IsAdmin != 2)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         <select onchange=\"window.location.href=this.value;\" class=\"custom-select tm-select-accounts\" id=\"category\">\r\n");
#nullable restore
#line 65 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                         if (user.IsAdmin == 1)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <option");
                BeginWriteAttribute("value", " value=\"", 2800, "\"", 2859, 2);
                WriteAttributeValue("", 2808, "/Admin/ChangeIsAdmin?type=1&userID=", 2808, 35, true);
#nullable restore
#line 67 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 2843, user.CustomerId, 2843, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 2860, "\"", 2871, 0);
                EndWriteAttribute();
                WriteLiteral(">Admin </option>\r\n                                            <option");
                BeginWriteAttribute("value", " value=\"", 2941, "\"", 3000, 2);
                WriteAttributeValue("", 2949, "/Admin/ChangeIsAdmin?type=0&userID=", 2949, 35, true);
#nullable restore
#line 68 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 2984, user.CustomerId, 2984, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Customer</option>\r\n");
#nullable restore
#line 69 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                         if (user.IsAdmin == 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <option");
                BeginWriteAttribute("value", " value=\"", 3227, "\"", 3286, 2);
                WriteAttributeValue("", 3235, "/Admin/ChangeIsAdmin?type=1&userID=", 3235, 35, true);
#nullable restore
#line 74 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 3270, user.CustomerId, 3270, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Admin</option>\r\n                                            <option");
                BeginWriteAttribute("value", " value=\"", 3355, "\"", 3414, 2);
                WriteAttributeValue("", 3363, "/Admin/ChangeIsAdmin?type=0&userID=", 3363, 35, true);
#nullable restore
#line 75 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 3398, user.CustomerId, 3398, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 3415, "\"", 3426, 0);
                EndWriteAttribute();
                WriteLiteral(">Customer</option>\r\n");
#nullable restore
#line 76 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </select>\r\n");
#nullable restore
#line 80 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                   \r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 84 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                      
                                        string userLogin = Accessor.HttpContext.Session.GetString("User");
                                        User user1 = JsonConvert.DeserializeObject<User>(userLogin);

                                        if (user.CustomerId != user1.CustomerId && user.IsAdmin != 2)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a");
                BeginWriteAttribute("href", " href=\"", 4138, "\"", 4184, 2);
                WriteAttributeValue("", 4145, "/Admin/HideUser?userID=", 4145, 23, true);
#nullable restore
#line 90 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 4168, user.CustomerId, 4168, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"tm-product-delete-link\">\r\n                                                <i class=\"far fa-trash-alt tm-product-delete-icon\"></i>\r\n                                            </a>\r\n");
#nullable restore
#line 93 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                        }
                                         if (user.IsAdmin == 2)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a");
                BeginWriteAttribute("href", " href=\"", 4571, "\"", 4619, 2);
                WriteAttributeValue("", 4578, "/Admin/UnHideUser?userID=", 4578, 25, true);
#nullable restore
#line 96 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
WriteAttributeValue("", 4603, user.CustomerId, 4603, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"tm-product-delete-link\">\r\n                                                <i class=\"fa-solid fa-unlock-keyhole\"></i>\r\n                                            </a>\r\n");
#nullable restore
#line 99 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 104 "D:\.NET program\FirstWeb\Project2\Views\Admin\DisplayUser.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </tbody>
            </table>
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

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b160cc2c5a95c93127d0931b911197d382a6b521937", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- https://jquery.com/download/ -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b160cc2c5a95c93127d0931b911197d382a6b523082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; } = default!;
        #nullable disable
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

#pragma checksum "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877272b62688fdf9428200355daa989ba3aa7dc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
using Project2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877272b62688fdf9428200355daa989ba3aa7dc6", @"/Views/User/Profile.cshtml")]
    #nullable restore
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fontlib/owlcarousel/assets/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877272b62688fdf9428200355daa989ba3aa7dc64513", async() => {
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
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" type=""text/css"" rel=""stylesheet"">

    <!-- Libraries Stylesheet -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "877272b62688fdf9428200355daa989ba3aa7dc65656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Customized Bootstrap Stylesheet -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "877272b62688fdf9428200355daa989ba3aa7dc66974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        #checkPasswordPhone {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        #checkPasswordEmail {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            b");
                WriteLiteral(@"ackground-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        .checkPasswordPhone_content {
            background-color: #fefefe;
            margin: auto;
            padding: 50px;
            border: 1px solid #888;
            width: 40%;
        }

        .checkPasswordEmail_content {
            background-color: #fefefe;
            margin: auto;
            padding: 50px;
            border: 1px solid #888;
            width: 40%;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877272b62688fdf9428200355daa989ba3aa7dc610574", async() => {
                WriteLiteral(@"

    <!-- Page Header End -->

    <div class=""container-fluid pt-5"">
        <div class=""row px-xl-5"">
            <!-- Shop Sidebar Start -->
            <div class=""col-lg-3 col-md-12"">

                <div class=""mb-5"">
                    <h5 class=""font-weight-semi-bold mb-4"">Profile customer</h5>
                    <form>
                        <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                            <a href=""DisplayInformationCustomer""");
                BeginWriteAttribute("class", " class=\"", 3287, "\"", 3295, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"size-all\">Information</a>\r\n                        </div>\r\n                        <div class=\"custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3\">\r\n                            <a href=\"DisplayAddress\"");
                BeginWriteAttribute("class", " class=\"", 3538, "\"", 3546, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"size-all\">Address</a>\r\n                        </div>\r\n                        <div class=\"custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3\">\r\n                            <a href=\"/User/ChangePassword\"");
                BeginWriteAttribute("class", " class=\"", 3791, "\"", 3799, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"size-all\">Change password</a>\r\n                        </div>\r\n                        <div class=\"custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3\">\r\n                            <a href=\"DisplayHistotyBill\"");
                BeginWriteAttribute("class", " class=\"", 4050, "\"", 4058, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""size-all"">History</a>
                        </div>


                    </form>
                </div>
                <!-- Size End -->
            </div>

            <form action=""/User/UpdateInfomation"" method=""post"" class=""col-lg-9 col-md-12"">

                <h4 class=""font-weight-semi-bold mb-4"">Profile customer</h4>
                <div class=""row"">
                    <div class=""col-md-6 form-group"">
                        <label>Name</label>
                        <input name=""UserDetail.name"" class=""form-control"" type=""text"" placeholder=""John""");
                BeginWriteAttribute("value", " value=\"", 4647, "\"", 4677, 1);
#nullable restore
#line 116 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 4655, Model.UserDetail.Name, 4655, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6 form-group\">\r\n                        <label>Address</label>\r\n                        <input name=\"UserDetail.address\" class=\"form-control\" type=\"text\" placeholder=\"Doe\"");
                BeginWriteAttribute("value", " value=\"", 4919, "\"", 4952, 1);
#nullable restore
#line 120 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 4927, Model.UserDetail.Address, 4927, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" >
                    </div>
                    <div class=""col-md-6 form-group"">
                        <label>E-mail</label>
                        <div class=""input-group form-group  mx-auto"">
                            <div id=""defaultEmail"" class=""form-control"" type=""text"" placeholder=""example@email.com""");
                BeginWriteAttribute("value", " value=\"", 5273, "\"", 5304, 1);
#nullable restore
#line 125 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 5281, Model.UserDetail.Email, 5281, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 125 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
                                                                                                                                               Write(Model.UserDetail.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                            <a id=""changeEmail"" style=""margin-left: 5px; margin-top: 5px"">Change</a>
                        </div>
                    </div>
                    <div class=""col-md-6 form-group"">
                        <label>Mobile No</label>
                        <div class=""input-group form-group  mx-auto"">
                            <div id=""defaultPhone"" class=""form-control"" type=""text"" placeholder=""+123 45 678"" pattern=""[0-9]{3}[0-9]{2}[0-9]{3}""");
                BeginWriteAttribute("value", " value=\"", 5819, "\"", 5850, 1);
#nullable restore
#line 132 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 5827, Model.UserDetail.Phone, 5827, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 133 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
                           Write(Model.UserDetail.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <a id=""changePhone"" style=""margin-left: 5px; margin-top: 5px"">Change</a>
                        </div>
                    </div>
                    <div class=""col-md-6 form-group"">
                        <label>Birthday</label>
                        <input name=""UserDetail.birthday"" class=""form-control"" type=""text"" placeholder=""DD/MM/YYYY "" pattern=""\d{1,2}/\d{1,2}/\d{4}""");
                BeginWriteAttribute("value", " value=\"", 6361, "\"", 6420, 1);
#nullable restore
#line 140 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 6369, Model.UserDetail.Birthday.ToString().Split(" ")[0], 6369, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>

                </div>
                <button style=""background-color: papayawhip;color: palevioletred; border-color: white; margin-left: 50%"" type=""submit"">Save</button>

            </form>

            <div class=""ChangeEmail"" id=""checkPasswordEmail"">
                <div id=""checkPasswordEmail_content"" class=""checkPasswordEmail_content"">
                    <form action=""/User/ChangeEmail"" id='formEmail' method=""post"">
                        <div>
                            <label style=""text-align:center;"">Password</label>
                            <div class=""input-group form-group  mx-auto"">
                                <input id=""passwordEmail"" name=""password"" class=""form-control"" type=""password"" required=""required"" hidden");
                BeginWriteAttribute("value", " value=\"", 7213, "\"", 7236, 1);
#nullable restore
#line 154 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 7221, Model.Password, 7221, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <input type=""password"" class=""form-control"" name=""confirm_password"" id=""confirm_passwordEmail"">
                                <span id=""messageEmail""></span>
                            </div>
                            <a id=""button_backEmail"" style=""border:solid 1px; background-color: papayawhip;color: palevioletred; border-color: white;margin-left:40%"">Back</a>
                            <a id=""button_submitEmail"" style=""border:solid 1px; background-color: papayawhip;color: palevioletred; border-color: white;margin-left:10px"">Submit</a>
                            <input type=""submit""  name=""buttonSubmit1""  hidden id=""submitFormEmail"" >
                        </div>

                    </form>

                </div>
            </div>
            <div class=""ChangePhone"" id=""checkPasswordPhone"">
                <div id=""checkPasswordPhone_content"" class=""checkPasswordPhone_content"">
                    <form action=""/User/ChangePhone"" id='formPhone' m");
                WriteLiteral(@"ethod=""post"">
                        <div>
                            <label style=""text-align:center;"">Password</label>
                            <div class=""input-group form-group  mx-auto"">
                                <input id=""passwordPhone"" name=""password"" class=""form-control"" type=""password"" required=""required"" hidden");
                BeginWriteAttribute("value", " value=\"", 8599, "\"", 8622, 1);
#nullable restore
#line 173 "D:\.NET program\FirstWeb\Project2\Views\User\Profile.cshtml"
WriteAttributeValue("", 8607, Model.Password, 8607, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                <input type=""password"" class=""form-control"" name=""confirm_password"" id=""confirm_passwordPhone"">
                                <span id=""messagePhone""></span>
                            </div>
                            <a id=""button_backPhone"" style="" border:solid 1px; background-color: papayawhip;color: palevioletred; border-color: white;margin-left:40%"">Back</a>
                            <a id=""button_submitPhone"" style=""border:solid 1px; background-color: papayawhip;color: palevioletred; border-color: white;margin-left:10px"">Submit</a>
                            <input type=""submit"" name=""buttonSubmit2"" hidden id=""submitFormPhone"" >
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
  
    <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>

    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js"" t");
                WriteLiteral(@"ype="" text/javascript""></script>

    <script>

        $('#changeEmail').on('click',function(){
            $('#checkPasswordEmail').css('display','block');
            $('#messageEmail').html('').css('color', 'red');

        });
         $('#changePhone').on('click',function(){
            $('#checkPasswordPhone').css('display','block');
            $('#messagePhone').html('').css('color', 'red');

        });

        $('#button_submitPhone').on('click',function(){
             if ($('#passwordPhone').val() == $('#confirm_passwordPhone').val())
            {
                $('#formPhone').submit();
            }
            else
            {
                $('#messagePhone').html('not matching').css('color', 'red');
                $(""#confirm_passwordPhone"").val('');
            }
        });
         $('#button_submitEmail').on('click',function(){
             if ($('#passwordEmail').val() == $('#confirm_passwordEmail').val())
            {
                $('#formEmail')");
                WriteLiteral(@".submit();
            }
            else
            {
                $('#messageEmail').html('not matching').css('color', 'red');
                $(""#confirm_passwordEmail"").val('');
            }
        });


        $('#button_backPhone').on('click',function(){
            $('#checkPasswordPhone').css('display','none');
            $(""#confirm_passwordPhone"").val('');

        });
        $('#button_backEmail').on('click',function(){
            $('#checkPasswordEmail').css('display','none');
            $(""#confirm_passwordEmail"").val('');

        });

    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

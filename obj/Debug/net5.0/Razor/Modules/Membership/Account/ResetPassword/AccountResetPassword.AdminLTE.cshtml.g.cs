#pragma checksum "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c442e5737aa2b5cf48e1c54e80367ef18f5beba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ResetPassword_AccountResetPassword_AdminLTE), @"mvc.1.0.view", @"/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml")]
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
#line 1 "D:\serenity\serintest.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\serenity\serintest.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\serenity\serintest.Web\Modules\_ViewImports.cshtml"
using Serintest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\serenity\serintest.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\serenity\serintest.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c442e5737aa2b5cf48e1c54e80367ef18f5beba7", @"/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2ae0a23ff1cf4c77d77324c5158a5f2bc2850", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ResetPassword_AccountResetPassword_AdminLTE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Serintest.Membership.ResetPasswordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ResetPassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ResetPassword";
    ViewData["BodyClass"] = "login-page";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script id=""Template_Membership_ResetPasswordPanel"" type=""text/template"">
<div class=""s-Form"">
    <form id=""~_Form"" action="""">
        <div id=""~_PropertyGrid""></div>
        <div class=""row"">
            <div class=""col-xs-6 col-xs-offset-6"">
                <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary btn-block btn-flat"">");
#nullable restore
#line 17 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
                                                                                                Write(Texts.Forms.Membership.ResetPassword.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n        <input type=\"hidden\" id=\"~_Token\" value=\"");
#nullable restore
#line 20 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
                                            Write(Model.Token);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n    </form>\r\n</div>\r\n</script>\r\n\r\n<div class=\"login-box\">\r\n    <div class=\"login-logo\">\r\n        ");
#nullable restore
#line 27 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
   Write(Texts.Navigation.SiteTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"login-box-body\">\r\n        <p class=\"login-box-msg\">");
#nullable restore
#line 30 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
                            Write(Texts.Forms.Membership.ResetPassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"ResetPasswordPanel\">\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1270, 1);
#nullable restore
#line 33 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
WriteAttributeValue("", 1239, Url.Content("~/Account/Login"), 1239, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">");
#nullable restore
#line 33 "D:\serenity\serintest.Web\Modules\Membership\Account\ResetPassword\AccountResetPassword.AdminLTE.cshtml"
                                                                 Write(Texts.Forms.Membership.ResetPassword.BackToLogin.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n$(function() {\r\n    new Serintest.Membership.ResetPasswordPanel($(\'#ResetPasswordPanel\')).init();\r\n});\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Serintest.Membership.ResetPasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

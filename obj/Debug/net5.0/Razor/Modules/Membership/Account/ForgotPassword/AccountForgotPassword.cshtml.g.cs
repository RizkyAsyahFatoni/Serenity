#pragma checksum "D:\serenity\serintest.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b1f9eb6263a01b46bd36d3993da9bf1725e3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b1f9eb6263a01b46bd36d3993da9bf1725e3b3", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2ae0a23ff1cf4c77d77324c5158a5f2bc2850", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ForgotPassword_AccountForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\serenity\serintest.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ForgotPassword";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_ForgotPasswordPanel\" type=\"text/template\">\r\n    <div>\r\n        <h3 class=\"page-title\">");
#nullable restore
#line 10 "D:\serenity\serintest.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                          Write(Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"form-info\">");
#nullable restore
#line 11 "D:\serenity\serintest.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                        Write(Texts.Forms.Membership.ForgotPassword.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <form id=""~_Form"" action="""">
            <div class=""s-Form"">
                <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                    <div id=""~_PropertyGrid""></div>
                    <div class=""clear""></div>
                </div>
                <div class=""buttons"">
                    <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                        ");
#nullable restore
#line 20 "D:\serenity\serintest.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                   Write(Texts.Forms.Membership.ForgotPassword.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </button>
                </div>
            </div>
        </form>
    </div>
</script>

<div class=""page-content"">
    <div id=""ForgotPasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new Serintest.Membership.ForgotPasswordPanel($('#ForgotPasswordPanel')).init();
});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\nguyenhuuhieu\source\repos\LearningC#\AspNetCoreCookieAuthentication\AspNetCoreCookieAuthentication\Pages\Account\RegisterConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29141ad6f83ffe04e75779bde0cd0f0bc890330a6b5d0419458c660aaa2d5e54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreCookieAuthentication.Pages.Account.Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Pages/Account/RegisterConfirmation.cshtml")]
namespace AspNetCoreCookieAuthentication.Pages.Account
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
#line 1 "C:\Users\nguyenhuuhieu\source\repos\LearningC#\AspNetCoreCookieAuthentication\AspNetCoreCookieAuthentication\Pages\Account\_ViewImports.cshtml"
using AspNetCoreCookieAuthentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"29141ad6f83ffe04e75779bde0cd0f0bc890330a6b5d0419458c660aaa2d5e54", @"/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a4818969730e65d65d40b8c59c04a812d984fa655e1c6b20d4909101b20542b", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7dbd1620f68e15f3eb612dce0a08ac6cfbeb6d24c289defa84c2d04d78670b08", @"/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nguyenhuuhieu\source\repos\LearningC#\AspNetCoreCookieAuthentication\AspNetCoreCookieAuthentication\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\nguyenhuuhieu\source\repos\LearningC#\AspNetCoreCookieAuthentication\AspNetCoreCookieAuthentication\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>\r\n    You account with email ");
#nullable restore
#line 9 "C:\Users\nguyenhuuhieu\source\repos\LearningC#\AspNetCoreCookieAuthentication\AspNetCoreCookieAuthentication\Pages\Account\RegisterConfirmation.cshtml"
                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is registered sucessfully.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
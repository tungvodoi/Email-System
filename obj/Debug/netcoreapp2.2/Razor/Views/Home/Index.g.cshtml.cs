#pragma checksum "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d422e934860ba74b81c499770e759aa3e17f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\_ViewImports.cshtml"
using LoginSystem;

#line default
#line hidden
#line 2 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\_ViewImports.cshtml"
using LoginSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d422e934860ba74b81c499770e759aa3e17f2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37137137e9389806a14ec3f9b6867b4939c5d68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
  
ViewData["Title"] = "Home page";

#line default
#line hidden
#line 4 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
 if(ViewBag.user != null){

#line default
#line hidden
            BeginContext(69, 61, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
            EndContext();
            BeginContext(131, 21, false);
#line 6 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                             Write(ViewBag.user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(152, 581, true);
            WriteLiteral(@"</h1>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-3"">
            <ul class=""list-group"">
                <li class=""list-group-item"">
                    <a href=""/"">Inbox</a>
                </li>
                <li class=""list-group-item"">
                    <a href=""/SentEmail"">Sent</a>
                </li>
                <li class=""list-group-item"">
                    <a href=""/Compose"">Compose</a>
                </li>
            </ul>
        </div>
        <div class=""col"">
            <ul class=""list-group"">
");
            EndContext();
#line 25 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                 foreach(var email in ViewBag.ListEmails){


#line default
#line hidden
            BeginContext(795, 86, true);
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    <a class=\"row-email\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 881, "\"", 943, 2);
            WriteAttributeValue("", 888, "/SentEmail/ViewEmailSent?idEmail=", 888, 33, true);
#line 28 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 921, email.EmailVm.EmailId, 921, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(944, 213, true);
            WriteLiteral(">\r\n                        <div class=\"container\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-2\">\r\n                                    <b class=\"text-dark\">To: ");
            EndContext();
            BeginContext(1158, 21, false);
#line 32 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                                                        Write(email.UserVm.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 138, true);
            WriteLiteral("</b>\r\n                                </div>\r\n                                <div class=\"col-8\">\r\n                                    <b>");
            EndContext();
            BeginContext(1318, 24, false);
#line 35 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                                  Write(email.EmailVm.EmailTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 48, true);
            WriteLiteral("</b>\r\n                                    <span>");
            EndContext();
            BeginContext(1391, 26, false);
#line 36 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                                     Write(email.EmailVm.EmailContent);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 170, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                  <div class=\"col-1\">\r\n                                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1587, "\"", 1642, 2);
            WriteAttributeValue("", 1594, "/Home/DeleteEmail?idEmail=", 1594, 26, true);
#line 39 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 1620, email.EmailVm.EmailId, 1620, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1643, 317, true);
            WriteLiteral(@">
                                        <i class=""fa fa-trash-o"" aria-hidden=""true""></i>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </a>
                  
                </li>
");
            EndContext();
#line 48 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1979, 57, true);
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 54 "C:\Users\tung1\OneDrive\Desktop\LoginSystem\Views\Home\Index.cshtml"

}

#line default
#line hidden
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
#pragma checksum "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa04c6deb6563e451f541e11a8005c7d0a64420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites;

#line default
#line hidden
#line 2 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa04c6deb6563e451f541e11a8005c7d0a64420", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e21af70e33a7c205d8bf678bceb4feaec54d3ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartyInvites.Models.GuestResponse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
  
	ViewData["Title"] = "ListResponses";

#line default
#line hidden
            BeginContext(101, 179, true);
            WriteLiteral("\r\n<h1>Lista gości na przyjęciu</h1>\r\n\r\n<table>\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Imię i Nazwisko</th>\r\n\t\t\t<th>Adres e-mail</th>\r\n\t\t\t<th>Numer telefonu</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 17 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
         foreach (PartyInvites.Models.GuestResponse r in Model)
		{

#line default
#line hidden
            BeginContext(344, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(362, 6, false);
#line 20 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
               Write(r.Name);

#line default
#line hidden
            EndContext();
            BeginContext(368, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(384, 7, false);
#line 21 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
               Write(r.Email);

#line default
#line hidden
            EndContext();
            BeginContext(391, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(407, 7, false);
#line 22 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
               Write(r.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(414, 17, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 24 "D:\C#\nauka\ASPNetCoreMVC\PierwszyProjektZKsiążki\PartyInvites\PartyInvites\Views\Home\ListResponses.cshtml"
		}

#line default
#line hidden
            BeginContext(436, 19, true);
            WriteLiteral("\t</tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartyInvites.Models.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591

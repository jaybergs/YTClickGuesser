#pragma checksum "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf1a370cb026645d80d07ce1777982b0e4760ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluation_Index), @"mvc.1.0.view", @"/Views/Evaluation/Index.cshtml")]
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
#line 1 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\_ViewImports.cshtml"
using YTClickGuesserV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\_ViewImports.cshtml"
using YTClickGuesserV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf1a370cb026645d80d07ce1777982b0e4760ae", @"/Views/Evaluation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d39a40a123bebcef964cd8618a90aeaf500bc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EvaluationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Evaluation</h1>\r\n<br />\r\nAufrufe: ");
#nullable restore
#line 6 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
    Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nSpieler 1: ");
#nullable restore
#line 8 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
      Write(Model.Player1Guess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nSpieler 2: ");
#nullable restore
#line 10 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
      Write(Model.Player2Guess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 12 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
Write(Model.WinnerMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nAktueller Punktestand:\r\n<br />\r\n<table cellpadding=\"10\">\r\n    <tr>\r\n        <td align=\"center\">Spieler 1</td>\r\n        <td align=\"center\">Spieler 2</td>\r\n    </tr>\r\n    <tr>\r\n        <td align=\"center\"><bold>");
#nullable restore
#line 22 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
                            Write(Context.Session.GetInt32("player1Score"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</bold></td>\r\n        <td align=\"center\"><bold>");
#nullable restore
#line 23 "E:\Schule\Projekt\YTClickGuesserV2\YTClickGuesserV2\Views\Evaluation\Index.cshtml"
                            Write(Context.Session.GetInt32("player2Score"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</bold></td>\r\n    </tr>\r\n</table>\r\n<a href=\"Home\"><input type=\"button\" value=\"nächste Runde\" /></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EvaluationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
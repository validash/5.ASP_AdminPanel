#pragma checksum "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356bac93eee3474f1a476b508e0c5ab5aedaff27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Book_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok_AdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356bac93eee3474f1a476b508e0c5ab5aedaff27", @"/Areas/Manage/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4067280b1c4f8b48b0b8effc56c86c83480e07b", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10 mx-auto"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th>Name</th>
                        <th>CostPrice</th>
                        <th>SalePrice</th>
                        <th>AuthorName</th>
                        <th>GenreName</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                     foreach (var book in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                       Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                       Write(book.CostPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                       Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                       Write(book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                       Write(book.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\Users\99470\source\repos\Pustok_AdminPanel\Pustok_AdminPanel\Areas\Manage\Views\Book\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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

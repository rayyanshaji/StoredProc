#pragma checksum "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "844e49cd8ccc8881f6b066972b0482c309c97cbd"
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
#line 1 "C:\Users\Rayyan\source\repos\StoredProc\Views\_ViewImports.cshtml"
using StoredProc;

#line default
#line hidden
#line 2 "C:\Users\Rayyan\source\repos\StoredProc\Views\_ViewImports.cshtml"
using StoredProc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844e49cd8ccc8881f6b066972b0482c309c97cbd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcae9b9953f8ad0b91ee8dbe30dad45ccf662a48", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoredProc.Models.PurchaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 222, true);
            WriteLiteral("    ViewBag.Title = \"get\";\r\n}\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post, new { id = "myForm" }))
{

#line default
#line hidden
            BeginContext(347, 132, true);
            WriteLiteral("        <table border=\"1\" width=\"500\" height=\"300\" bgcolor=\"white\">\r\n            <tr>\r\n                <td>PurchaseOrderId No</td>\r\n");
            EndContext();
            BeginContext(689, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(710, 86, false);
#line 15 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(model=>model.PurchaseOrderId , new { oninput = "checkinputstate();" }));

#line default
#line hidden
            EndContext();
            BeginContext(796, 46, true);
            WriteLiteral("</td>\r\n                <td style=\"color:red;\">");
            EndContext();
            BeginContext(843, 58, false);
#line 16 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                                  Write(Html.ValidationMessageFor(model => model.PurchaseOrderId ));

#line default
#line hidden
            EndContext();
            BeginContext(901, 165, true);
            WriteLiteral("</td>\r\n                <td> <button type=\"submit\" name=\"btnSubmit\" id=\"btnSubmit\" class=\"btn btn-default\">Submit</button></td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 20 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1069, 470, true);
            WriteLiteral(@"
<table>
    <tr>
        <td>Line Number</td>

    </tr>
    <tr>
        <td>Unit Price</td>

    </tr>

    <tr>
        <td>ProductID</td>

    </tr>
</table>

<table style=""width:100%"">
    <tr>
        <th>LineNumber</th>
        <th>UnitPrice</th>
        <th>ProductID</th>
        <th>Order QTY</th>
        <th>Receieve QTY</th>
        <th>Reject</th>
        <th>Due Date</th>
    </tr>
    <tr>
        <td> <p name=""LineNumber"">");
            EndContext();
            BeginContext(1540, 16, false);
#line 49 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                             Write(Model.LineNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"UnitPrice\">");
            EndContext();
            BeginContext(1602, 15, false);
#line 50 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"ProductID\">");
            EndContext();
            BeginContext(1663, 15, false);
#line 51 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.ProductID);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"ProductID\">");
            EndContext();
            BeginContext(1724, 14, false);
#line 52 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.OrderQty);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"ProductID\">");
            EndContext();
            BeginContext(1784, 17, false);
#line 53 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.ReceivedQty);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"ProductID\">");
            EndContext();
            BeginContext(1847, 17, false);
#line 54 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.RejectedQty);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 45, true);
            WriteLiteral("</p> </td>\r\n        <td> <p name=\"ProductID\">");
            EndContext();
            BeginContext(1910, 13, false);
#line 55 "C:\Users\Rayyan\source\repos\StoredProc\Views\Home\Index.cshtml"
                            Write(Model.DueDate);

#line default
#line hidden
            EndContext();
            BeginContext(1923, 483, true);
            WriteLiteral(@"</p> </td>
    </tr>
</table>

<script>
    var states = document.getElementById(""PurchaseOrderId"");
    const form = document.getElementById(""myForm"");

    var len = states.value.trim().length;
    
    function checkinputstate() {
        console.log(len);
        if (len == 0 || len == '' || len == null) {
            states.style.borderColor = ""red"";
        } else if (len > 0) {
            states.style.borderColor = ""green"";
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoredProc.Models.PurchaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

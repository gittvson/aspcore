#pragma checksum "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b5aa562625c0a82cf0d363cc094f9a91466113e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_hanghoa_indexHH), @"mvc.1.0.view", @"/Views/hanghoa/indexHH.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/hanghoa/indexHH.cshtml", typeof(AspNetCore.Views_hanghoa_indexHH))]
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
#line 1 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\_ViewImports.cshtml"
using Buoi4;

#line default
#line hidden
#line 2 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\_ViewImports.cshtml"
using Buoi4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5aa562625c0a82cf0d363cc094f9a91466113e", @"/Views/hanghoa/indexHH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852a5230491e1ab6bcbf4d08b671347db24431ec", @"/Views/_ViewImports.cshtml")]
    public class Views_hanghoa_indexHH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Buoi4.Models.Hanghoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
  
    ViewBag.Title = "Quản lý hàng hóa";
    Layout = "~/Views/_LayoutPage1.cshtml";

#line default
#line hidden
            BeginContext(135, 65, true);
            WriteLiteral("<h2>Quản lý hàng hóa</h2>\r\n<button class=\"btn btn-success\">\r\n    ");
            EndContext();
            BeginContext(201, 95, false);
#line 8 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
Write(Html.ActionLink("Thêm hàng hóa", "Create", new { @class = "text-decoration-none .text-reset" }));

#line default
#line hidden
            EndContext();
            BeginContext(296, 166, true);
            WriteLiteral("\r\n</button>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            hinh\r\n        </th>\r\n        <th>\r\n            hinh\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(463, 42, false);
#line 19 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(549, 43, false);
#line 22 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(636, 45, false);
#line 25 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(681, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(725, 42, false);
#line 28 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(811, 55, false);
#line 31 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(866, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(910, 53, false);
#line 34 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(963, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1051, 52, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1103, "\"", 1149, 1);
#line 42 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
WriteAttributeValue("", 1109, Html.DisplayFor(modelItem => item.Hinh), 1109, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1150, 58, true);
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1209, 39, false);
#line 45 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1304, 41, false);
#line 48 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1401, 42, false);
#line 51 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1499, 44, false);
#line 54 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1599, 41, false);
#line 57 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1696, 54, false);
#line 60 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1806, 52, false);
#line 63 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1914, 57, false);
#line 66 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Sửa", "suaHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1992, 62, false);
#line 67 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Chi tiết", "xemHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2075, 57, false);
#line 68 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Xóa", "xoaHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
    }

#line default
#line hidden
            BeginContext(2175, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Buoi4.Models.Hanghoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591

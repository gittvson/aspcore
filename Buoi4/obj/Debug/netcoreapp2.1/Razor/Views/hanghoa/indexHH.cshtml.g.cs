#pragma checksum "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad64a08052f0ac2eb4fd3d94b641bf714fb591c8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad64a08052f0ac2eb4fd3d94b641bf714fb591c8", @"/Views/hanghoa/indexHH.cshtml")]
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
            BeginContext(135, 36, true);
            WriteLiteral("<h2>Quản lý hàng hóa</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(172, 42, false);
#line 8 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
Write(Html.ActionLink("Thêm hàng hóa", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(214, 69, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>ul\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(284, 42, false);
#line 13 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(370, 43, false);
#line 16 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(457, 45, false);
#line 19 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(546, 42, false);
#line 22 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(588, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(632, 55, false);
#line 25 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(687, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(731, 53, false);
#line 28 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
       Write(Html.DisplayNameFor(model => model.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(784, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(872, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(921, 41, false);
#line 36 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(962, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1018, 42, false);
#line 39 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1116, 44, false);
#line 42 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1216, 41, false);
#line 45 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1313, 54, false);
#line 48 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1423, 52, false);
#line 51 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.DisplayFor(modelItem => item.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1531, 57, false);
#line 54 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Sửa", "suaHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1609, 62, false);
#line 55 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Chi tiết", "xemHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1692, 57, false);
#line 56 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
           Write(Html.ActionLink("Xóa", "xoaHH", new { id = item.Mahang }));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\indexHH.cshtml"
    }

#line default
#line hidden
            BeginContext(1792, 8, true);
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
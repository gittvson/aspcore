#pragma checksum "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d0dd08ad64564452deb508124b3791b01538d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_hanghoa_xemHH), @"mvc.1.0.view", @"/Views/hanghoa/xemHH.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/hanghoa/xemHH.cshtml", typeof(AspNetCore.Views_hanghoa_xemHH))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d0dd08ad64564452deb508124b3791b01538d2", @"/Views/hanghoa/xemHH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852a5230491e1ab6bcbf4d08b671347db24431ec", @"/Views/_ViewImports.cshtml")]
    public class Views_hanghoa_xemHH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Buoi4.Models.Hanghoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
  
    ViewBag.Title = "Quản lý hàng hóa";
    Layout = "~/Views/_LayoutPage1.cshtml";

#line default
#line hidden
            BeginContext(122, 36, true);
            WriteLiteral("<h2>Quản lý hàng hóa</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(159, 42, false);
#line 8 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
Write(Html.ActionLink("Thêm hàng hóa", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(201, 79, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(281, 42, false);
#line 13 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(323, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(369, 43, false);
#line 16 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(412, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(458, 45, false);
#line 19 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(503, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(549, 42, false);
#line 22 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(591, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(637, 54, false);
#line 25 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.loaihanghoa.Maloai));

#line default
#line hidden
            EndContext();
            BeginContext(691, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(737, 55, false);
#line 28 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(792, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(838, 52, false);
#line 31 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.nhasanxuat.Mansx));

#line default
#line hidden
            EndContext();
            BeginContext(890, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(936, 53, false);
#line 34 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayNameFor(model => model.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(989, 84, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-6\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1074, 42, false);
#line 40 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.Mahang));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1162, 43, false);
#line 43 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.Tenhang));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1251, 45, false);
#line 46 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.Donvitinh));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1342, 42, false);
#line 49 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.Dongia));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1430, 54, false);
#line 52 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.loaihanghoa.Maloai));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1530, 55, false);
#line 55 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.loaihanghoa.Tenloai));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1631, 52, false);
#line 58 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.nhasanxuat.Mansx));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1729, 53, false);
#line 61 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\hanghoa\xemHH.cshtml"
       Write(Html.DisplayFor(modelItem => Model.nhasanxuat.Tennsx));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Buoi4.Models.Hanghoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
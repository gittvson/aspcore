#pragma checksum "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a3e9cd62094c8855240e938d34501188ac2f356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_indexDangNhap), @"mvc.1.0.view", @"/Views/indexDangNhap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/indexDangNhap.cshtml", typeof(AspNetCore.Views_indexDangNhap))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3e9cd62094c8855240e938d34501188ac2f356", @"/Views/indexDangNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"852a5230491e1ab6bcbf4d08b671347db24431ec", @"/Views/_ViewImports.cshtml")]
    public class Views_indexDangNhap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Buoi4.Models.Khachhang>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
  
    ViewBag.Title = "Đăng nhập";
    Layout = "~/Views/_LayoutPage1.cshtml";

#line default
#line hidden
            BeginContext(119, 29, true);
            WriteLiteral("<h2>Đăng nhập hệ thống</h2>\r\n");
            EndContext();
#line 8 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
 using (Html.BeginForm("dangnhap", "khachhang", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(223, 23, false);
#line 10 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(248, 59, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(308, 64, false);
#line 13 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(372, 218, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <div class=\"control-label\">\r\n                <span class=\"font-weight-bold\">Tên tài khoản</span>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(591, 164, false);
#line 19 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
           Write(Html.EditorFor(model => model.Makh, new
                {
                    htmlAttributes
               = new { @class = "form-control" }
                }));

#line default
#line hidden
            EndContext();
            BeginContext(755, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(774, 132, false);
#line 24 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
           Write(Html.ValidationMessageFor(model => model.Makh, "", new
                {
               @class = "text-danger"
                }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 249, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"control-label\">\r\n                <span class=\"font-weight-bold\">Mật khẩu</span>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                ");
            EndContext();
            BeginContext(1156, 149, false);
#line 35 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
           Write(Html.PasswordFor(model => model.Password, new
                {
               htmlAttributes = new { @class = "form-control" }
                }));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1324, 102, false);
#line 39 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "",
               new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 243, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Đăng nhập\" class=\"btn btnprimary\" />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
         if (ViewBag.kiemtraDangnhap != null &&
      (bool)ViewBag.kiemtraDangnhap == false)
        {

#line default
#line hidden
            BeginContext(1776, 329, true);
            WriteLiteral(@"            <div class=""form-group"">
                <div class=""control-label col-md-12"">
                    <span class=""font-weight-bold text-danger"">
                        Bạn nhập
                        ""Tên tài khoản"" hay ""Mật khẩu"" bị sai!
                    </span>
                </div>
            </div>
");
            EndContext();
#line 59 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
        }

#line default
#line hidden
            BeginContext(2116, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 61 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
}

#line default
#line hidden
            BeginContext(2131, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(2143, 48, false);
#line 63 "C:\Users\Son\Desktop\Buoi4\Buoi4\Views\indexDangNhap.cshtml"
Write(Html.ActionLink("Trở về", "indexNV", "nhanvien"));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Buoi4.Models.Khachhang> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81846f9bb9c37b3889f27e70eeb3e31070f2b90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonHang_TraCuu), @"mvc.1.0.view", @"/Views/DonHang/TraCuu.cshtml")]
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
#line 1 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\_ViewImports.cshtml"
using DOANCuoiKyNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81846f9bb9c37b3889f27e70eeb3e31070f2b90d", @"/Views/DonHang/TraCuu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_DonHang_TraCuu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOANCuoiKyNET.Entities.DonHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
  
    ViewData["Title"] = "TraCuu";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<!-- My Account Start -->
<div class=""my-account"">
    <div class=""container-fluid"">
        <div class=""row"">

            <div class=""col-md-12"">


                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>ID</th>

                                <th>Ngày đặt hàng</th>
                                <th>Tên người nhận</th>
                                <th>Tổng tiền</th>
                                <th>Trạng thái</th>
                                <th>Ghi chú</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 33 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 38 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.idDH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.ngayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.tenDH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.tongSoTien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                                <td>");
#nullable restore
#line 42 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.trangThai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                               Write(item.ghiChu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                \r\n                            </tr>\r\n");
#nullable restore
#line 46 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DonHang\TraCuu.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- My Account End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOANCuoiKyNET.Entities.DonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591

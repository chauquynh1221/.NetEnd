#pragma checksum "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DoiMatKhau\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72f0011af90ecc74bd4bb9b7c15ec5831f12889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoiMatKhau_Index), @"mvc.1.0.view", @"/Views/DoiMatKhau/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72f0011af90ecc74bd4bb9b7c15ec5831f12889", @"/Views/DoiMatKhau/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83297bd0c9e261438ceedc5b160444321d90896b", @"/Views/_ViewImports.cshtml")]
    public class Views_DoiMatKhau_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\STUDY NET.MVC\ThuongMaiDienTu\DOANeCommerce\DOANCuoiKyNET\Views\DoiMatKhau\Index.cshtml"
  
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-6"">
    <label>Nhập mật khẩu mới</label>
    <input class=""form-control"" id=""qmk"" type=""text"" placeholder=""Nhập mật khẩu mới"">
    <input class=""form-control"" id=""reqmk"" type=""text"" placeholder=""Nhập lại mật khẩu mới"">
</div>
<div class=""col-md-12"">
    <button class=""btn"" id=""xacnhan"">Xác nhận</button>
</div>
<div id=""kqua"" style=""color:red""></div>


<script>

    $(document).ready(function () {
        $(""#xacnhan"").click(function () {
            if ($(""#qmk"").val() != $(""#reqmk"").val()) {
                $(""#kqua"").html(""Mật khẩu không trùng khớp!"")
            } else {
                $.ajax({

                    url: ""/DoiMatKhau/LuuMatKhau/"",
                    data: {
                        qmk: $(""#qmk"").val().trim(),

                    },
                    type: ""POST"",
                    success: function (data) {

                        if (data == ""0"") {
                            $(""#kqua"").html(""Đổi mật khẩu không thành công!"")
        ");
            WriteLiteral(@"                }
                        else {
                            window.location = ""/Home/index/""
                        }

                    },
                });

            }
           
             
            

        });
    });
</script>
");
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

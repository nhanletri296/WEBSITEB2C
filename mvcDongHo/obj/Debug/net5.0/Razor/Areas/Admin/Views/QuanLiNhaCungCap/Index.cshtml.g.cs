#pragma checksum "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b420eba0f6db9222b8339c752061b4525cf0ecfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_QuanLiNhaCungCap_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/QuanLiNhaCungCap/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b420eba0f6db9222b8339c752061b4525cf0ecfa", @"/Areas/Admin/Views/QuanLiNhaCungCap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_QuanLiNhaCungCap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvcDongHo.Areas.Admin.ViewModels.NhaCungCapView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("simple-results.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLiNhaCungCap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SuaNhaCungCap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--để nó hiểu những biến trong viewmodel-->\r\n");
#nullable restore
#line 6 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml"; //dùng lại layout ở share


#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<div>\r\n    <!-- Thanh tìm kiếm -->\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 offset-md-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b420eba0f6db9222b8339c752061b4525cf0ecfa5327", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""search"" class=""form-control form-control-lg"" placeholder=""Tìm kiếm"">
                        <div class=""input-group-append"">
                            <button type=""submit"" class=""btn btn-lg btn-default"">
                                <i class=""fa fa-search""></i>
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<br>
<!-- end search  -->
<!--begin table-->
<table class=""table table-striped"" style=""width: 96%; margin-left: 2%; border:1px solid #dee2e6;"">
    <thead>
        <tr>
            <th scope=""col"">Mã nhà cung cấp</th>
            <th scope=""col"">Tên nhà cung cấp</th>
            <th scope=""col"">Địa chỉ</th>
            <th scope=""col"">Số điện thoại</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 45 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
         if (Model.NhaCungCap != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
             foreach (var item in Model.NhaCungCap)//tạo vòng lặp để duyệt từng phần tử trong viewbag để show ra
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
           Write(item.IDNhaCungCap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><!--show ra mã nhà cung cấp-->\r\n            <td>");
#nullable restore
#line 52 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
           Write(item.TenNhacungCap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><!--show ra tên nhà cung cấp-->\r\n            <td>");
#nullable restore
#line 53 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
           Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><!--show ra địa chỉ-->\r\n            <td>");
#nullable restore
#line 54 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><!--show ra số điện thoại-->\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b420eba0f6db9222b8339c752061b4525cf0ecfa9529", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
                                                                                                                                     WriteLiteral(item.IDNhaCungCap);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <!--đi vào area Admin, QuanLiNhaCungCapController thực hiện hàm SuaNhaCungCap, còn cái asp-route-id thì là nó định danh id cho cái nút sửa để khi click vào mình lấy được cái mã-->
            </td>
            <td>
                <button id=""xoanhacungcap"" data-toggle=""modal"" data-target=""#exampleModalCenter"" class=""btn btn-block btn-danger"" data-id=""");
#nullable restore
#line 60 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
                                                                                                                                      Write(item.IDNhaCungCap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n                <!--phần data-toggle và data-target để show cái model ở dưới của bootstrap, data-id là gán IDThuonghieu cho thằng data-id -->\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n");
#nullable restore
#line 73 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
                                                                                     
    var prevDisabled = !Model.NhaCungCap.HasPreviousPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
                                                                                  
    var nextDisabled = !Model.NhaCungCap.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b420eba0f6db9222b8339c752061b4525cf0ecfa14397", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3285, "btn", 3285, 3, true);
            AddHtmlAttributeValue(" ", 3288, "btn-default", 3289, 12, true);
#nullable restore
#line 79 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
AddHtmlAttributeValue(" ", 3300, prevDisabled, 3301, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
             WriteLiteral(Model.NhaCungCap.PageIndex -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b420eba0f6db9222b8339c752061b4525cf0ecfa17016", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3485, "btn", 3485, 3, true);
            AddHtmlAttributeValue(" ", 3488, "btn-default", 3489, 12, true);
#nullable restore
#line 82 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
AddHtmlAttributeValue(" ", 3500, nextDisabled, 3501, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Areas\Admin\Views\QuanLiNhaCungCap\Index.cshtml"
             WriteLiteral(Model.NhaCungCap.PageIndex +1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!--Thẻ show lên xác nhận xóa hay không-->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn có chắc chắn muốn xóa?
            </div>
            <div class=""modal-footer"" id=""footer-del"">

            </div>
        </div>
    </div>
</div>
<!--Kết thúc thẻ xác nhận không có gì đặc biệt-->
<!--end table-->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script><!--thêm cái link để xài jquery ");
            WriteLiteral(@"cái này anh An chỉ tui-->
<script type=""text/javascript"">
//viết jquery, do xài cái model để xác nhận có muốn xóa hay không thì mình không lấy mã trực tiếp như cái sửa được nên phải viết thêm cái này
    $(""button#xoanhacungcap"").click(function ()//tạo sự kiên click cho cái button ở trên theo cú pháp của jquery: ""tenthe#mã thẻ""
    {
        var id = $(this).data(""id"");//gán IDNhaCungCap đã được lưu vào data-id ở trên để gán vào biến id
        var obj = '<a class=""btn btn-success"" href=""https://localhost:44365/Admin/QuanLiNhaCungCap/XoaNhaCungCapData/' + id + '"">Có</a>'
            + '<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Không</button>';//tạo biến obj để lưu lại cái html mình cần xuất ra, cái này tui không quá rõ
        //nhưng mà cứ làm theo thôi, hok khó
        $(""div#footer-del"").html(obj);//gọi cái thẻ div có mã là footer-del để chèn phần html zo
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvcDongHo.Areas.Admin.ViewModels.NhaCungCapView> Html { get; private set; }
    }
}
#pragma warning restore 1591
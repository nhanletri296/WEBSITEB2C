#pragma checksum "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Views\Home\Contactus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aecf518dc616cb387cd93c6bfc90ffdeff5bb91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contactus), @"mvc.1.0.view", @"/Views/Home/Contactus.cshtml")]
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
#line 1 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aecf518dc616cb387cd93c6bfc90ffdeff5bb91", @"/Views/Home/Contactus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f619a021c3a4fc8c6c2602263026014d9744933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contactus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Views\Home\Contactus.cshtml"
  
    ViewBag.Title = "Liên hệ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start All Title Box -->
<div style=""background: url(/images/bg1.jpg)"" class=""all-title-box"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>Liên hệ với chúng tôi</h2>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 420, "\"", 453, 1);
#nullable restore
#line 13 "C:\Users\QHung\Documents\GitHub\CNPM-CA\mvcDongHo\Views\Home\Contactus.cshtml"
WriteAttributeValue("", 427, Url.Action("Shop","Home"), 427, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Sản Phẩm</a></li>
                    <li class=""breadcrumb-item active""> Liên hệ </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- End All Title Box -->
<!-- Start Contact Us  -->
<div class=""contact-box-main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-sm-12"">
                <div class=""contact-form-right"">
                    <h2>Thông tin của bạn</h2>
                    <p>Vui lòng nhập đầy đủ thông tin, chúng tôi sẽ hỗ trợ bạn một cách nhanh nhất  </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aecf518dc616cb387cd93c6bfc90ffdeff5bb914977", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" id=""name"" name=""name"" placeholder=""Tên của bạn"" required data-error=""Vui lòng điền vào ô này"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""text"" placeholder=""Email"" id=""email"" class=""form-control"" name=""name"" required data-error=""Vui lòng điền vào ô này"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-grou");
                WriteLiteral(@"p"">
                                    <input type=""text"" class=""form-control"" id=""subject"" name=""name"" placeholder=""Tiêu đề"" required data-error=""Vui lòng điền vào ô này"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control"" id=""message"" placeholder=""Vấn đề của bạn"" rows=""4"" data-error=""Vui lòng điền vào ô này"" required></textarea>
                                    <div class=""help-block with-errors""></div>
                                </div>
                                <div class=""submit-button text-center"">
                                    <button class=""btn hvr-hover"" id=""submit"" type=""submit"">Gửi</button>
                                    <div id=""msgSubmit"" class=""h3 text-center hidden""></div>
           ");
                WriteLiteral("                         <div class=\"clearfix\"></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
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
            <div class=""col-lg-4 col-sm-12"">
                <div>
                    <h2>Thông tin liên hệ</h2>
                    <p>
                        Thời gian tự nhiên thì vô hạn nhưng mỗi người lại chỉ có một số năm hữu hạn để sống. Thậm chí, chẳng ai biết được liệu ngày mai mình có còn hiện diện trên cuộc đời này. Vì vậy, hãy sống theo cách bạn muốn, chọn những thứ bạn cảm thấy phù hợp và theo đuổi những điều bạn thực sự yêu thích. Đừng sống theo định hướng, mong muốn của người khác bởi họ không thể vẽ đường mãi cho bạn được.
                        Cuộc đời là của mình, hãy dùng thời gian mình có để thực hiện những hoài bão, đam mê nhé!
                    </p>
                    <ul>
                        <li>
                            <p><i class=""fas fa-map-marker-alt""></i>Địa chỉ: 273 An Dương Vương, Hồ Chí Minh </p>
                        </li>
                        <li>
                            <p><i class=""fas fa-phone");
            WriteLiteral(@"-square""></i>Điện thoại: <a href=""tel:+84988325962"">+84 7777 99999 0</a></p>
                        </li>
                        <li>
                            <p><i class=""fas fa-envelope""></i>Email: <a href=""mailto:contactinfo@gmail.com"">quochung5962@gmail.com</a></p>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Cart -->
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

#pragma checksum "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4091efd689bff6f45adbd8ce3db6e43c08a94c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Detail), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Detail.cshtml")]
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
#line 1 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\_ViewImports.cshtml"
using EStoreWeb1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\_ViewImports.cshtml"
using EStoreWeb1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4091efd689bff6f45adbd8ce3db6e43c08a94c59", @"/Areas/Customer/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a7f7723204e65f25e41212965f06e900db046d", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"row-md-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 75, "\"", 97, 2);
            WriteAttributeValue("", 81, "/", 81, 1, true);
#nullable restore
#line 4 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml"
WriteAttributeValue("", 82, Model.ImageUrl, 82, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px\" />\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        <p>\r\n            Tên sản phẩm: ");
#nullable restore
#line 8 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            Giá sản phẩm: <span class=\"price\">");
#nullable restore
#line 11 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml"
                                         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4091efd689bff6f45adbd8ce3db6e43c08a94c595103", async() => {
                WriteLiteral("\r\n            <i class=\"bi bi-cart\"></i> Add To Cart\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml"
                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p>\r\n            Thông tin mô tả: <br />\r\n            ");
#nullable restore
#line 18 "D:\HOC_TAP\LTrinh_Web_NangCao\test\EStoreWeb1\EStoreWeb1\Areas\Customer\Views\Home\Detail.cshtml"
       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

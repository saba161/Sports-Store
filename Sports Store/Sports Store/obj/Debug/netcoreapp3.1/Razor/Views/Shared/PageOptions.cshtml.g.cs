#pragma checksum "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416c272647de3e7ec16354dee0ecdb844f39c974"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageOptions), @"mvc.1.0.view", @"/Views/Shared/PageOptions.cshtml")]
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
#line 1 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\_ViewImports.cshtml"
using Sports_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\_ViewImports.cshtml"
using Sports_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416c272647de3e7ec16354dee0ecdb844f39c974", @"/Views/Shared/PageOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8567d5cfb350b3f877c59ba9da72c54b4280bc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PageOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid mt-2"">
    <div class=""row m-1"">
        <div class=""col""></div>
        <div class=""col-1"">
            <label class=""col-form-label"">Search</label>
        </div>
        <div class=""col-3"">
            <select form=""pageform"" name=""options.searchpropertyname""
                    class=""form-control"">
");
#nullable restore
#line 10 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                 foreach (string s in ViewBag.searches as string[])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416c272647de3e7ec16354dee0ecdb844f39c9743764", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 14 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                    Write(s.IndexOf('.') == -1 ? s : s.Substring(0, s.IndexOf('.')));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                       WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
AddHtmlAttributeValue("", 508, Model.Options.SearchPropertyName == s, 508, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"col\">\r\n            <input form=\"pageform\" class=\"form-control\" name=\"options.searchterm\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 837, "\"", 890, 1);
#nullable restore
#line 22 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
WriteAttributeValue("", 865, Model.Options.SearchTerm, 865, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>

        <div class=""col-1 text-right"">
            <button form=""pageform"" class=""btn btn-secondary"" type=""submit"">
                Search
            </button>
        </div>
        <div class=""col""></div>
    </div>
    <div class=""row m-1"">
        <div class=""col""></div>
        <div class=""col-1"">
            <label class=""col-form-label"">Sort</label>
        </div>
        <div class=""col-3"">
            <select form=""pageform"" name=""options.OrderPropertyName""
                    class=""form-control"">
");
#nullable restore
#line 40 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                 foreach (string s in ViewBag.sorts as string[])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416c272647de3e7ec16354dee0ecdb844f39c9747859", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                    Write(s.IndexOf('.') == -1 ? s : s.Substring(0, s.IndexOf('.')));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                       WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
AddHtmlAttributeValue("", 1606, Model.Options.OrderPropertyName == s, 1606, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""col form-check form-check-inline"">
            <input form=""pageform"" type=""checkbox"" name=""Options.DescendingOrder""
                   id=""Options.DescendingOrder""
                   class=""form-check-input"" value=""true""");
            BeginWriteAttribute("checked", "\r\n                   checked=\"", 2068, "\"", 2128, 1);
#nullable restore
#line 53 "C:\Users\kogo\source\repos\Sports Store\Sports Store\Views\Shared\PageOptions.cshtml"
WriteAttributeValue("", 2098, Model.Options.DescendingOrder, 2098, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <label class=""form-check-label"">Descending Order</label>
        </div>
        <div class=""col-1 text-right"">
            <button form=""pageform"" class=""btn btn-secondary"" type=""submit"">
                Sort
            </button>
        </div>
        <div class=""col""></div>
    </div>
</div>");
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

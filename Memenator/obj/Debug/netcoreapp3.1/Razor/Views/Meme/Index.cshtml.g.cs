#pragma checksum "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38ab9ac7636b089341d36210c8003707f77bbd9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meme_Index), @"mvc.1.0.view", @"/Views/Meme/Index.cshtml")]
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
#line 1 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\_ViewImports.cshtml"
using Memenator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\_ViewImports.cshtml"
using Memenator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ab9ac7636b089341d36210c8003707f77bbd9c", @"/Views/Meme/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c835f3543bec661968fa0f70307237295be6b2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Meme_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Memenator.Models.Data>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Generate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>");
#nullable restore
#line 3 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
Write(Model.memes.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<div>
    <table class=""table table-hover"" >
        <thead>
            <!--displays the column names for the forecast details-->
            <tr class=""table-warning"">

                <th style=""font-size:large; width:200px"">
                   ID
                </th>

                <th class=""tHeading"" style=""width :80px"">
                   NAME
                </th>

                <th>
                    MEME
                </th>
                
                <th style=""width:80px"">

                </th>

            </tr>
        </thead>

        <tbody>

");
#nullable restore
#line 32 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
             foreach (var item in Model.memes)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--displays the properties for each of the forecast-->\r\n                <tr class=\"table-light\">\r\n                    <td >\r\n                        ");
#nullable restore
#line 38 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                     <td >\r\n                             ");
#nullable restore
#line 42 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                    </td>\r\n\r\n\r\n                    <td style=\"width:80px\">\r\n\r\n                        <img");
            BeginWriteAttribute("src", " src= \"", 1198, "\"", 1214, 1);
#nullable restore
#line 49 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
WriteAttributeValue("", 1205, item.url, 1205, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 50px;\" />\r\n                    </td>\r\n\r\n                    <th style=\"width:80px\">\r\n\r\n                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ab9ac7636b089341d36210c8003707f77bbd9c6707", async() => {
                WriteLiteral(" Generate ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
                                                                              WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\pilla\OneDrive\Documents\BCAD 3\PROG 3A\FourthVoyage\Memenator\Views\Meme\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Memenator.Models.Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
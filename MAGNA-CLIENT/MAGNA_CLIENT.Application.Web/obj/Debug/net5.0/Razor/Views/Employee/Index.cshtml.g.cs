#pragma checksum "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48cf6b6ac05faef84ef01150c7c361dcc76b6790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\_ViewImports.cshtml"
using MAGNA_CLIENT.Application.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\_ViewImports.cshtml"
using MAGNA_CLIENT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cf6b6ac05faef84ef01150c7c361dcc76b6790", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08fa568acfd5513ebd3a3c4a308a0e361dc169ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MAGNA_CLIENT.Entities.Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn col-6 mx-auto btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn col-6 mx-auto btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Employee List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <!--breadcrumb-->
 <nav aria-label=""breadcrumb"">
  <ol class=""breadcrumb"">
    <li class=""breadcrumb-item""><a href='/Home'>MAGNA</a></li>
    <li class=""breadcrumb-item""><a href='/Employee'>Employee</a></li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Index</li>
  </ol>
</nav>
");
#nullable restore
#line 15 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
 if (TempData["mensaje_create"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
        <div>
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""currentColor"" class=""bi bi-exclamation-triangle-fill flex-shrink-0 me-2"" viewBox=""0 0 16 16"" role=""img"" aria-label=""Warning:"">
                <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"" />
            </svg>
            ");
#nullable restore
#line 22 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
       Write(TempData["mensaje_create"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n            <span aria-hidden=\"true\">&times;</span>\n        </button>\n    </div>\n");
#nullable restore
#line 28 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
 if (TempData["mensaje_update"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-warning alert-dismissible fade show"" role=""alert"">
        <div>
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""currentColor"" class=""bi bi-exclamation-triangle-fill flex-shrink-0 me-2"" viewBox=""0 0 16 16"" role=""img"" aria-label=""Warning:"">
                <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"" />
            </svg>
            ");
#nullable restore
#line 36 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
       Write(TempData["mensaje_update"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n            <span aria-hidden=\"true\">&times;</span>\n        </button>\n    </div>\n");
#nullable restore
#line 42 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
 if (TempData["mensaje_delete"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-danger alert-dismissible fade show"" role=""alert"">
        <div>
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""currentColor"" class=""bi bi-exclamation-triangle-fill flex-shrink-0 me-2"" viewBox=""0 0 16 16"" role=""img"" aria-label=""Warning:"">
                <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"" />
            </svg>
            ");
#nullable restore
#line 50 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
       Write(TempData["mensaje_delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n            <span aria-hidden=\"true\">&times;</span>\n        </button>\n    </div>\n");
#nullable restore
#line 56 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n        <div class=\"col-sm-6\">\n            <h3>Employee List</h3>\n        </div>\n        <div class=\"col-sm-6\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cf6b6ac05faef84ef01150c7c361dcc76b679012019", async() => {
                WriteLiteral("Add New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n\n   <div class=\"row\">\n");
#nullable restore
#line 68 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
         if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Code</th>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">Start Date</th>

                </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 82 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                 foreach (var employee in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 85 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                       Write(employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 86 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                       Write(employee.EmployeeCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 87 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                       Write(employee.EmployeeFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 88 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                       Write(employee.EmployeeLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 89 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                       Write(employee.EmployeeStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <div class=\"btn-group\" role=\"group\" aria-label=\"basic outlined example\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cf6b6ac05faef84ef01150c7c361dcc76b679016280", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                                                                                   WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cf6b6ac05faef84ef01150c7c361dcc76b679018918", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                                                                                   WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cf6b6ac05faef84ef01150c7c361dcc76b679021556", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
                                                                                   WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 98 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"

                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 102 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>There are no records</p>\n");
#nullable restore
#line 106 "H:\UTN\UTN (IV año)\Sistemas Industriales\MAGNA\MAGNA-CLIENT\MAGNA_CLIENT.Application.Web\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\n\n  <script>\n  //Autoclose\n    window.setTimeout(function(){\n        $(\".alert\").fadeTo(1500,0).slideDown(1000,function(){\n            $(this).remove();\n        });\n    },2000); // 2 segundos y desaparece\n  </script>\n ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MAGNA_CLIENT.Entities.Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

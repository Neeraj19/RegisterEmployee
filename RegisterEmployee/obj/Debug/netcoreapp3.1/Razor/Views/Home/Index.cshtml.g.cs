#pragma checksum "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e5c06b1c8b37afea0e8903a5065da077eed0228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\_ViewImports.cshtml"
using RegisterEmployee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\_ViewImports.cshtml"
using RegisterEmployee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e5c06b1c8b37afea0e8903a5065da077eed0228", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde9676686f17a87ecf39c1ced8bdc01f4a90b57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterEmployee.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "InsertEmployee";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <fieldset>\r\n        <legend>Create Employee</legend>\r\n        <div>\r\n            ");
#nullable restore
#line 14 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 17 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 21 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 24 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 28 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 31 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 38 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 42 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.EmailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 45 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.EmailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.EmailID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 49 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 52 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 53 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 56 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.SecurityQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 60 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.DropDownList("SecurityQuestion", new List<SelectListItem>

                 {
                    new SelectListItem{ Text="City", Value = "City" },
                    new SelectListItem{ Text="Sport", Value = "Sport" },
                    new SelectListItem{ Text="Car", Value = "Car" }
                 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 67 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.SecurityQuestion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 71 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 74 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.EditorFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <p>\r\n            <input class=\"btn btn-success\" type=\"submit\" value=\"Create\" />\r\n        </p>\r\n    </fieldset>\r\n");
#nullable restore
#line 82 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    debugger;\r\n    // Better to keep a Bootstrap popup than jAlert!\r\n\r\n    var result = \'");
#nullable restore
#line 88 "C:\Users\P10433669\source\repos\RegisterEmployee\Views\Home\Index.cshtml"
              Write(TempData["Result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    if (result != \'\' && result != null) {\r\n        alert(result);\r\n        window.location.href = \"/Home/Index\";\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterEmployee.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591

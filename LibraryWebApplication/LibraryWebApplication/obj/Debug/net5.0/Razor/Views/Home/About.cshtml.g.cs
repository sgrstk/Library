#pragma checksum "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93727a08bfc6e9632b7e1288ceb7bf0504ae27b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\_ViewImports.cshtml"
using LibraryWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\_ViewImports.cshtml"
using LibraryWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93727a08bfc6e9632b7e1288ceb7bf0504ae27b2", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2a24af16faf64467c4e480144c3f79a3c0ce34", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About us";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 5 "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93727a08bfc6e9632b7e1288ceb7bf0504ae27b23764", async() => {
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Pattaya&display=swap"" rel=""stylesheet"">
   <style>
         .title p{
              color: green;
              text-align: center;
              font-weight: bold;
              font-size: medium;
         }

         .title p a{
              color: rgb(0, 0, 0);
              font-weight: bold;
         }

         body {
            font-family: Arial, Helvetica, sans-serif;
        }

        * {
            box-sizing: border-box;
        }

        input[type=text], select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-top: 6px;
            margin-bottom: 16px;
            resize: vertical;
        }

        input[type=submit] {
            background-color: #6c499a;
            color: #fff;
            padding: 12px 20px;
            border: none");
                WriteLiteral(@";
            border-radius: 4px;
            cursor: pointer;
        }

            input[type=submit]:hover {
                background-color: #da17e2;
            }

        .container {
            border-radius: 5px;
            background-color: #92a8d1;
            padding: 10px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""title"">
    <center>
    <img  style="" width:700px;height:350px;"" src=""https://jooinn.com/images/school-building-5.jpg"">
   <p>Library Management is a computerized system which helps user (librarian) to manage the library daily activity in electronic format.</p>  
   <button style=""position:center;
   display: inline-block;
   cursor: pointer;
   text-align: center;
   outline: 1px;
   color: #fff;
   background-color: #99CCFF;
   border: none;
   border-radius: 10px;
   box-shadow: 0 7px #CCCCCC;"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 1951, "\"", 2005, 3);
            WriteAttributeValue("", 1961, "location.href=\'", 1961, 15, true);
#nullable restore
#line 75 "C:\Users\Danut\Desktop\p5-t11-razvanclaudiaandreea\LibraryWebApplication\LibraryWebApplication\Views\Home\About.cshtml"
WriteAttributeValue("", 1976, Url.Action("index","Books"), 1976, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2004, "\'", 2004, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Go to Library</button>\n   </center>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
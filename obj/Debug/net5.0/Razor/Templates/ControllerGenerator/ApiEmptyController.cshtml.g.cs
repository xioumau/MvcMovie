#pragma checksum "/home/mauricio/vscodeProjects/app-mvc/MvcMovie/MvcMovie/Templates/ControllerGenerator/ApiEmptyController.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa8dc29f2c1f1a71e778306f6afd0390db9a22c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_ApiEmptyController), @"mvc.1.0.view", @"/Templates/ControllerGenerator/ApiEmptyController.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa8dc29f2c1f1a71e778306f6afd0390db9a22c", @"/Templates/ControllerGenerator/ApiEmptyController.cshtml")]
    public class Templates_ControllerGenerator_ApiEmptyController : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Http;\r\nusing Microsoft.AspNetCore.Mvc;\r\n\r\nnamespace ");
#nullable restore
#line 9 "/home/mauricio/vscodeProjects/app-mvc/MvcMovie/MvcMovie/Templates/ControllerGenerator/ApiEmptyController.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    [Route(\"api/[controller]\")]\r\n    [ApiController]\r\n    public class ");
#nullable restore
#line 13 "/home/mauricio/vscodeProjects/app-mvc/MvcMovie/MvcMovie/Templates/ControllerGenerator/ApiEmptyController.cshtml"
            Write(Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ControllerBase\r\n    {\r\n    }\r\n}");
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

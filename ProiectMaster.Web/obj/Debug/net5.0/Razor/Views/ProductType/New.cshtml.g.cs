#pragma checksum "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\ProductType\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67847036767af0747ee22c7b3bfca7e5182fe42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_New), @"mvc.1.0.view", @"/Views/ProductType/New.cshtml")]
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
#line 1 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67847036767af0747ee22c7b3bfca7e5182fe42c", @"/Views/ProductType/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be194870830f42a069c9ea434231893299df8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductType_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductTypeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\ProductType\New.cshtml"
  
    ViewData["Title"] = "Create a Category";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\ProductType\New.cshtml"
   ViewBag.IsNew = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\smara\Desktop\ProiectMaster\ProiectMaster.Web\Views\ProductType\New.cshtml"
Write(await Html.PartialAsync(@"../Shared/Components/_ProductType.cshtml"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductTypeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

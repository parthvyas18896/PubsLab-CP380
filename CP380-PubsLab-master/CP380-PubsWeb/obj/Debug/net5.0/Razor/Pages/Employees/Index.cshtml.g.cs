#pragma checksum "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a958713934fc64b0cad86374ddb236d69a0f5f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CP380_PubsWeb.Pages.Employees.Pages_Employees_Index), @"mvc.1.0.razor-page", @"/Pages/Employees/Index.cshtml")]
namespace CP380_PubsWeb.Pages.Employees
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
#line 1 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\_ViewImports.cshtml"
using CP380_PubsWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a958713934fc64b0cad86374ddb236d69a0f5f30", @"/Pages/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3383e08ee21d59c03356eeff79ac7a11f773f74", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
  
  //  ViewData["Employees"] = "Employees Name";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Firstname</th>\r\n            <th>Lastname</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
         foreach (var t in Model.Employee)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
           Write(t.Emp_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
           Write(t.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
           Write(t.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\vyasp\OneDrive - Confederation College\Desktop\CP380\PubsLab-CP380\CP380-PubsLab-master\CP380-PubsWeb\Pages\Employees\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CP380_PubsWeb.Pages.Employees.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CP380_PubsWeb.Pages.Employees.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CP380_PubsWeb.Pages.Employees.IndexModel>)PageContext?.ViewData;
        public CP380_PubsWeb.Pages.Employees.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\qkhan1\source\repos\blazorclient1\Pages\CsharpFromJavascript.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e179c831b84b091b5bae98a418ed1356ba3945"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorclient1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using blazorclient1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\qkhan1\source\repos\blazorclient1\_Imports.razor"
using blazorclient1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CsharpFromJavascript")]
    public partial class CsharpFromJavascript : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\qkhan1\source\repos\blazorclient1\Pages\CsharpFromJavascript.razor"
       


    async Task raiseJavafunc()
    {
        await Js.InvokeVoidAsync("my_callToCShap");
    }


    [JSInvokable]
    public static string CallfromJavaScript()
    {
        return "Hello from C#";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
    }
}
#pragma warning restore 1591
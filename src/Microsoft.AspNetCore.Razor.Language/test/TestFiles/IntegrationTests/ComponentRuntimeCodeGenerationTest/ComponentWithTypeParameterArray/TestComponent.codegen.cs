// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class TestComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Item</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
#nullable restore
#line (6,5)-(6,25) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(2, ChildContent(Items1));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "x:\dir\subdir\Test\TestComponent.cshtml"
 foreach (var item in Items2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
#nullable restore
#line (10,9)-(10,27) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(4, ChildContent(item));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "p");
#nullable restore
#line (13,5)-(13,27) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(6, ChildContent(Items3()));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter] public TItem[] Items1 { get; set; }
    [Parameter] public List<TItem[]> Items2 { get; set; }
    [Parameter] public Func<TItem[]> Items3 { get; set; }
    [Parameter] public RenderFragment<TItem[]> ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

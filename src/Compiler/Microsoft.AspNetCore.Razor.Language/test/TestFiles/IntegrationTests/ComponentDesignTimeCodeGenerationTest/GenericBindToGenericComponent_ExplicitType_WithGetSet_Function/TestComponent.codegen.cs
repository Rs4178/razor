﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent<TParam> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((global::System.Action)(() => {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TParam = null!;

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __o = typeof(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                     TParam

#line default
#line hidden
#nullable disable
            );
            __o = global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TParam>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                              ParentValue

#line default
#line hidden
#nullable disable
            );
            __o = global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<TParam>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TParam>(this, 
            global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, UpdateValue, ParentValue)));
            __builder.AddAttribute(-1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
            __o = ((global::Test.MyComponent<TParam>)default).
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                   Value

#line default
#line hidden
#nullable disable
            ;
            __o = ((global::Test.MyComponent<TParam>)default).
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                 Value

#line default
#line hidden
#nullable disable
            ;
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.MyComponent<>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public TParam ParentValue { get; set; } = default;

    public Task UpdateValue(TParam value) { ParentValue = value; return Task.CompletedTask; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

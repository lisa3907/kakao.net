#pragma checksum "D:\github.com\lisa3907\kakao.net\src\kakao.net\Dropdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78aa59e965096a8ce7f1d074f8a0c355e89fe67"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace kakao.net
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Kakao.Net.util;
    public class Dropdown : BootStrapComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 7 "D:\github.com\lisa3907\kakao.net\src\kakao.net\Dropdown.cshtml"
            
    string classname
    {
        get
        {
            var open = IsOpen ? "show" : null;
            var baseclass = IsGroup ? "btn-group" : "dropdown";
            var direction = DropdownDirection != DropdownDirection.Down ? DropdownDirection.ToDescriptionString() : null;
            return $"{baseclass} {direction} {open} {Class}";
        }
    }

    [Parameter] private DropdownDirection DropdownDirection { get; set; } = DropdownDirection.Down;
    [Parameter] private bool IsOpen { get; set; }
    [Parameter] private bool IsGroup { get; set; }
    [Parameter] private string Class { get; set; }
    [Parameter] private RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

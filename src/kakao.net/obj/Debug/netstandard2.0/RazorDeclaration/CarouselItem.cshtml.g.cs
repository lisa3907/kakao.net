#pragma checksum "D:\github.com\lisa3907\kakao.net\src\kakao.net\CarouselItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88a9d590d9e13dce305de27b1783146a67856e6"
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
    public class CarouselItem : BootStrapComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 8 "D:\github.com\lisa3907\kakao.net\src\kakao.net\CarouselItem.cshtml"
            
    private string classname
    {
        get
        {
            var active = IsActive ? "active" : null;
            return $"carousel-item {active} {Class}";
        }
    }
    [Parameter] private string src { get; set; }
    [Parameter] private string alt { get; set; }
    [Parameter] private bool IsActive { get; set; }
    [Parameter] private string Class { get; set; }
    [Parameter] private RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

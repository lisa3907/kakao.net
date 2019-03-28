#pragma checksum "D:\github.com\lisa3907\kakao.net\src\kakao.net\ListGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b7cf8d8268acca38ba41a3054acef0bc05b109"
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
    public class ListGroup : BootStrapComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 7 "D:\github.com\lisa3907\kakao.net\src\kakao.net\ListGroup.cshtml"
            
    string classname
    {
        get
        {
            var flush = IsFlush ? "list-group list-group-flush" : "list-group";
            return $"{flush} {Class}";
        }
    }
    string Tag
    {
        get
        {
            return ListGroupType == ListGroupType.List ? "ul" : "div";
        }
    }
    [Parameter] private ListGroupType ListGroupType { get; set; } = ListGroupType.List;
    [Parameter] private bool IsFlush { get; set; }
    [Parameter] private string Class { get; set; }
    [Parameter] private RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

#pragma checksum "D:\github.com\lisa3907\kakao.net\src\kakao.net\Media.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830f9b15583585f7e63e2c252a0814a69c339170"
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
    public class Media : BootStrapComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 7 "D:\github.com\lisa3907\kakao.net\src\kakao.net\Media.cshtml"
            
    string classname
    {
        get
        {
            return $"{GetClass()} {Class}";
        }
    }
    string Tag
    {
        get
        {
            switch(MediaType)
            {
                case MediaType.Body:
                case MediaType.Media:
                    return "div";
                case MediaType.Heading:
                    return "h5";
                case MediaType.Image:
                    return "img";
                case MediaType.List:
                    return "ul";
                case MediaType.ListItem:
                    return "li";
                default:
                    return "div";
            }
        }
    }
    [Parameter] private MediaType MediaType { get; set; } = MediaType.Media;
    [Parameter] private VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.None;
    [Parameter] private string Class { get; set; }
    [Parameter] private RenderFragment ChildContent { get; set; }

    private string GetVerticalAlignmnet()
    {
        if (VerticalAlignment == VerticalAlignment.Center) return "align-self-center";
        if (VerticalAlignment == VerticalAlignment.Bottom) return "align-self-end";
        if (VerticalAlignment == VerticalAlignment.Bottom) return "align-self-start";
        return null;
    }

    private string GetClass()
    {
        switch (this.MediaType)
        {
            case MediaType.Media:
                return "media";
            case MediaType.Body:
                return "media-body";
            case MediaType.Heading:
                return "mt-0 mb-1";
            case MediaType.Image:
                var verticalAlignment = GetVerticalAlignmnet();
                return $"{verticalAlignment} mr-3";
            case MediaType.List:
                return "list-unstyled";
            case MediaType.ListItem:
                return "media";
            default:
                return "media";
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

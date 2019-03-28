#pragma checksum "D:\github.com\lisa3907\kakao.net\src\kakao.net\BlazorButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c653d33515a9c5e53a6b998f2e4054eef70fc26e"
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
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Kakao.Net;
    using Kakao.Net.util;
    using Microsoft.AspNetCore.Components;
    public class BlazorButton : BootStrapComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "D:\github.com\lisa3907\kakao.net\src\kakao.net\BlazorButton.cshtml"
            
    private string classname
    {
        get
        {
            var outline = IsOutline ? $"btn-outline-{Color.ToDescriptionString()}" : null;
            var color = Color != Color.None ? $"btn-{Color.ToDescriptionString()}" : null;
            var size = Size != Size.None ? $"btn-{Size.ToDescriptionString()}" : null;
            var block = IsBlock ? "btn-block" : null;
            var active = ButtonType == ButtonType.Link && IsActive ? "active" : null;
            var linkDisabled = ButtonType == ButtonType.Link && IsDisabled ? "disabled" : null;
            return $"btn {color} {outline} {size} {block} {active} {linkDisabled} {Class}";
        }
    }

    private string Tag { get; set; } = "button";

    private string pressed
    {
        get
        {
            return IsActive ? "true" : null;
        }
    }

    private string disabled
    {
        get
        {
            return IsDisabled ? "true" : null;
        }
    }

    private string tab
    {
        get
        {
            return IsDisabled ? "-1" : null;
        }
    }

    private string type
    {
        get
        {
            switch (ButtonType)
            {
                case ButtonType.Input:
                case ButtonType.Button:
                    return "button";
                case ButtonType.Submit:
                    return "submit";
                case ButtonType.Reset:
                    return "reset";
                default:
                    return null;
            }
        }
    }

    [Parameter] private Action<UIMouseEventArgs> Onclick { get; set; }
    [Parameter] private Color Color { get; set; } = Color.Primary;

    private ButtonType _buttonType = ButtonType.Button;
    [Parameter] 
    private ButtonType ButtonType
    {
        get
        {
            return _buttonType;
        }
        set
        {
            _buttonType = value;
            switch(_buttonType)
            {
                case ButtonType.Button:
                    Tag = "button";
                    break;
                case ButtonType.Link:
                    Tag = "a";
                    break;
                case ButtonType.Input:
                case ButtonType.Submit:
                case ButtonType.Reset:
                case ButtonType.Radio:
                case ButtonType.Checkbox:
                    Tag = "input";
                    break;
                default:
                    Tag = "button";
                    break;
            }
        }
    }
    [Parameter] private bool IsOutline { get; set; }
    [Parameter] private Size Size { get; set; } = Size.None;
    [Parameter] private bool IsBlock { get; set; }
    [Parameter] private string Value { get; set; }
    [Parameter] private bool IsActive { get; set; }
    [Parameter] private bool IsDisabled { get; set; }
    [Parameter] private string Class { get; set; }
    [Parameter] private RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

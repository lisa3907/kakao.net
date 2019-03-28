#pragma checksum "D:\github.com\lisa3907\kakao.net\src\samples\map\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd362e0470dc464b4e7e6b90be41eecdb3d646ec"
// <auto-generated/>
#pragma warning disable 1591
namespace map.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using map;
    using map.Shared;
    using kakao.net;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<div id=\"map\" style=\"width:100%;height:400px;\"></div>\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddContent(2, "\r\n    ");
            builder.OpenElement(3, "button");
            builder.AddAttribute(4, "class", "btn btn-primary");
            builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, onClickDrawMap));
            builder.AddContent(6, "DrawMap");
            builder.CloseElement();
            builder.AddContent(7, "\r\n    ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "btn btn-primary");
            builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, onClickDrawTraffic));
            builder.AddContent(11, "DrawTraffic");
            builder.CloseElement();
            builder.AddContent(12, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "D:\github.com\lisa3907\kakao.net\src\samples\map\Pages\Index.cshtml"
 
    private async void onClickDrawMap()
    {
        await JSRuntime.InvokeAsync<bool>("kakaoMapInterop.drawMap", 33.450701, 126.570667);
    }

    private async void onClickDrawTraffic()
    {
        await JSRuntime.InvokeAsync<bool>("kakaoMapInterop.drawTraffic", 37.566826, 126.9786567);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\Admin\GisMap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd5341dacb174c3004e9ed3cc7bca73b73a99098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GisMap), @"mvc.1.0.view", @"/Views/Admin/GisMap.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\_ViewImports.cshtml"
using AdminUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\_ViewImports.cshtml"
using AdminUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5341dacb174c3004e9ed3cc7bca73b73a99098", @"/Views/Admin/GisMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GisMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/demo-center.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/giscss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\Admin\GisMap.cshtml"
  
    ViewData["Title"] = "GisMap";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cache.amap.com/lbs/static/main1119.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd5341dacb174c3004e9ed3cc7bca73b73a990984826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd5341dacb174c3004e9ed3cc7bca73b73a990985940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://cache.amap.com/lbs/static/addToolbar.js""></script>
<style>
    html, body, #container {
        height: 100%;
        width: 100%;
    }

    #panel {
        position: absolute;
        background-color: white;
        max-height: 90%;
        overflow-y: auto;
        top: 4.5rem;
        right: 10px;
        width: 280px;
    }
</style>

<div id=""container""></div>
<div class='input-card' style=""left: 6rem; top: 2rem; bottom: auto; width:10rem ; "">
    <div class=""input-item"">
        <i class=""layui-icon"">&#xe857;</i>
        <h3>数据统计</h3>
    </div>
</div>
<div class='input-card' style=""left: 6rem; top: 7rem; bottom: auto;   "">
    <div class=""input-item"">
        <h3>今日警告：0</h3>
    </div>
    <div class=""input-item"">
        <h3>设备在线：60台</h3>
    </div>
    <div class=""input-item"" onclick=""timeOneOverlay()"">
        <h3>设备故障：0台</h3>
    </div>
</div>
<div class=""input-card"" style="" top: 1rem; bottom: auto; width:4rem ; ""> ");
            WriteLiteral(@"<i class=""layui-icon"">&#xe656;</i>   </div>
<div id=""panel"" class=""amap-pl-pc"">
</div>

<script type=""text/javascript"" src=""https://webapi.amap.com/maps?v=1.4.15&key=8ade693bcd1eb762a612032a3040d86a""></script>
<script type=""text/javascript"">
    var list = [{
        ""lnglats"": [116.30748321030424, 40.09450868761932],
        ""name"": ""我是1号"",
        ""address"": ""科技楼"",
        ""lists"": Math.floor(Math.random() * 10 + 1),
        ""Video"": ""http://baidu.com""
    },
    {
        ""lnglats"": [116.30727399800108, 40.09265340437573],
        ""name"": ""我是2号"",
        ""address"": ""图书馆"",
        ""lists"": Math.floor(Math.random() * 10 + 1),
        ""Video"": ""http://baidu.com""
    },
    {
        ""lnglats"": [116.3081966779022, 40.09328128305901],
        ""name"": ""我是3号"",
        ""address"": ""教学楼"",
        ""lists"": Math.floor(Math.random() * 10 + 1),
        ""Video"": ""http://baidu.com""
    },
    {
        ""lnglats"": [116.3047993183136, 40.093232428279656],
        ""name"": ""我是4号"",
        ""addres");
            WriteLiteral(@"s"": ""教学楼3"",
        ""lists"": Math.floor(Math.random() * 10 + 1),
        ""Video"": ""http://baidu.com""
    }
    ];

    $(function () {
        document.getElementById(""panel"").innerHTML = getHtml();
       
    });

    function getHtml() {
        var ulHtml = '<div class=""amap_lib_placeSearch"">' + '<div class=""amap_lib_placeSearch_list"" id=""demo"">';
        ulHtml += '<ul class=""amap_lib_placeSearch_ul"">';
        for (var i = 0; i < list.length; i++) {
            var num = i + 1;
            if (i == 0) {
                ulHtml += '<li class=""poibox selected"" onclick=""getOneOverlay(' + num + ')"">';
            } else {
                ulHtml += '<li class=""poibox"" onclick=""getOneOverlay(' + num + ')"">';
            }
            ulHtml += '<div class=""amap_lib_placeSearch_poi poibox-icon"">' + num + '</div>';
            ulHtml +=
                '<div class=""poi-img"" style=""background-image:url(//store.is.autonavi.com/showpic/0abdba5498776518fe6c187e54cc27de?operate=merge&amp;w=90&a");
            WriteLiteral(@"mp;h=56&amp;position=5)""></div>';
            ulHtml += '<h3 class=""poi-title""><span class=""poi-name"">' + list[i].name +
                '</span><a class=""poi-more"" title=""详情"">&gt;</a></h3>';
            ulHtml += '<div class=""poi-info""><p class=""poi-addr"">' + list[i].address + '</p></div>';
            ulHtml += '<div class=""clear"">' + list[i].lists + '</div>';
            ulHtml += '</li>';
        }
        ulHtml += '</div></div></ul>';
        return ulHtml;
    }

    //选择li
    $(document).ready(function () {

        $('.input-card').click(function () {
            var getClass = $('.amap-pl-pc').attr('class')
            console.log(getClass);
            if (getClass == 'amap-pl-pc') {
                $('.amap-pl-pc').addClass(' display')
            } else if (getClass == 'amap-pl-pc display') {
                $('.amap-pl-pc').removeClass('display')
            }

        });
        $('.poibox').click(function () {
            var getClass = $(this).attr('class')
       ");
            WriteLiteral(@"     if (getClass == 'poibox selected') {
                $(this).removeClass('selected')
            } else if (getClass == 'poibox') {
                $(this).siblings('li').removeClass('selected')
                $(this).addClass(' selected')
            }
        });
    });


    var marker=[];
    // 创建地图实例
    var map = new AMap.Map(""container"", {
        resizeEnable: true
        , content: list[1].lnglats,
        zoom:15
    });
    var markers = [];
    var infoWindow = new AMap.InfoWindow({
        offset: new AMap.Pixel(0, -30)
    });
    for (var i = 0; i < list.length; i++) {
        var lnglat = list[i].lnglats;
        //console.log(lnglat);
        // 创建点实例
        marker = new AMap.Marker({
            position: list[i].lnglats,
            icon: 'https://webapi.amap.com/theme/v1.3/markers/n/mark_b' + (i + 1) + '.png',
            map: map,
            extData: {
                id: i + 1
            }
        });
        //添加marker标记
        markers.push");
            WriteLiteral(@"(marker);
        //添加信息
        if (list[i].lists>5) {
            marker.content = '<div  class=""marker-content warning"" >' + list[i].name + '<br> 地址：' + list[i].address + '</div>';
        }
        else {
            marker.content = '<div  class=""marker-content"" id=""4"">' + list[i].name + '<br> 地址：' + list[i].address + '</div>';
        }
      
        //鼠标点击marker可弹出自定义的信息窗体

        marker.on('click', markerClick);

        marker.emit('click', {
            target: marker
        });


    }

    function markerClick(e) {
        infoWindow.setContent(e.target.content);    
        infoWindow.open(map, e.target.getPosition());
     
    }
    // 将点添加到地图
    map.add(markers);
    map.setFitView();


    

    setInterval(timeOneOverlay, 1000)
    function timeOneOverlay() {

        var targetId = Math.floor(Math.random() * 10 + 1);
        var nul = Math.floor(Math.random() * 3 + 1);
      
       // console.log(targetId);
        var targetMarker;
        targe");
            WriteLiteral(@"tMarker = markers[nul];
        infoWindow.setContent(targetMarker.content)
        infoWindow.open(map, targetMarker.getPosition());


       
        //for (var i = 0; i < markers.length; i++) {
        //    // 获取存在每个 extData 中的 id
        //    var id = markers[i].getExtData().id;


        //    if (id === targetId) {
        //        targetMarker = markers[i];
        //        infoWindow.setContent(targetMarker.content)

        //        infoWindow.open(map, targetMarker.getPosition());
        //        break;
        //    }
        //}
    }

    // 获取当前 id 的覆盖物
    function getOneOverlay(num) {
        var targetId = num;
        var targetMarker;
       
        for (var i = 0; i < markers.length; i++) {
            // 获取存在每个 extData 中的 id
            var id = markers[i].getExtData().id;
          
           
            if (id === targetId) {
                targetMarker = markers[i];
                infoWindow.setContent(targetMarker.content)
                ");
            WriteLiteral("\r\n                infoWindow.open(map, targetMarker.getPosition());\r\n                break;\r\n            }\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
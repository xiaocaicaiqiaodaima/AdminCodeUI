#pragma checksum "D:\AdminCodeUI\AdminUI\Views\Admin\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05ce5e667459caf074b483f8283f0c2cbd27f08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Information), @"mvc.1.0.view", @"/Views/Admin/Information.cshtml")]
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
#line 1 "D:\AdminCodeUI\AdminUI\Views\_ViewImports.cshtml"
using AdminUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AdminCodeUI\AdminUI\Views\_ViewImports.cshtml"
using AdminUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05ce5e667459caf074b483f8283f0c2cbd27f08", @"/Views/Admin/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""layui-hide"" id=""test"" lay-filter=""test""></table>
<script>

    layui.use('table', function () {
        var table = layui.table;
        table.render({
            elem: '#test'
            , url: '/api/Mstb/Getmonitorcurrent'
            , title: '数据表'
            , cols: [[
                { field: 'Mac', title: '站点ID', width: 120, fixed: 'left', align: 'center' }
               
                , { field: 'Ip_Address', title: 'IP', width: 120, align: 'center' }
                , {
                    field: 'Monitor_Value', title: '氢气', align: 'center', width: 150, templet: function (item) {
                        return item.Monitor_Value[0] +' %LEL';
                    }
                }
                , {
                    field: 'Monitor_Value', title: '温度', align: 'center', width: 120, templet: function (item) {
                    return item.Monitor_Value[1] +' C°';
                }}
                , {
                    field: 'Monitor_Value', title");
            WriteLiteral(@": '湿度', align: 'center', width: 120, templet: function (item) {
                        return item.Monitor_Value[2] +'%RH';
                    }}
                , { field: 'Monitor_Time', title: '时间', align: 'center', width: 180 }

            ]]
            , page: true

        });





    });
</script>
");
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

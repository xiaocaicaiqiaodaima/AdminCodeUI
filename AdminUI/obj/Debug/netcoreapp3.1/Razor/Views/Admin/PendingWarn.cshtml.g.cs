#pragma checksum "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\Admin\PendingWarn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8a5d99247284028ef41bad4e913b813cb88ff42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PendingWarn), @"mvc.1.0.view", @"/Views/Admin/PendingWarn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8a5d99247284028ef41bad4e913b813cb88ff42", @"/Views/Admin/PendingWarn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PendingWarn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""layui-hide"" id=""test"" lay-filter=""test""></table>


<script type=""text/html"" id=""barDemo"">
    <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">确认</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del"">误报</a>
</script>
<script>
    layui.use('table', function () {
        var table = layui.table;

        table.render({
            elem: '#test'
            , url: '../lib/datas/Organize.json'
            , cols: [[
                { field: 'DeviceID', title: 'ID', width: 80, fixed: 'left', unresize: true, sort: true }
                , { field: 'StationName', title: '安装位置', width: 120, edit: 'text' }
                , { field: 'PPM', title: '气体浓度', width: 80, edit: 'text', sort: true }
                , { field: 'LEL', title: '%LEL', width: 150 }
                , { field: 'Temperature', title: '温度', width: 100 }
                , { field: 'Humidity', title: '湿度' }
                , { field: 'Ip_Address', title: 'IP', width: 120 }
                , { fi");
            WriteLiteral(@"eld: 'logins', title: '状态', width: 100, sort: true }
                , { field: 'Time', title: '采集时间', width: 120 }
                , { fixed: 'right', title: '操作', toolbar: '#barDemo', width: 150 }
            ]]
            , page: true
        });

        //头工具栏事件
        table.on('toolbar(test)', function (obj) {
            var checkStatus = table.checkStatus(obj.config.id);
            switch (obj.event) {
                case 'getCheckData':
                    var data = checkStatus.data;
                    layer.alert(JSON.stringify(data));
                    break;
                case 'getCheckLength':
                    var data = checkStatus.data;
                    layer.msg('选中了：' + data.length + ' 个');
                    break;
                case 'isAll':
                    layer.msg(checkStatus.isAll ? '全选' : '未全选');
                    break;

                //自定义头工具栏右侧图标 - 提示
                case 'LAYTABLE_TIPS':
                    layer.alert('这是工具栏右侧自定义");
            WriteLiteral(@"的一个图标按钮');
                    break;
            };
        });

        //监听行工具事件
        table.on('tool(test)', function (obj) {
            var data = obj.data;
            //console.log(obj)
            if (obj.event === 'del') {
                layer.confirm('真的删除行么', function (index) {
                    obj.del();
                    layer.close(index);
                });
            } else if (obj.event === 'edit') {
                layer.prompt({
                    formType: 2
                    , value: data.email
                }, function (value, index) {
                    obj.update({
                        email: value
                    });
                    layer.close(index);
                });
            }
        });
    });
</script>");
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

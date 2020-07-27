#pragma checksum "D:\AdminCodeUI\AdminUI\Views\Admin\items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b955cdb4de6f168d1c47d4c30580f1068b1512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_items), @"mvc.1.0.view", @"/Views/Admin/items.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b955cdb4de6f168d1c47d4c30580f1068b1512", @"/Views/Admin/items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""site-tree"">
        <div id=""test1"" class=""demo-tree demo-tree-box""></div>
    </div>

    <div class=""site-content"">

        <div>
            <button class=""layui-btn layui-btn-sm""  onclick=""Add()""><i class=""layui-icon layui-icon-add-1""></i>添加</button>
            <button class=""layui-btn layui-btn-sm"" onclick=""refresh()"" id=""btn-refresh""><i class=""layui-icon layui-icon-refresh""></i>刷新</button>
        </div>
        <table class=""layui-hide"" id=""test"" lay-filter=""test""></table>
    </div>
    <script type=""text/html"" id=""barDemo"">
        <a class=""layui-btn layui-btn-xs"" lay-event=""edit""><i class=""layui-icon layui-icon-edit""></i>编辑</a>
        <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del""><i class=""layui-icon layui-icon-delete""></i>删除</a>
    </script>
<script>


    function Add() {
        layer.open({
            type: 2,
            area: ['730px', '500px'],
            title: ""用户添加"",
            content: '/Admin/ItemsForm',
          ");
            WriteLiteral(@"  btn: ['确定', '关闭'],
            yes: function (index, layero) {
                var sub = layero.find('iframe').contents().find(""#edit"");
                sub.click();
                location.reload();
            }
            , btn2: function () {
                layer.closeAll();
            },
            zIndex: layer.zIndex //重点1
            , success: function (layero) {
                layer.setTop(layero); //重点2
            }

        });
    }


    function refresh(){
        location.reload();

    }

    layui.use(['tree', 'table'], function () {
        var tree = layui.tree, table = layui.table;
        $.ajax({
            url: ""/api/ClientsData/GetItems"",
            type: ""get"",
            dataType: 'json',
            success: function (resut) {
             
                tree.render({
                    elem: '#test1'  
                    , data: resut
                    , click: function (obj) {
                        table.render({
                  ");
            WriteLiteral(@"          elem: '#test'
                            , url: '/api/ClientsData/GetItemsDetail?id=' + obj.data.Id
                            , cols: [[
                                { field: 'F_ItemName', title: '名字', width: 100, fixe: 'left' },
                                { field: 'F_ItemCode', title: '编号', width: 120, fixe: 'left' },
                                { field: 'F_SortCode', title: '排序', width: 80, fixe: 'left' },
                                { field: 'F_EnabledMark', title: '有效', width: 100, fixe: 'left' },
                                { field: 'F_CreatorTime', title: '创建时间', width: 150, fixe: 'left' },
                                { fixed: 'right', title: '操作', toolbar: '#barDemo', width: 250, align: 'center' }
                            ]]
                        });
                    }
                });
            }
        });



 


        //监听行工具事件
        table.on('tool(test)', function (obj) {
            var data = obj.data;
            //console.");
            WriteLiteral(@"log(obj)
            if (obj.event === 'del') {
                layer.confirm('真的删除行么', function (index) {
                    $.ajax({
                        type: ""Delete"",
                        url: ""/api/ItemsDetailDelete"",
                        data: { ""id"": data.F_Id },
                        daaType: ""json"",
                        success: function (ret) {
                            debugger
                            if (ret == ""true"") {
                                layer.msg(""删除成功"", { icon: 1 });
                                obj.del();
                                $("".layui-laypage-btn"").click();
                            }
                            else {
                                layer.msg(""删除失败"", { icon: 2 });
                            }
                        }

                    });
                    layer.close(index);
                });
            } else if (obj.event === 'edit') {

                layer.open({
                    ");
            WriteLiteral(@"type: 2,
                    area: ['730px', '500px'],
                    title: ""编辑"",
                    content: '/Admin/ItemsForm?keyValue=' + data.F_Id,
                    btn: ['确定', '关闭'],
                    yes: function (index, layero) {
                        var sub = layero.find('iframe').contents().find(""#edit"");
                        sub.click();
                    }
                    , btn2: function () {
                        layer.closeAll();
                    },
                    zIndex: layer.zIndex //重点1
                    , success: function (layero, index) {
                        //debugger
                        var body = layer.getChildFrame('body', index);
                        var iframeWin = window[layero.find('iframe')[0]['name']]; //得到iframe页的窗口对象
                        body.find(""#F_Id"").val(data.F_Id);
                        body.find(""#F_ItemName"").val(data.F_ItemName);
                        body.find(""#F_ItemCode"").val(data.F_ItemCod");
            WriteLiteral(@"e);
                        body.find(""#F_SortCode"").val(data.F_SortCode);                     
                        body.find(""#F_ItemId"").val(data.F_ItemId);
                        iframeWin.layui.form.render();
                    }

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

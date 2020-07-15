#pragma checksum "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\Admin\Module.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0a8ef7c59157157331a275af3228c0a406e391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Module), @"mvc.1.0.view", @"/Views/Admin/Module.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0a8ef7c59157157331a275af3228c0a406e391", @"/Views/Admin/Module.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Module : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""layui-form-item"" style=""margin-left:10px;"">
    <button class=""layui-btn layui-btn-sm"" lay-event=""add"" id=""add""><i class=""layui-icon layui-icon-add-1""></i>添加</button>
    <button class=""layui-btn layui-btn-sm"" lay-event=""btn-refresh"" id=""btn-refresh""><i class=""layui-icon layui-icon-refresh""></i>刷新</button>
</div>

<table id=""demoTb1""></table>

<!-- 表格操作列 -->
<script type=""text/html"" id=""barDemo"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon layui-icon-edit""></i>编辑</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del""><i class=""layui-icon layui-icon-delete""></i>删除</a>
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f0a8ef7c59157157331a275af3228c0a406e3914506", async() => {
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
            WriteLiteral(@"
<script>
    layui.config({
        base: '/'
    }).extend({
        treeTable: 'lib/layui/treeTable'
    });


    layui.use(['layer', 'table', 'treeTable'], function () {
        var $ = layui.jquery,
            layer = layui.layer,
            util = layui.table,
            treeTable = layui.treeTable;

        // 渲染表格

        treeTable.render({
            elem: '#demoTb1',
            toolbar: '#toolbarDemo', //开启头部工具栏，并为其绑定左侧模板
            defaultToolbar: ['filter', 'exports', 'print', { //自定义头部工具栏右侧图标。如无需自定义，去除该参数即可
                title: '提示'
                , layEvent: 'LAYTABLE_TIPS'
                , icon: 'layui-icon-tips'
            }],
            tree: {
                iconIndex: 1,  // 折叠图标显示在第几列
                idName: 'F_Id',
                childName: 'children',
                openName: 'F_IsExpand'

            },
            cols: [

                { type: 'numbers', fixed: 'left', title: '序号', width: 60 },
                { field: 'F_FullName'");
            WriteLiteral(@", title: '名称', width: 160, align: 'center' },
                { field: 'F_UrlAddress', title: '链接', width: 260, align: 'center' },
                {
                    field: 'F_Icon', title: '图标', width: 100, templet: function (item) {
                        if (item.F_Icon.indexOf('fa-') !== -1) {
                            return '<i class=""fa ' + item.F_Icon + '"" aria-hidden=""true"" data-icon=""' + item.F_Icon + '""></i>';
                        } else {
                            return '<i class=""layui-icon"" data-icon=""' + item.F_Icon + '"">' + item.F_Icon + '</i>';
                        }
                    },
                    align: 'center'
                },
                { field: 'F_CreatorTime', title: '创建时间', width: 180, align: 'center' },
                { fixed: 'right', title: '操作', toolbar: '#barDemo', width: 250, align: 'center' }
            ],
            reqData: function (data, callback) {
                // 在这里写ajax请求，通过callback方法回调数据

                $.ajax({");
            WriteLiteral(@"
                    url: ""/api/Module"",
                    type: 'get',
                    dataType: 'json',
                    success: function (res) {
                        callback(res);  // 参数是数组类型
                    }

                });

            }
        });


        $(""#add"").click(function () {
            layer.open({
                type: 2,
                area: ['730px', '400px'],
                title: ""添加"",
                content: '/Admin/ModuleForm',
                btn: ['确定', '关闭'],
                yes: function (index, layero) {
                    var sub = layero.find('iframe').contents().find(""#edit"");
                    sub.click();
                    obj.update(fields)
                }
                , btn2: function () {
                    layer.closeAll();
                },
                zIndex: layer.zIndex //重点1
                , success: function (layero, index) {
                }

            });
        });

        // ");
            WriteLiteral(@"刷新
        $('#btn-refresh').on('click', function () {
            location.reload()
        });

        //监听行工具事件
        treeTable.on('tool(demoTb1)', function (obj) {
            var data = obj.data;
            //console.log(obj)
            if (obj.event === 'del') {
                layer.confirm('真的删除行么', function (index) {
                    $.ajax({
                        type: ""Delete"",
                        url: ""/api/Module/"" + data.F_Id,
                        daaType: ""json"",
                        success: function (ret) {

                            if (ret == ""true"") {
                                layer.msg(""删除成功"", { icon: 1 });
                                obj.del();

                            }
                            else {
                                layer.msg(""删除失败"", { icon: 2 });
                            }
                        }

                    });
                    layer.close(index);
                });
            } el");
            WriteLiteral(@"se if (obj.event === 'edit') {

                layer.open({
                    type: 2,
                    area: ['730px', '400px'],
                    title: ""编辑"",
                    content: '/Admin/ModuleForm?F_ParentId=' + data.F_ParentId,
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
                        body.find(""#F_FullName");
            WriteLiteral(@""").val(data.F_FullName);
                        body.find(""#F_UrlAddress"").val(data.F_UrlAddress);
                        body.find(""#F_Icon"").val(data.F_Icon);
                        body.find(""#F_Target"").val(data.F_Target);
                        body.find(""#F_IsMenu"").attr(""checked"", data.F_IsMenu == true ? true : false);
                        body.find(""#F_IsExpand"").attr(""checked"", data.F_IsExpand == true ? true : false);
                        body.find(""#F_IsPublic"").attr(""checked"", data.F_IsPublic == true ? true : false);
                        body.find(""#F_AllowEdit"").attr(""checked"", data.F_AllowEdit == true ? true : false);
                        body.find(""#F_AllowDelete"").attr(""checked"", data.F_AllowDelete == true ? true : false);
                        body.find(""#F_EnabledMark"").attr(""checked"", data.F_EnabledMark == true ? true : false);


                        iframeWin.layui.form.render();
                    }
                    , end: function () { //最后执行reload
");
            WriteLiteral("                        location.reload();\r\n                    }\r\n\r\n                });\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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

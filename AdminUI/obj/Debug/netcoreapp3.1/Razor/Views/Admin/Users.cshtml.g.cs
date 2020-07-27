#pragma checksum "D:\AdminCodeUI\AdminUI\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df558238cba00968ef104f213d90f7ec958756f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df558238cba00968ef104f213d90f7ec958756f1", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""layui-hide"" id=""test"" lay-filter=""test""></table>

<script type=""text/html"" id=""toolbarDemo"">
    <div class=""layui-btn-container"">
        <button class=""layui-btn layui-btn-sm"" lay-event=""add""><i class=""layui-icon layui-icon-add-1""></i>新增用户</button>
        <button class=""layui-btn layui-btn-sm"" lay-event=""btn-refresh"" id=""btn-refresh""><i class=""layui-icon layui-icon-refresh""></i>刷新</button>
    </div>
</script>

<script type=""text/html"" id=""barDemo"">
    <a class=""layui-btn layui-btn-xs"" lay-event=""edit""><i class=""layui-icon layui-icon-edit""></i>编辑</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del""><i class=""layui-icon layui-icon-delete""></i>删除</a>
</script>

<script type=""text/html"" id=""switchTpl"">
    <input type=""checkbox"" name=""sex"" value=""{{d.F_Gender}}"" lay-skin=""switch"" lay-text=""女|男"" lay-filter=""sexDemo"" {{");
            BeginWriteAttribute("d.F_Gender", " d.F_Gender =", 885, "", 898, 0);
            EndWriteAttribute();
            WriteLiteral("= true ? \'checked\' : \'\' }}>\r\n</script>\r\n\r\n\r\n\r\n\r\n<script type=\"text/html\" id=\"EnabledMark\">\r\n    <input type=\"checkbox\" name=\"EnabledMark\" value=\"{{d.F_EnabledMark}}\" lay-skin=\"switch\" lay-text=\"允许|禁止\" lay-filter=\"EnabledMarkDemo\" {{");
            BeginWriteAttribute("d.F_EnabledMark", " d.F_EnabledMark =", 1130, "", 1148, 0);
            EndWriteAttribute();
            WriteLiteral(@"= true ? 'checked' : '' }}>
</script>

<script>


    layui.use('table', function () {
        var table = layui.table;
        table.render({
            elem: '#test'
            , url: '/api/User/Userlist'
            , toolbar: '#toolbarDemo' //开启头部工具栏，并为其绑定左侧模板
            , defaultToolbar: ['filter', 'exports', 'print', { //自定义头部工具栏右侧图标。如无需自定义，去除该参数即可
                title: '提示'
                , layEvent: 'LAYTABLE_TIPS'
                , icon: 'layui-icon-tips'
            }]
            , title: '用户数据表'
            , cols: [[
                { type: 'checkbox', fixed: 'left' }
                , { field: 'F_Account', title: 'ID', width: 80, fixed: 'left' }
                , { field: 'F_RealName', title: '用户名', width: 120 }
                , { field: 'F_RealName', title: '邮箱', width: 150 }
                , { field: 'F_Gender', title: '性别', width: 80, sort: true, templet: '#switchTpl' }
                , { field: 'F_MobilePhone', title: '手机', width: 100 }
                , {
 ");
            WriteLiteral(@"                   field: 'F_OrganizeId', title: '单位', width: 120, templet: function (d) {

                        return top.clients.organize[d.F_OrganizeId] == null ? """" : top.clients.organize[d.F_OrganizeId].fullname;
                    }
                }
                , {
                    field: 'F_DepartmentId', title: '部门', width: 80, templet: function (d) {
                        return top.clients.organize[d.F_DepartmentId] == null ? """" : top.clients.organize[d.F_DepartmentId].fullname;
                    }
                }
                , {
                    field: 'F_DutyId', title: '岗位', width: 80, templet: function (d) {
                        return top.clients.duty[d.F_DutyId] == null ? """" : top.clients.duty[d.F_DutyId].fullname;
                    }
                }
                , { field: 'F_CreatorTime', title: '修改时间', width: 120, sort: true }
                , { field: 'F_EnabledMark', title: '允许登录', width: 100, templet: '#EnabledMark' }
                ");
            WriteLiteral(@", { field: 'F_Description', title: '备注', width: 200 }
                , { fixed: 'right', title: '操作', toolbar: '#barDemo', width: 200 }
            ]]
            , page: true

        });

        //头工具栏事件
        table.on('toolbar(test)', function (obj) {
            switch (obj.event) {
                case 'btn-refresh':
                    location.reload();
                    break;
                case 'add':
                    layer.open({
                        type: 2,
                        area: ['730px', '500px'],
                        title: ""用户添加"",
                        content: '/Admin/UserForm',
                        btn: ['确定', '关闭'],
                        yes: function (index, layero) {
                            var sub = layero.find('iframe').contents().find(""#edit"");
                            sub.click();
                            location.reload();
                        }
                        , btn2: function () {
                        ");
            WriteLiteral(@"    layer.closeAll();
                        },
                        zIndex: layer.zIndex //重点1
                        , success: function (layero) {
                            layer.setTop(layero); //重点2
                        }

                    });
                    break;


            };
        });


        //监听行工具事件
        table.on('tool(test)', function (obj) {
            var data = obj.data;
            //console.log(obj)
            if (obj.event === 'del') {
                layer.confirm('真的删除行么', function (index) {
                    $.ajax({
                        type: ""Delete"",
                        url: ""/api/User/"" + data.F_Id,
                     
                        daaType: ""json"",
                        success: function (ret) {
                            debugger
                            if (ret == ""true"") {
                                layer.msg(""删除成功"", { icon: 1 });
                                obj.del();
               ");
            WriteLiteral(@"                 $("".layui-laypage-btn"").click();
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
                    type: 2,
                    area: ['730px', '500px'],
                    title: ""编辑"",
                    content: '/Admin/UserForm?keyValue=' + data.F_Id,
                    btn: ['确定', '关闭'],
                    yes: function (index, layero) {
                        var sub = layero.find('iframe').contents().find(""#edit"");
                        sub.click();

                    }
                    , btn2: function () {
                        layer.closeAll();
                    },
                    zIndex: layer.zIndex //重点1
                    , success: func");
            WriteLiteral(@"tion (layero, index) {
                        //debugger
                        var body = layer.getChildFrame('body', index);
                        var iframeWin = window[layero.find('iframe')[0]['name']]; //得到iframe页的窗口对象
                        body.find(""#F_Id"").val(data.F_Id);
                        body.find(""#F_Account"").val(data.F_Account);
                        body.find(""#F_UserPassword"").val(data.F_UserPassword);
                        body.find(""#F_OrganizeId"").val(data.F_OrganizeId);
                        body.find(""#F_DepartmentId"").val(data.F_DepartmentId);
                        body.find(""#F_DutyId"").val(data.F_DutyId);
                        body.find(""#F_RoleId"").val(data.F_RoleId);
                        body.find(""#F_RealName"").val(data.F_RealName);
                        body.find(""#F_MobilePhone"").val(data.F_MobilePhone);
                        body.find('input[name=F_Gender][value=男]').attr(""checked"", data.F_Gender == false ? true : false);
                ");
            WriteLiteral(@"        body.find('input[name=F_Gender][value=女]').attr(""checked"", data.F_Gender == true ? true : false);
                        body.find(""#F_EnabledMark"").attr(""checked"", data.F_EnabledMark == true ? true : false);
                        body.find(""#F_IsAdministrator"").attr(""checked"", data.F_IsAdministrator == true ? true : false);;
                        body.find(""#F_Description"").val(data.F_Description);
                        iframeWin.layui.form.render();
                    }

                });
            }
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

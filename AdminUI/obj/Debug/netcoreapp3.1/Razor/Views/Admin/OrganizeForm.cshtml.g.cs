#pragma checksum "C:\Users\SanKeYou\source\repos\AdminCodeUI\AdminUI\Views\Admin\OrganizeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4304b482017011c7c61766c73a9eb1578eae1ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrganizeForm), @"mvc.1.0.view", @"/Views/Admin/OrganizeForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4304b482017011c7c61766c73a9eb1578eae1ba", @"/Views/Admin/OrganizeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrganizeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"margin: 15px;\" id=\"Uform\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4304b482017011c7c61766c73a9eb1578eae1ba5980", async() => {
                WriteLiteral(@"
        <div class=""layui-form-item"">
            <input type=""text"" name=""F_Id"" id=""F_Id"" style=""display:none"" class=""layui-input"">
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">归属</label>
                <div class=""layui-input-inline"">
                    <select name=""F_ParentId"" id=""F_ParentId"" lay-filter=""aihao"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4304b482017011c7c61766c73a9eb1578eae1ba6710", async() => {
                    WriteLiteral("父节点");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"">分类</label>
                <div class=""layui-input-inline"">
                    <select name=""F_CategoryId"" id=""F_CategoryId"" lay-filter=""aihao"">
                    </select>
                </div>
            </div>
        </div>

        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">角色名称</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" name=""F_FullName"" id=""F_FullName"" placeholder=""请输入"" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"">负责人</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" name=""F_ManagerId"" id=""F_ManagerId"" placeholder=""请输入"" autoco");
                WriteLiteral(@"mplete=""off"" class=""layui-input"">

                </div>
            </div>
        </div>

        <div class=""layui-form-item"">

            <div class=""layui-inline"">
                <label class=""layui-form-label"">排序</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" name=""F_SortCode"" id=""F_SortCode"" placeholder=""请输入"" autocomplete=""off"" class=""layui-input"">

                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"">创建时间</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" name=""F_CreatorTime"" id=""F_CreatorTime"" placeholder=""请输入"" autocomplete=""off"" class=""layui-input"">

                </div>
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <input type=""checkbox"" name=""F_AllowEdit"" id=""F_AllowEdit"" title=""允许编辑"">
                <input type=""c");
                WriteLiteral("heckbox\" name=\"F_AllowDelete\" id=\"F_AllowDelete\" title=\"允许删除\">\r\n                <input type=\"checkbox\" name=\"F_EnabledMark\" id=\"F_EnabledMark\" title=\"有效\"");
                BeginWriteAttribute("checked", " checked=\"", 2760, "\"", 2770, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <button lay-filter=\"edit\" id=\"edit\" lay-submit style=\"display: none;\"></button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4304b482017011c7c61766c73a9eb1578eae1ba11774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4304b482017011c7c61766c73a9eb1578eae1ba12897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $.request = function (name) {
        var search = location.search.slice(1);
        var arr = search.split(""&"");
        for (var i = 0; i < arr.length; i++) {
            var ar = arr[i].split(""="");
            if (ar[0] == name) {
                if (unescape(ar[1]) == 'undefined') {
                    return """";
                } else {
                    return unescape(ar[1]);
                }
            }
        }
        return """";
    }
    var keyValue = $.request(""keyValue"");

    $.each(top.clients.organize, function (index, item) {
        $('#F_ParentId').append(new Option(item.fullname, index));
    });
    $.each(top.clients.dataItems.OrganizeCategory, function (index, item) {
        $('#F_CategoryId').append(new Option(item, index));
    });

    layui.use('form', function () {
        var form = layui.form;


        form.on('submit(edit)', function (data) {
            if (!!keyValue) {
                $.ajax({
                    type: """);
            WriteLiteral(@"Put"",
                    url: ""/api/Organize"",
                    data: JSON.stringify(data.field),
                    contentType: ""application/json;charset=UTF-8"",
                    dataType: ""json"",
                    success: function (ret) {

                        var index = parent.layer.getFrameIndex(window.name);
                        if (ret == true) {
                            layer.msg(""操作成功"", { icon: 1 }, function () {
                                parent.layer.close();
                                window.parent.location.reload();
                            });

                        }
                        else {
                            layer.msg(""操作失败"", { icon: 2, time: 3000 });
                            parent.layer.close(index); //再执行关闭
                        }
                    }
                });
            }
            else {
                $.ajax({
                    type: ""post"",
                    url: ""/api/Organize"",
     ");
            WriteLiteral(@"               contentType: ""application/json;charset=UTF-8"",
                    dataType: ""json"",
                    data: JSON.stringify(data.field),
                    success: function (ret) {
                        var index = parent.layer.getFrameIndex(window.name);
                        if (ret == true) {
                            layer.msg(""操作成功"", { icon: 1 }, function () {
                                parent.layer.close();
                                window.parent.location.reload();
                            });
                        }
                        else {
                            layer.msg(""操作失败"", { icon: 2 });
                            parent.layer.close(index); //再执行关闭
                        }
                    }
                });
            }

            return false;
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

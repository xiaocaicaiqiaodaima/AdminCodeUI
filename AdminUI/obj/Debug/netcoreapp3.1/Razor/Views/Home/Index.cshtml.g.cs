#pragma checksum "D:\AdminCodeUI\AdminUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cfd38661c2576bb09aa2aae8c6440cf267f2bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cfd38661c2576bb09aa2aae8c6440cf267f2bbd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d08743208300150e6e130acdeb7ae922411b7e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/images/0.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\AdminCodeUI\AdminUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""layui-layout layui-layout-admin"" >
    <div class=""layui-header header header-demo"">
        <div class=""layui-main"">
            <div class=""admin-login-box"">
                <a class=""logo"" style=""left: 0;"" href=""http://beginner.zhengjinfan.cn/demo/beginner_admin/"">
                    <span style=""font-size: 22px;"">Admin</span>
                </a>
                <div class=""admin-side-toggle"">
                    <i class=""layui-icon"">&#xe668;</i>
                </div>
                <div class=""admin-side-full"">
                    <i class=""layui-icon"">&#xe622;</i>
                </div>
             
            </div>


            <ul class=""layui-nav admin-header-item"">
                <li class=""layui-nav-item""><a");
            BeginWriteAttribute("href", " href=\"", 854, "\"", 861, 0);
            EndWriteAttribute();
            WriteLiteral(">控制台</a></li>\r\n                <li class=\"layui-nav-item\"><a");
            BeginWriteAttribute("href", " href=\"", 922, "\"", 929, 0);
            EndWriteAttribute();
            WriteLiteral(">设备管理</a></li>\r\n                <li class=\"layui-nav-item\"><a");
            BeginWriteAttribute("href", " href=\"", 991, "\"", 998, 0);
            EndWriteAttribute();
            WriteLiteral(">用户</a></li>\r\n\r\n                <li class=\"layui-nav-item\">\r\n                    <a href=\"javascript:;\" class=\"admin-header-user\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cfd38661c2576bb09aa2aae8c6440cf267f2bbd5797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span id=\"Uname\"> ");
#nullable restore
#line 30 "D:\AdminCodeUI\AdminUI\Views\Home\Index.cshtml"
                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </a>
                    <dl class=""layui-nav-child"">
                        <dd>
                            <a href=""javascript:;""><i class=""fa fa-user-circle"" aria-hidden=""true""></i> 个人信息</a>
                        </dd>
                        <dd>
                            <a href=""javascript:;""><i class=""fa fa-gear"" aria-hidden=""true""></i> 设置</a>
                        </dd>
                        <dd id=""clearCached"">
                            <a href=""javascript:;""><i class=""fa fa-gear"" aria-hidden=""true""></i> 清除缓存</a>
                        </dd>
                        <dd id=""lock"">
                            <a href=""javascript:;"">
                                <i class=""fa fa-lock"" aria-hidden=""true"" style=""padding-right: 3px;padding-left: 1px;""></i> 锁屏 (Alt+L)
                            </a>
                        </dd>
                        <dd>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfd38661c2576bb09aa2aae8c6440cf267f2bbd8091", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\" aria-hidden=\"true\"></i> 注销");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </li>\r\n            </ul>\r\n            <ul class=\"layui-nav admin-header-item-mobile\">\r\n                <li class=\"layui-nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfd38661c2576bb09aa2aae8c6440cf267f2bbd9744", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\" aria-hidden=\"true\"></i> 注销");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
            </ul>
        </div>
    </div>
    <div class=""layui-side layui-bg-black"" id=""admin-side"">
        <div class=""layui-side-scroll"" id=""admin-navbar-side"" lay-filter=""side""></div>
    </div>
    <div class=""layui-body"" style=""bottom: 0;border-left: solid 2px #1AA094;"" id=""admin-body"">
        <div class=""layui-tab admin-nav-card layui-tab-brief"" lay-filter=""admin-tab"">
            <ul class=""layui-tab-title"">
                <li class=""layui-this"">
                    <i class=""fa fa-dashboard"" aria-hidden=""true""></i>
                    <cite>控制面板</cite>
                </li>
            </ul>
            <div class=""layui-tab-content"" style=""min-height: 150px; padding: 5px 0 0 0;"">
                <div class=""layui-tab-item layui-show"">
                    <iframe src=""/Admin/GisMap""></iframe>
                </div>
            </div>
        </div>
    </div>
    <div class=""layui-footer footer footer-demo"" id=""admin-footer"">
        <div class=""lay");
            WriteLiteral(@"ui-main"">
            <p>
                2016 &copy;
                <a href=""http://m.zhengjinfan.cn/"">m.zhengjinfan.cn/</a> LGPL license
            </p>
        </div>
    </div>
    <div class=""site-tree-mobile layui-hide"">
        <i class=""layui-icon"">&#xe602;</i>
    </div>
    <div class=""site-mobile-shade""></div>

    <!--锁屏模板 start-->
    <script type=""text/template"" id=""lock-temp"">
        <div class=""admin-header-lock"" id=""lock-box"">
            <div class=""admin-header-lock-img"">
                <img src=""../lib/images/0.jpg"" />
            </div>

            <input type=""text"" class=""admin-header-lock-input"" value=""输入密码解锁.."" name=""lockPwd"" id=""lockPwd"" />
            <button class=""layui-btn layui-btn-small"" id=""unlock"">解锁</button>
        </div>
    </script>
    <!--锁屏模板 end -->
    <script>

        layui.use('layer', function () {
            var $ = layui.jquery,
                layer = layui.layer;

            $('#video1').on('click', function () {
       ");
            WriteLiteral(@"         layer.open({
                    title: 'YouTube',
                    maxmin: true,
                    type: 2,
                    content: 'video.html',
                    area: ['800px', '500px']
                });
            });
            $('#pay').on('click', function () {
                layer.open({
                    title: false,
                    type: 1,
                    content: '<img src=""images/xx.png"" />',
                    area: ['500px', '250px'],
                    shadeClose: true
                });
            });


        });
    </script>
</div>
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

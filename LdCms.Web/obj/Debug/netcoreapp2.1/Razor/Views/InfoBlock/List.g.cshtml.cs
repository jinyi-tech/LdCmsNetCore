#pragma checksum "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "687d753ec933866fa11387a60980ea32b0d92438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InfoBlock_List), @"mvc.1.0.view", @"/Views/InfoBlock/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InfoBlock/List.cshtml", typeof(AspNetCore.Views_InfoBlock_List))]
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
#line 1 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"687d753ec933866fa11387a60980ea32b0d92438", @"/Views/InfoBlock/List.cshtml")]
    public class Views_InfoBlock_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Info_Block>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/js/H-ui.admin.common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 5 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(208, 716, true);
            WriteLiteral(@"
<nav class=""breadcrumb"">
    <i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 内容管理 <span class=""c-gray en"">&gt;</span> 区块管理 <span class=""c-gray en"">&gt;</span> 列表
    <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a>
</nav>
<div class=""page-container"">
    <div class=""text-c""></div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a href=""javascript:;""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 924, "\"", 974, 3);
            WriteAttributeValue("", 934, "$.mainu.add(\'新增区块\',\'", 934, 20, true);
#line 19 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
WriteAttributeValue("", 954, Url.Action("add"), 954, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 972, "\')", 972, 2, true);
            EndWriteAttribute();
            BeginContext(975, 133, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe600;</i> 新增区块</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(1109, 13, false);
#line 21 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 622, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""100"">编号</th>
                    <th width="""">标题</th>
                    <th width=""180"">标签</th>
                    <th width=""70"">状态</th>
                    <th width=""120"">修改时间</th>
                    <th width=""100"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 37 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(1869, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1978, "\"", 1996, 1);
#line 42 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
WriteAttributeValue("", 1986, m.BlockID, 1986, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1997, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(2038, 9, false);
#line 43 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                           Write(m.BlockID);

#line default
#line hidden
            EndContext();
            BeginContext(2047, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(2102, 7, false);
#line 44 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                                          Write(m.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(2164, 6, false);
#line 45 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                                          Write(m.Tags);

#line default
#line hidden
            EndContext();
            BeginContext(2170, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(2229, 148, false);
#line 46 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                                              Write(m.State.ToBool() ? Html.Raw("<span class='label label-success radius'>已启用</span>") : Html.Raw("<span class='label label-defaunt radius'>已停用</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2419, 77, false);
#line 47 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(2497, 166, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n                                <a title=\"编辑\" class=\"ml-5\" style=\"text-decoration:none\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2663, "\"", 2740, 3);
            WriteAttributeValue("", 2673, "$.mainu.add(\'编辑\',\'", 2673, 18, true);
#line 49 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
WriteAttributeValue("", 2691, Url.Action("add", new { BlockID = m.BlockID }), 2691, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 2738, "\')", 2738, 2, true);
            EndWriteAttribute();
            BeginContext(2741, 116, true);
            WriteLiteral(">编辑</a>\r\n                                <a title=\"删除\" class=\"ml-5\" style=\"text-decoration:none\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2857, "\"", 2900, 3);
            WriteAttributeValue("", 2867, "$.mainu.delete(this,\'", 2867, 21, true);
#line 50 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
WriteAttributeValue("", 2888, m.BlockID, 2888, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2898, "\')", 2898, 2, true);
            EndWriteAttribute();
            BeginContext(2901, 75, true);
            WriteLiteral(">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 53 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3018, 48, true);
            WriteLiteral("</tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3145, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(3179, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffb0f7ec6136417c8f4d16ea0ddfb961", async() => {
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
                EndContext();
                BeginContext(3271, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3277, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c0f11923454957806a192e9364c909", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3378, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3384, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f43725e3624e65a318dd38f39e48ee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3465, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3471, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e963ced0ac1746288a7d47914b49d85b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3567, 1088, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.table-sort').dataTable({
                        ""ordering"": false,
                        ""aaSorting"": [[1, ""asc""]],//默认第几个排序
                        ""bStateSave"": true,//状态保存
                        ""iDisplayLength"": 100,
                        ""aoColumnDefs"": [
                            { ""orderable"": false, ""aTargets"": [0, 6] }// 制定列不参与排序
                        ]
                    });
                },
                add: function (title, url) {
                    var index = layer.open({
                        type: 2,
                        title: title,
                        content: url
                    });
                    layer.full(index);
                },
                delete: function (obj, id) {
                    layer.confirm('确认要删除吗？', function (index) {
                        $.ajax({
             ");
                WriteLiteral("               type: \'POST\',\r\n                            url: \'");
                EndContext();
                BeginContext(4656, 20, false);
#line 96 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\InfoBlock\List.cshtml"
                             Write(Url.Action("delete"));

#line default
#line hidden
                EndContext();
                BeginContext(4676, 1162, true);
                WriteLiteral(@"',
                            data: { BlockID: id },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").remove();
                                    layer.msg('已删除!', { icon: 1, time: 3000 });
                                }else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                            },
                            error: function (data) {
                                console.log(data.msg);
                            },
                        });
                    });
                },
                deleteBatch: function () {
                    layer.msg('不支持批量删除操作!', { icon: 5, time: 3000 });
            ");
                WriteLiteral("    }\r\n            };\r\n            $(function () {\r\n                $.mainu.init();\r\n            });\r\n        })(jQuery);\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(5841, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Info_Block>> Html { get; private set; }
    }
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    
    #line 1 "..\..\Views\Shared\_Layout.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 2 "..\..\Views\Shared\_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Layout.cshtml"
  
    var cfg = NewLife.Common.SysConfig.Current;
    var title = ViewBag.Title + "";
    if (title != "" && !title.EndsWith(" - ")) { title += " - "; }
    title += cfg.DisplayName;
    var title2 = ViewBag.Title2 as String;
    if (!title2.IsNullOrEmpty()) { title += " - " + title2; }

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteAttribute("lang", Tuple.Create(" lang=\"", 398), Tuple.Create("\"", 418)
            
            #line 12 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 405), Tuple.Create<System.Object, System.Int32>(ViewBag.Lang
            
            #line default
            #line hidden
, 405), false)
);

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 16 "..\..\Views\Shared\_Layout.cshtml"
      Write(title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 591), Tuple.Create("\"", 639)
, Tuple.Create(Tuple.Create("", 598), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 598), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 671), Tuple.Create("\"", 729)
, Tuple.Create(Tuple.Create("", 678), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.css")
, 678), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 761), Tuple.Create("\"", 786)
, Tuple.Create(Tuple.Create("", 768), Tuple.Create<System.Object, System.Int32>(Href("~/Content/cube.css")
, 768), false)
);

WriteLiteral(" />\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"navbar navbar-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-responsive-collapse\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                </button>\r\n                <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1324), Tuple.Create("\"", 1333)
, Tuple.Create(Tuple.Create("", 1331), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 1331), false)
);

WriteLiteral(">");

            
            #line 31 "..\..\Views\Shared\_Layout.cshtml"
                                             Write(cfg.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("<sub>");

            
            #line 31 "..\..\Views\Shared\_Layout.cshtml"
                                                                  Write(cfg.Name);

            
            #line default
            #line hidden
WriteLiteral("</sub></a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"navbar-collapse collapse navbar-responsive-collapse\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1547), Tuple.Create("\"", 1556)
, Tuple.Create(Tuple.Create("", 1554), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 1554), false)
);

WriteLiteral(">首页</a></li>\r\n                    <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1597), Tuple.Create("\"", 1617)
, Tuple.Create(Tuple.Create("", 1604), Tuple.Create<System.Object, System.Int32>(Href("~/FeiXian.zip")
, 1604), false)
);

WriteLiteral(">下载飞仙</a></li>\r\n                    <li><a");

WriteLiteral(" href=\"http://git.newlifex.com/NewLife/FeiXian\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">源码</a></li>\r\n                    <li>");

            
            #line 38 "..\..\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("关于", "About", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav navbar-right\"");

WriteLiteral(">\r\n                    <li");

WriteLiteral(" class=\"\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1923), Tuple.Create("\"", 1937)
, Tuple.Create(Tuple.Create("", 1930), Tuple.Create<System.Object, System.Int32>(Href("~/Admin")
, 1930), false)
);

WriteLiteral(">管理后台</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </" +
"div>\r\n\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 48 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"container footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-divider\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pull-right btn-group dropup\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Shared\_Layout.cshtml"
                                                                      Write(ViewBag.Language);

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span></a>\r\n                <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n                    <li>zh-cn</li>\r\n                    <li>en-us</li>\r\n      " +
"              <li>fr-fr</li>\r\n                </ul>\r\n            </div>\r\n       " +
"     <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("><p");

WriteLiteral(" class=\"muted\"");

WriteLiteral(">&copy; 2002-");

            
            #line 62 "..\..\Views\Shared\_Layout.cshtml"
                                                           Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 62 "..\..\Views\Shared\_Layout.cshtml"
                                                                              Write(cfg.Company);

            
            #line default
            #line hidden
WriteLiteral("</p></div>\r\n        </div>\r\n    </div>\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2727), Tuple.Create("\"", 2765)
, Tuple.Create(Tuple.Create("", 2733), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 2733), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2789), Tuple.Create("\"", 2834)
, Tuple.Create(Tuple.Create("", 2795), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 2795), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2858), Tuple.Create("\"", 2914)
, Tuple.Create(Tuple.Create("", 2864), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.js")
, 2864), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("    ");

            
            #line 69 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591

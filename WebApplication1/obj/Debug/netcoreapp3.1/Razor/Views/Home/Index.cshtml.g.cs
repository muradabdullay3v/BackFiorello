#pragma checksum "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45559766d45af491b0de9dfa3bc00615b17bd813"
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
#line 1 "F:\Code\BackFiorello\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Code\BackFiorello\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45559766d45af491b0de9dfa3bc00615b17bd813", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9820de706002b40f061b74a0cf154e35f47cd7cf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""filter"">
        <div class=""filter_container"">
            <div class=""filter_btns"" id=""filter_btns"">
                <div class=""categories_btn"">
                    <button class=""all_filters"" id=""all_filters"" onclick=""cat_drop()"">CATEGORIES <i
                            class=""fa-solid fa-caret-down""></i></button>
                    <div class=""categories_content"" id=""categories_content"">
                        
");
#nullable restore
#line 16 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                         foreach (var ct in Model.Categories)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <button class=\"filter-btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 655, "\"", 702, 3);
            WriteAttributeValue("", 665, "filterSelection(\'", 665, 17, true);
#nullable restore
#line 18 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 682, ct.Name.ToLower(), 682, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 700, "\')", 700, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 19 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                       Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n");
#nullable restore
#line 21 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                 foreach (var ct in Model.Categories)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <button class=\"filter-btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 991, "\"", 1038, 3);
            WriteAttributeValue("", 1001, "filterSelection(\'", 1001, 17, true);
#nullable restore
#line 26 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1018, ct.Name.ToLower(), 1018, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1036, "\')", 1036, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 27 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                       Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n");
#nullable restore
#line 29 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""filterer"">
                    <button class=""filterer_button"" id=""filterer_button"">
                        FILTER <i class=""fa-solid fa-caret-down""></i>
                    </button>
                    <div class=""filter-content"">
                        <div class=""filter-content_list"">
                            <div class=""filter-btns"">
                                <h3>Sort By</h3>
                                <button class=""filter-btn"">Default</button>
                                <button class=""filter-btn"">Popularity</button>
                                <button class=""filter-btn"">Newness</button>
                                <button class=""filter-btn"">Price:Low To High</button>
                                <button class=""filter-btn"">Price:High To Low</button>
                            </div>
                        </div>
                        <div class=""filter-content_list"">
                            <div class=""filter-btns"">
   ");
            WriteLiteral(@"                             <h3>Price Range</h3>
                                <button class=""filter-btn"">All</button>
                                <button class=""filter-btn"">$0-$10</button>
                                <button class=""filter-btn"">$10-$20</button>
                                <button class=""filter-btn"">$20-$30</button>
                                <button class=""filter-btn"">$30-$40</button>
                                <button class=""filter-btn"">$40+</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""all_filter-items"">
");
#nullable restore
#line 60 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                     foreach (var pr in Model.Products)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div");
            BeginWriteAttribute("class", " class=\"", 2960, "\"", 3007, 2);
            WriteAttributeValue("", 2968, "filter-item", 2968, 11, true);
#nullable restore
#line 62 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2979, pr.Category.Name.ToLower(), 2980, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"filter-item_image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3092, "\"", 3129, 1);
#nullable restore
#line 64 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 3098, pr.Images.FirstOrDefault().Url, 3098, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                            alt=\"image\">\r\n                    </div>\r\n                    <h5>");
#nullable restore
#line 67 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                   Write(pr.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div class=\"fltr_btn\">\r\n                        <button>$");
#nullable restore
#line 69 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                            Write(pr.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <section id=""valentine"">
        <div class=""valentine_container"">
            <div class=""valentine_video"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg"" alt=""image"">
                <div class=""play"">
                    <i class=""fa-solid fa-play""></i>
                </div>
            </div>
            <div class=""valentine_text"">
                ");
#nullable restore
#line 85 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           Write(Html.Raw(Model.ValentineSummary.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <p>");
#nullable restore
#line 86 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
              Write(Model.ValentineSummary.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <ul>\r\n");
#nullable restore
#line 88 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                     foreach (var item in Model.ValentineSummaryList)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <li>");
#nullable restore
#line 90 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                      Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 91 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section id=\"experts\">\r\n        <div class=\"experts_text\">\r\n            <h3>");
#nullable restore
#line 98 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           Write(Model.FlowerExpertsTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 99 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
          Write(Model.FlowerExpertsTitle.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"experts_cards\">\r\n");
#nullable restore
#line 103 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
             foreach (var item in Model.FlowerExpertsCards)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"experts_cards-item\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 4639, "\"", 4654, 1);
#nullable restore
#line 106 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 4645, item.url, 4645, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    alt=\"image\">\r\n                <h5>");
#nullable restore
#line 108 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 109 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
              Write(item.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 111 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </section>
    <section id=""join"">
        <div class=""join_summary"">
            <h3>
                Join The Colorful Bunch!
            </h3>
            <div class=""join_input"">
                <input type=""text"" placeholder=""Email Address"">
                <button>SUBSCRIBE</button>
            </div>
        </div>
    </section>
    <section id=""blog"">
        <div class=""blog_summary"">
            <h3>");
#nullable restore
#line 127 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           Write(Model.BlogTitle.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 128 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
          Write(Model.BlogTitle.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"blog_cards\">\r\n");
#nullable restore
#line 132 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
             foreach (var card in Model.BlogCards)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"blog_card\">\r\n                <div class=\"blog_image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5563, "\"", 5578, 1);
#nullable restore
#line 136 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 5569, card.url, 5569, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        alt=\"image\">\r\n                </div>\r\n                <div class=\"blog_text\">\r\n                    <a href=\"#\" class=\"blog_link\">");
#nullable restore
#line 140 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                                             Write(card.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <p>");
#nullable restore
#line 141 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                  Write(card.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <a href=\"#\" class=\"date_link\">");
#nullable restore
#line 143 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
                                         Write(card.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n");
#nullable restore
#line 145 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n    <section id=\"slick-carousel\">\r\n        <div class=\"slick-carousel-items\">\r\n");
#nullable restore
#line 150 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
             foreach (var item in Model.SlickItems)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"slick_carousel-item\">\r\n                <div class=\"slick_image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 6212, "\"", 6227, 1);
#nullable restore
#line 154 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 6218, item.url, 6218, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        alt=\"image\">\r\n                </div>\r\n                <h2>");
#nullable restore
#line 157 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h6>");
#nullable restore
#line 158 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>");
#nullable restore
#line 159 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
              Write(item.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 161 "F:\Code\BackFiorello\WebApplication1\Views\Home\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

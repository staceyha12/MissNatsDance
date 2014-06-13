using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.HtmlExtensions
{

    public static class HtmlHelpers
    {
        // Extension method
        public static MvcHtmlString ActionImage(this HtmlHelper html, string controller, string action, string imagePath, string cssClass, string alt, string anchorTag)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);
            string anch = anchorTag;
            if (!(string.IsNullOrEmpty(anch)) && !anch.StartsWith("#"))
                anch = "#" + anch;

            // build the <img> tag
            TagBuilder imgBuilder = new TagBuilder("img");
            imgBuilder.MergeAttribute("src", url.Content(imagePath));
            imgBuilder.MergeAttribute("class", cssClass);
            imgBuilder.MergeAttribute("alt", alt);
            string imgHtml = imgBuilder.ToString(TagRenderMode.SelfClosing);

            // build the <a> tag
            TagBuilder anchorBuilder = new TagBuilder("a");
            anchorBuilder.MergeAttribute("href", url.Action(action, controller) + anch);
            anchorBuilder.InnerHtml = imgHtml; // include the <img> tag inside
            string anchorHtml = anchorBuilder.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(anchorHtml);
        }
   
    }
}
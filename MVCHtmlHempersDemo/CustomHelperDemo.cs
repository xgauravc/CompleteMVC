using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHempersDemo
{
    public static class CustomHelperDemo
    {
        //using static method
        public static IHtmlString Image(string src, string alt) {

            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>",src,alt));
        }
        //using Extension method
        public static IHtmlString Img(this HtmlHelper htmlHelper, string src, string alt)
        {

            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>", src, alt));
        }
        //using tagbuilder
        public static IHtmlString ImgTag(this HtmlHelper htmlHelper, string src, string alt)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.Attributes.Add("src", src);
            tagBuilder.Attributes.Add("alt", alt);

            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}
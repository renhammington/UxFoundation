using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Ux.Mvc.Web.UI;

public static partial class UxHtmlHelpers
{
    private static object _lastFormNumKey = new object();

    /// <summary>
    /// Creates a form tag
    /// </summary>
    /// <param name="htmlHelper"></param>
    /// <param name="htmlAttributes"></param>
    /// <param name="allowFiles">Adds enctype property to allow posting of files</param>
    /// <returns></returns>
    public static IDisposable UxBeginForm(this HtmlHelper htmlHelper, object htmlAttributes = null, bool allowFiles = false)
    {
        string rawUrl = htmlHelper.ViewContext.HttpContext.Request.RawUrl;
        var defaultAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(new { @class = "form-horizontal", role = "form" });
        var passedAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

        var formAttributes = defaultAttributes.Merge(passedAttributes);
        if (allowFiles) formAttributes = formAttributes.Merge(HtmlHelper.AnonymousObjectToHtmlAttributes(new { enctype = "multipart/form-data" }));

        return htmlHelper.FormHelper(rawUrl, FormMethod.Post, formAttributes);
    }

    private static int IncrementFormCount(IDictionary items)
    {
        object obj2 = items[_lastFormNumKey];
        int num = (obj2 != null) ? (((int)obj2) + 1) : 0;
        items[_lastFormNumKey] = num;
        return num;
    }

    private static string DefaultFormIdGenerator(this HtmlHelper htmlhelper)
    {
        int num = IncrementFormCount(htmlhelper.ViewContext.HttpContext.Items);
        return string.Format(CultureInfo.InvariantCulture, "form{0}", new object[] { num });
    }

    private static IDisposable FormHelper(this HtmlHelper htmlHelper, string formAction, FormMethod method, IDictionary<string, object> htmlAttributes)
    {
        var builder = new TagBuilder("form");
        builder.MergeAttributes<string, object>(htmlAttributes);
        builder.MergeAttribute("action", formAction);
        builder.MergeAttribute("method", HtmlHelper.GetFormMethodString(method), true);
        bool flag = htmlHelper.ViewContext.ClientValidationEnabled && !htmlHelper.ViewContext.UnobtrusiveJavaScriptEnabled;
        if (flag)
        {
            builder.GenerateId(htmlHelper.DefaultFormIdGenerator());
        }
        htmlHelper.ViewContext.Writer.Write(builder.ToString(TagRenderMode.StartTag));
        var form = new MvcForm(htmlHelper.ViewContext);
        if (flag)
        {
            htmlHelper.ViewContext.FormContext.FormId = builder.Attributes["id"];
        }
        return form;
    }

}
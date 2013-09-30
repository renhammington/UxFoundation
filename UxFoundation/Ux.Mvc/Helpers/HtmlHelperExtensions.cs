using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Ux.Mvc.Web.UI;
using Ux.Mvc.Attributes;


public static class EditorExtensions
{

    #region EditorRow
    public static MvcHtmlString UxEditorRowFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
        Expression<Func<TModel, TProperty>> expression,
        DataSource datasource = null,
        string clientId = null)
    {

        //var placeholder = expression ;
        //var tooltip = ;
        var member = ((MemberExpression)expression.Body).Member;
        var placeholder = member.GetAttribute<PlaceholderAttribute>();
        var tooltip = member.GetAttribute<TooltipAttribute>();

        //var uiHint = member.GetAttribute<UIHintAttribute>();
        //object datasource = null;
        //object groupeddatasource = null;
        //if (uiHint != null && uiHint.UIHint == "Select")
        //{
        //	datasource = null;
        //	groupeddatasource = grouped;
        //}

        var row = new EditorRow(clientId)
        {
            Label = helper.LabelFor(expression, new { @class = "col-xs-3 control-label" }),
            Editor = helper.EditorFor(expression, new { DataSource = datasource, PlaceHolder = placeholder == null ? null : placeholder.Text }),
            Validation = helper.ValidationMessageFor(expression),
            Tooltip = tooltip == null ? null : tooltip.Text
        };

        return RenderUxControl(helper, row);
    }

    public static MvcHtmlString UxDisplayRowFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
        Expression<Func<TModel, TProperty>> expression,
        string clientId = null)
    {
        var row = new DisplayRow(clientId)
        {
            Label = helper.LabelFor(expression, new { @class = "col-xs-3 control-label" }),
            Content = helper.DisplayFor(expression)
        };

        return RenderUxControl(helper, row);
    }


    public static string MemberName<T, V>(this Expression<Func<T, V>> expression)
    {
        var memberExpression = expression.Body as MemberExpression;
        if (memberExpression == null)
            throw new InvalidOperationException("Expression must be a member expression");

        return memberExpression.Member.Name;
    }

    public static T GetAttribute<T>(this MemberInfo member)
        where T : Attribute
    {
        bool hasAttribute = Attribute.IsDefined(member, typeof(T));
        if (!hasAttribute) return null;

        var attribute = Attribute.GetCustomAttribute(member, typeof(T)) as T;
        return attribute;
    }

    #endregion

    #region Buttons

    public static MvcHtmlString UxButton(this HtmlHelper helper, Button button)
    {
        return helper.RenderUxControl(button);
    }

    public static MvcHtmlString UxButton(this HtmlHelper helper,
        string text,
        AppearanceType appearance = AppearanceType.Default,
        ButtonSize size = ButtonSize.Default,
        IconType? iconType = null,
        IconPosition position = IconPosition.Left,
        bool causesValidation = true,
        bool disabled = false,
        string loadingText = null,
        string clientId = null)
    {
        var button = new Button(text, ButtonCommand.None, appearance)
            .SetSize(size)
            .SetValidation(causesValidation)
            .SetDisabled(disabled)
            .SetLoadingText(loadingText);

        button.SetClientId(clientId);

        if (iconType.HasValue)
            button.SetIcon(new Icon(iconType.Value), position);

        return UxButton(helper, button);
    }


    public static MvcHtmlString UxSaveButton(this HtmlHelper helper, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var button = new Button("Save", ButtonCommand.Save, AppearanceType.Success)
            .SetIcon(new Icon(IconType.Ok))
            .SetSize(size);
        button.SetClientId(clientId);
        return UxButton(helper, button);
    }

    public static MvcHtmlString UxCancelButton(this HtmlHelper helper, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var button = new Button("Cancel", ButtonCommand.Cancel)
            .SetValidation(false)
            .SetSize(size);
        button.SetClientId(clientId);
        return UxButton(helper, button);
    }

    public static MvcHtmlString UxDeleteButton(this HtmlHelper helper, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var button = new Button("Delete", ButtonCommand.Delete)
            .SetValidation(false)
            .SetIcon(new Icon(IconType.Trash))
            .SetSize(size);
        button.SetClientId(clientId);
        return UxButton(helper, button);
    }

    #endregion







    #region Icon

    /// <summary>
    /// Generates an icon using the specified CssClass. Refer to http://fontawesome.io for a list of icons
    /// </summary>
    /// <param name="helper"></param>
    /// <param name="cssClass">Font Awesome icon class</param>
    /// <returns></returns>
    public static MvcHtmlString UxIcon(this HtmlHelper helper, IconType iconType, IconSize size = IconSize.Default, IconRotation rotation = IconRotation.Default, bool borderVisible = false, bool spin = false, bool pullRight = false, bool listItem = false, string clientId = null)
    {
        var icon = new Icon(iconType, size, rotation, borderVisible, spin, pullRight, listItem, clientId);
        return UxIcon(helper, icon);
    }

    public static MvcHtmlString UxIcon(this HtmlHelper helper, Icon icon)
    {
        return helper.RenderUxControl(icon);
    }

    #endregion

    #region Form

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


    #endregion



    public static MvcHtmlString UxBulletListItem(this HtmlHelper helper, string text, IconType? iconType = null, string clientId = null)
    {
        BulletListItem bullet = new BulletListItem(text, iconType, clientId);
        return helper.RenderUxControl(bullet);
    }

    public static MvcHtmlString UxLabel(this HtmlHelper helper, string text, AppearanceType appearance = AppearanceType.Default, string clientId = null)
    {
        var label = new Label(text, appearance, clientId);
        return helper.RenderUxControl(label);
    }

    public static MvcHtmlString UxBadge(this HtmlHelper helper, string text, bool pullRight = false, string clientId = null)
    {
        var badge = new Badge(text, pullRight, clientId);
        return UxBadge(helper, badge);
    }

    public static MvcHtmlString UxBadge(this HtmlHelper helper, Badge badge)
    {
        return helper.RenderUxControl(badge);
    }

    public static MvcHtmlString UxProgressBar(this HtmlHelper helper, int value, AppearanceType appearance = AppearanceType.Default, bool striped = false, bool animated = false, string clientId = null)
    {
        var progressBar = new ProgressBar(value, appearance, striped, animated, clientId);
        return helper.RenderUxControl(progressBar);
    }

    public static MvcHtmlString UxNextPrevPager(this HtmlHelper htmlHelper, string nextText = "Next", string nextUrl = null, string previousText = "Previous", string previousUrl = null, IconType? nextIcon = IconType.ChevronRight, IconType? previousIcon = IconType.ChevronLeft, PagerPosition position = PagerPosition.Center, string clientId = null)
    {
        var pager = new NextPreviousPager(nextText, nextUrl, previousText, previousUrl, nextIcon, previousIcon, position, clientId);
        return htmlHelper.RenderUxControl(pager);
    }

    public static MvcHtmlString UxPageLink(this HtmlHelper htmlHelper, string text, string url, bool active = false, bool disabled = false, string clientId = null)
    {
        var page = new NumericPagerPageLink(text, url, active, disabled, clientId);
        return htmlHelper.RenderUxControl(page);
    }

    public static MvcHtmlString UxPageLink(this HtmlHelper htmlHelper, IconType iconType, string url, bool active = false, bool disabled = false, string clientId = null)
    {
        var page = new NumericPagerPageLink(iconType, url, active, disabled, clientId);
        return htmlHelper.RenderUxControl(page);

    }

    public static MvcHtmlString UxNavLink(this HtmlHelper helper, string text, string url, IconType? iconType = null, IconPosition iconPosition = IconPosition.Left, bool active = false, bool disabled = false, bool iconPullRight = false, DataToggle dataToggle = DataToggle.None, string badgeText = null, bool badgePullRight = false, string clientId = null)
    {
        var navLink = new NavLink(text, url, iconType, iconPosition, active, disabled, iconPullRight, dataToggle, clientId);
        if (badgeText != null)
            navLink.SetBadge(new Badge(badgeText, badgePullRight));

        return helper.RenderUxControl(navLink);
    }









    public static IDisposable UxBulletList(this HtmlHelper htmlHelper, bool customIcons = false, int columnCount = 1, string clientId = null)
    {
        var list = new BulletList(customIcons, columnCount, clientId);
        return RenderUxDispoableWebControl(htmlHelper, list);
    }


    public static IDisposable UxButtonGroup(this HtmlHelper htmlHelper, bool toggle = false, ButtonSize size = ButtonSize.Default, string clientId = null)
    {
        var group = new ButtonGroup(toggle, size, clientId);
        return RenderUxDispoableWebControl(htmlHelper, group);
    }


    public static IDisposable UxWell(this HtmlHelper htmlHelper, WellSize size = WellSize.Default, string clientId = null)
    {
        var well = new Well(size, clientId);
        return RenderUxDispoableWebControl(htmlHelper, well);
    }

    public static IDisposable UxAlert(this HtmlHelper htmlHelper, AppearanceType appearance = AppearanceType.Default, bool dismissable = false, string clientId = null)
    {
        var alert = new Alert(appearance, dismissable, clientId);
        return RenderUxDispoableWebControl(htmlHelper, alert);
    }

    public static IDisposable UxNumericPager(this HtmlHelper htmlHelper, PagerSize size = PagerSize.Default, string clientId = null)
    {
        var pager = new NumericPager(size, clientId);
        return RenderUxDispoableWebControl(htmlHelper, pager);
    }


    public static IDisposable UxNav(this HtmlHelper htmlHelper, NavType type, bool justified = false, bool affix = false, int affixOffset = 0, string clientId = null)
    {
        var pager = new Nav(type, justified, affix, affixOffset, clientId);
        return RenderUxDispoableWebControl(htmlHelper, pager);
    }

    public static IDisposable UxButtonToolbar(this HtmlHelper htmlHelper, string clientId = null)
    {
        var toolbar = new ButtonToolbar(clientId);
        return RenderUxDispoableWebControl(htmlHelper, toolbar);
    }


    public static IDisposable UxTable(this HtmlHelper htmlHelper, bool striped = false, bool bordered= false, bool condensed = false, bool hovered = false, string clientId = null)
    {
        var table = new Table(striped, bordered, condensed, hovered, clientId);
        return RenderUxDispoableWebControl(htmlHelper, table);
    }


    #region Rendering
    private static MvcHtmlString RenderUxControl(this HtmlHelper htmlHelper, WebControl control)
    {
        var partial = htmlHelper.Partial("ControlTemplates/" + control.ViewTemplate, control).ToString();
        return MvcHtmlString.Create(partial);
    }

    private static IDisposable RenderUxDispoableWebControl(this HtmlHelper helper, WebControl control)
    {
        return new DisposableWebControl(
            () => helper.RenderUxControlStart(control),
            () => helper.RenderUxControlEnd(control)
        );
    }

    private static void RenderUxControlStart(this HtmlHelper htmlHelper, WebControl control)
    {
        htmlHelper.RenderPartial("ControlTemplates/" + control.ViewTemplate + "Start", control);
    }

    private static void RenderUxControlEnd(this HtmlHelper htmlHelper, WebControl control)
    {
        htmlHelper.RenderPartial("ControlTemplates/" + control.ViewTemplate + "End", control);
    }
    #endregion
}

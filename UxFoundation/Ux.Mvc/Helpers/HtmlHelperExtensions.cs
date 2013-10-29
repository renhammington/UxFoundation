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

public static class HtmlHelpers
{


	#region EditorRow



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


}

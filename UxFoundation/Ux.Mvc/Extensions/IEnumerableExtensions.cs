using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ux.Mvc.Web.UI;

	public static class IEnumerableExtensions
	{

		public static IEnumerable<SelectOption> ToSelectOptions<TSource>(this IEnumerable<TSource> data,
			Func<TSource, string> text,
			Func<TSource, string> value) where TSource : class
		{
			foreach (var item in data)
				yield return new SelectOption(text(item), value(item));
		}

	}

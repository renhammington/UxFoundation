using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{
	public class DisposableWebControl : IDisposable
	{
		
		private Action End;

		public DisposableWebControl(Action start, Action end)
		{
			End = end;
			start();
		}

		public void Dispose()
		{
			End();
		}
	}

}
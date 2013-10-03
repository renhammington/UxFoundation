using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ux.Mvc.Web.UI
{

	public abstract class UxControl
	{
				
		
		private string ClientId { get; set; }

		/// <summary>
		/// The partial view template to use for rendering the control
		/// </summary>
		public string ViewTemplate { get; private set; }

		public void SetClientId(string clientId)
		{
			ClientId = clientId;
		}

		public MvcHtmlString GetClientIdString()
		{
			if (ClientId.IsNullOrEmpty()) return null;
			else return MvcHtmlString.Create(string.Format("id=\"{0}\"", ClientId));
		}

		public UxControl(string viewTemplate, string clientId)
		{
			ViewTemplate = viewTemplate;
			SetClientId(clientId);
		}

	}

}
﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRQRReservationWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

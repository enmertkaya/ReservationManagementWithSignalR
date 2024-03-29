﻿namespace SignalRQRReservationWebUI.Dtos.ChangeDtos
{
	public class GetChangeDto
	{
		public int ChangeID { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public string ImageURL { get; set; }
		public int CategoryID { get; set; }
		public int CategoryName { get; set; }
		public bool ChangeStatus { get; set; }
	}
}

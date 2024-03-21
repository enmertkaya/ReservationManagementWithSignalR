namespace SignalRQRReservation.EntityLayer.Entities
{
    public class Change
    {
        public int ChangeID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImageURL { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
		public bool ChangeStatus { get; set; }
	}
}

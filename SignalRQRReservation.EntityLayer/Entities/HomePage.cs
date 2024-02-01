using System.ComponentModel.DataAnnotations;

namespace SignalRQRReservation.EntityLayer.Entities
{
    public class HomePage
    {
        [Key]
        public int FeatureID { get; set; }
        public string Title1 { get; set; }
        public string Descripton1 { get; set; }
        public string Title2 { get; set; }
        public string Descripton2 { get; set; }
        public string Title3 { get; set; }
        public string Descripton3 { get; set; }

    }
}

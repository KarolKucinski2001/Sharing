namespace Sharing.Models
{
    public class ChargingPoint
    {
        public int Id { get; set; } // Unikalny identyfikator
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ChargerType { get; set; }
        public double Power { get; set; }
        public string ContactInfo { get; set; }
        public decimal Cost { get; set; }
        public string AdditionalAmenities { get; set; }
        public string ImagePath { get; set; }

        public ChargingPoint()
        {
            // Inicjalizacja
            Id = -1; // Może być dowolna wartość, którą nie używasz do identyfikacji
            Name = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            PostalCode = string.Empty;
            Latitude = 0.0;
            Longitude = 0.0;
            ChargerType = string.Empty;
            Power = 0.0;
            ContactInfo = string.Empty;
            Cost = 0.0m;
            AdditionalAmenities = string.Empty;
            ImagePath = string.Empty;
        }
    }
}

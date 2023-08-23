using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Sharing.Models
{
    public class ChargingPointModel
    {
        [PrimaryKey, AutoIncrement]
        public int ChargingPointId { get; set; }
        public string Address { get; set; }
        public int Slots { get; set; }
        public int PricePerHour { get; set; }   

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ReservationModel> Reservations { get; set; }
    }

}

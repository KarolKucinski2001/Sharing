using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Models
{
    public class ReservationModel
    {
        [PrimaryKey, AutoIncrement]
        public int ReservationID { get; set; }
        public DateTime ReservationTime { get; set; }
        public double Price { get; set; }

        [ForeignKey(typeof(ChargingPointModel))]
        public int ChargingPointId { get; set; }
    }

}

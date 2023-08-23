using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sharing.Models;

namespace Sharing.Services
{
    public class DataService
    {
        private List<ChargingPointModel> chargingPoints; // Symulacja bazy danych lub kolekcji punktów ładowania
        private int nextId; // Symulacja generowania nowego ID

        public DataService()
        {
            chargingPoints = new List<ChargingPointModel>();
            nextId = 1;
        }

        public async Task AddChargingPointAsync(ChargingPointModel chargingPoint)
        {
            // Symulacja dodawania punktu ładowania do bazy danych lub kolekcji
            chargingPoint.ChargingPointId = nextId;
            nextId++;
          //  chargingPointsModel.Add(chargingPoint);
            await Task.Delay(100); // Symulacja opóźnienia przy dodawaniu
        }

        // ... reszta metod z poprzedniego przykładu ...
    }
}

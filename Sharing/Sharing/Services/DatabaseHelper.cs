using Sharing.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Sharing.Services
{
    public class DatabaseHelper
    {
        private SQLiteConnection database;

        public DatabaseHelper(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<UserModel>();
            database.CreateTable<ChargingPointModel>(); 
            database.CreateTable<ReservationModel>();
        }


        public List<UserModel> GetUsers()
        {
            return database.GetAllWithChildren<UserModel>();
        }

        public UserModel GetUserByUsername(string username)
        {
            return database.Table<UserModel>().FirstOrDefault(u => u.UserName == username);
        }

        public void InsertUser(UserModel user)
        {
            database.InsertWithChildren(user);
        }

        public bool DoesUserExist(string username)
        {
            return database.Table<UserModel>().Any(u => u.UserName == username);
        }

        // Metody związane z ładowarkami

        public List<ChargingPointModel> GetChargingPoints()
        {
            return database.GetAllWithChildren<ChargingPointModel>();
        }

        public void InsertChargingPoint(ChargingPointModel chargingPoint)
        {
            database.InsertWithChildren(chargingPoint);
        }


        public void InsertReservation(ReservationModel reservation)
        {
            database.InsertWithChildren(reservation);
            
        } 
        public void UpdateReservation(ReservationModel reservation)
        {
            database.UpdateWithChildren(reservation);
        }

        public void DeleteAllChargingPoints()
        {
            database.DeleteAll<ChargingPointModel>();
        }

        // Dodaj więcej metod związanych z ładowarkami, jeśli są potrzebne (np. aktualizuj ładowarkę, usuń ładowarkę itp.)
    }
}

using System;

namespace CarManagement.Data.DBModels
{
    public class DbCar
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime TuvUntil { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public Guid CostumerId { get; set; }
    }
}

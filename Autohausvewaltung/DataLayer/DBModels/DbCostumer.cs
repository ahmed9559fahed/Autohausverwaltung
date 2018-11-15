using System;

namespace DataLayer.DBModels
{
    public class DbCostumer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string TelefonNr { get; set; }
        public string Address { get; set; }
    }
}

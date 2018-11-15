using System;

namespace CarManagement.Data.DBModels
{
   public class DbCostomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string TelefonNr { get; set; }
        public string Address { get; set; }
    }
}

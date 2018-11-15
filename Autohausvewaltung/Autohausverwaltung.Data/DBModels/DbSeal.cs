using System;

namespace CarManagement.Data.DBModels
{
    public class DbSeal
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SealDate { get; set; }
        public Guid CostumerId { get; set; }
    }
}

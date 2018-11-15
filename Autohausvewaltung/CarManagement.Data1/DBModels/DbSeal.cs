using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Data1.DBModels
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohausverwaltung.Business.Models
{
    public class Seal
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public Guid UserId { get; set; }
        public DateTime SealDate { get; set; }
        public Guid CostumerId { get; set; }
    }
}

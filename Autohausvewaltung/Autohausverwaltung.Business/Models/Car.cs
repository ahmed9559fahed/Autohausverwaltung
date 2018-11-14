using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohausverwaltung.Business.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime TuvUntil { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public Guid CostumerId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string TelefonNr { get; set; }
        public string Address { get; set; }
    }
}

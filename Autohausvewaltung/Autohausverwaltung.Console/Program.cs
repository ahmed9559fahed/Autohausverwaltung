using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autohausverwaltung.Data.DBModels;

namespace Autohausverwaltung.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DbContext();
            context.UserTable.Add(new DbUser(){Id = Guid.NewGuid(),UserName = "afa",Password = "redbull"});
            context.SaveChanges();
        }
    }
}

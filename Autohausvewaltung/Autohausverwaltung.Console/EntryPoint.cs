using System;
using CarManagement.Data.DBModels;

namespace CarManagement.Console
{
    public class EntryPoint
    {
        public static void Main()
        {
            var dbContyext = new DbContext();
            dbContyext.UserTable.Add(new DbUser() { Id = Guid.NewGuid(), UserName = "test", Password = "test" });
            dbContyext.SaveChanges();
        }
    }
}

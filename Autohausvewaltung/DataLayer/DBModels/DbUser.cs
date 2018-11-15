using System;

namespace DataLayer.DBModels
{
    public class DbUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

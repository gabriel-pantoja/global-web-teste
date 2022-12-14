using System;

namespace GlobalWeb.Infra.Data.Entities
{
    public class Client : Base
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }
    }
}

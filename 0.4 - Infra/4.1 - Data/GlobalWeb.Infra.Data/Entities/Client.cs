using System;

namespace GlobalWeb.Infra.Data.Entities
{
    public class Client : Base
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Document { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }
    }
}

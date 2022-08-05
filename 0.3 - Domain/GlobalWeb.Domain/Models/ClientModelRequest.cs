using System;

namespace GlobalWeb.Domain.Models
{
    public class ClientModelRequest: Base
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Document { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }
    }
}

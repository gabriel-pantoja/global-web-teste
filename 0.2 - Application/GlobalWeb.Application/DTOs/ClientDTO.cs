using FluentValidation;
using System;

namespace GlobalWeb.Application.DTOs
{
    public class ClientDTO
    { 
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
    }
}

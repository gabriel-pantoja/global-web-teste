﻿using System;

namespace GlobalWeb.Application.DTOs
{
    public class ClientDTOResponse: Base
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Document { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }
    }
}

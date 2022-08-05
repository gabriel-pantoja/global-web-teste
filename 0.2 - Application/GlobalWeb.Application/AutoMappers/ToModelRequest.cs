using AutoMapper;
using GlobalWeb.Application.DTOs;
using GlobalWeb.Domain.Models;

namespace GlobalWeb.Application.AutoMappers
{
    public class ToModelRequest : Profile
    {
        public ToModelRequest()
        {
            CreateMap<ClientModelRequest, ClientDTORequest>();
        }
    }
}

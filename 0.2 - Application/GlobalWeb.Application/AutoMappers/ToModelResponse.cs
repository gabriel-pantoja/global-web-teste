using AutoMapper;
using GlobalWeb.Application.DTOs;
using GlobalWeb.Domain.Models;

namespace GlobalWeb.Application.AutoMappers
{
    public class ToModelResponse : Profile
    {
        public ToModelResponse()
        {
            CreateMap<ClientModelResponse, ClientDTOResponse>();
        }
    }
}

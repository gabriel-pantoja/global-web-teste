using AutoMapper;
using GlobalWeb.Domain.Models;
using GlobalWeb.Infra.Data.Entities;

namespace GlobalWeb.Domain.AutoMappers
{
    public class ToEntityRequest : Profile
    {
        public ToEntityRequest()
        {
            CreateMap<Client, ClientModelRequest>();
        }
    }
}

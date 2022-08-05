using AutoMapper;

namespace GlobalWeb.Application.AutoMappers
{
    public class AutoMapperConfigApplication
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new ToModelRequest());
                ps.AddProfile(new ToModelResponse());
            });
        }
    }
}

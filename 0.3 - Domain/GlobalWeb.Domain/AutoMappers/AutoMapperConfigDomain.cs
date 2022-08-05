using AutoMapper;

namespace GlobalWeb.Domain.AutoMappers
{
    public class AutoMapperConfigDomain
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new ToEntityRequest());
            });
        }
    }
}

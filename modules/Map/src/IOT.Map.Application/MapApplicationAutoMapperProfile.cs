using AutoMapper;
using IOT.Map.InforMaps;
//using IOT.Map.TestMap;

namespace IOT.Map
{
    public class MapApplicationAutoMapperProfile : Profile
    {
        public MapApplicationAutoMapperProfile()
        {
            CreateMap<InforMap, InforMapDto>();
            //CreateMap<CreateUpdatInforMapDto, InforMap>();
        }
    }
}
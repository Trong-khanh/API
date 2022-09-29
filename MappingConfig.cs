using AutoMapper;
using webAPI.Dtos;
using webAPI.Model;

namespace webAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UpsertBookDtos, Book>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
using AutoMapper;
using IOT.Books;

namespace IOT
{
    public class IOTApplicationAutoMapperProfile : Profile
    {
        public IOTApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace IOT.Map.InforMaps
{
    public interface IInforMapService:ICrudAppService< //Defines CRUD methods
            InforMapDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatInforMapDto> //Used to create/update a book
    {
        // ADD the NEW METHOD
        //Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
    }
}

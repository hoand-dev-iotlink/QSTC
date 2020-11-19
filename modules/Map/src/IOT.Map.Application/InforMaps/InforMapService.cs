using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace IOT.Map.InforMaps
{
    public class InforMapService : CrudAppService<
            InforMap, //The Book entity
            InforMapDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatInforMapDto>, //Used to create/update a book
        IInforMapService //implement the IBookAppService
    {
        public InforMapService(IRepository<InforMap, Guid> repository): base(repository)
        {
            //_authorRepository = authorRepository;
            //GetPolicyName = "";
            //GetListPolicyName = "";
            //CreatePolicyName = "";
            //UpdatePolicyName = "";
            //DeletePolicyName = "";
        }
        public override async Task<InforMapDto> CreateAsync(CreateUpdatInforMapDto input)
        {
            try
            {
                InforMap inforMap = new InforMap() { Name = input.Name };
                //var bookDto = ObjectMapper.Map<CreateUpdatInforMapDto, InforMap>(input);
                var book = await Repository.InsertAsync(inforMap);
                var book1 = ObjectMapper.Map<InforMap, InforMapDto>(book);
                return book1;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}

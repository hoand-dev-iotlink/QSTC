using IOT.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;
using System.Linq;

namespace IOT.Books
{
    [Authorize(IOTPermissions.Books.Default)]
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        //private readonly IAuthorRepository _authorRepository;

        public BookAppService(
            IRepository<Book, Guid> repository)
            : base(repository)
        {
            //_authorRepository = authorRepository;
            GetPolicyName = IOTPermissions.Books.Default;
            GetListPolicyName = IOTPermissions.Books.Default;
            CreatePolicyName = IOTPermissions.Books.Create;
            UpdatePolicyName = IOTPermissions.Books.Edit;
            DeletePolicyName = IOTPermissions.Books.Create;
        }
        public override async Task<BookDto> GetAsync(Guid id)
        {
            var book = await Repository.GetAsync(id);
            var bookDto = ObjectMapper.Map<Book, BookDto>(book);

            //var author = await _authorRepository.GetAsync(book.AuthorId);
            //bookDto.AuthorName = author.Name;

            return bookDto;
        }
        public override async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Book.Name);
            }
            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                Repository
                    .OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );
            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<Book>, List<BookDto>>(books);
            var totalCount = await Repository.GetCountAsync();
            return new PagedResultDto<BookDto>(
                totalCount,
                bookDtos
            );
        }


    }
}

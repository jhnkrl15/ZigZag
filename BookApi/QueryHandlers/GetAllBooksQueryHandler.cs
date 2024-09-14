using BookApi.Application.Interfaces;
using BookApi.Domain.Entities;
using BookApi.Queries;
using MediatR;

namespace BookApi.QueryHandlers
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        private readonly IBookService _service;

        public GetAllBooksQueryHandler(IBookService service) => _service = service;

        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetAllAsync();
        }
    }
}

using BookApi.Application.Interfaces;
using BookApi.Domain.Entities;
using BookApi.Queries;
using MediatR;

namespace BookApi.QueryHandlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, Book>
    {
        private readonly IBookService _service;

        public GetBookByIdQueryHandler(IBookService service) => _service = service;

        public async Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetByIdAsync(request.Id);
        }
    }
}

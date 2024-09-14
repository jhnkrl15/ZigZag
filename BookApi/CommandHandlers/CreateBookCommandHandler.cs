using BookApi.Application.Interfaces;
using BookApi.Commands;
using MediatR;

namespace BookApi.CommandHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookService _service;

        public CreateBookCommandHandler(IBookService service) => _service = service;

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _service.AddAsync(request.Book);
            return request.Book.Id;
        }
    }
}

using BookApi.Application.Interfaces;
using BookApi.Commands;
using BookApi.Domain.Entities;
using MediatR;

namespace BookApi.CommandHandlers
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IBookService _service;

        public UpdateBookCommandHandler(IBookService service) => _service = service;

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(request.Book);
            return Unit.Value;
        }
    }
}

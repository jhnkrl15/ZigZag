using BookApi.Domain.Entities;
using MediatR;

namespace BookApi.Commands
{
    public class UpdateBookCommand : IRequest
    {
        public Book Book { get; set; }

        public UpdateBookCommand(Book book) => Book = book;
    }
}

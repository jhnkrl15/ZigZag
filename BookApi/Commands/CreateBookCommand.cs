using BookApi.Domain.Entities;
using MediatR;

namespace BookApi.Commands
{
    public class CreateBookCommand : IRequest<int>
    {
        public Book Book { get; set; }

        public CreateBookCommand(Book book) => Book = book;
    }
}

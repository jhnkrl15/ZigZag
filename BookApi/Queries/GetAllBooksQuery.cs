using BookApi.Domain.Entities;
using MediatR;

namespace BookApi.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {

    }
}

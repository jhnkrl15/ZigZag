using BookApi.Domain.Entities;
using MediatR;

namespace BookApi.Queries
{
    public class GetBookByIdQuery : IRequest<Book>
    {
        public int Id { get; set; }

        public GetBookByIdQuery(int id) => Id = id;
    }
}

// IBookService.cs
using BookApi.Domain.Entities;

namespace BookApi.Application.Interfaces
{
    public interface IBookService
    {
        Task<Book> GetByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
    }
}

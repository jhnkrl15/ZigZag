// BookService.cs
using BookApi.Application.Interfaces;
using BookApi.Domain.Entities;

namespace BookApi.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _bookRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _bookRepository.AddAsync(book);
        }

        public async Task UpdateAsync(Book book)
        {
            await _bookRepository.UpdateAsync(book);
        }
    }
}

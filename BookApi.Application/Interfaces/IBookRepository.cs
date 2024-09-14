﻿using BookApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApi.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
    }
}
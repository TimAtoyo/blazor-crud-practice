using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCalalogue.Domain;

namespace BookCatalogue.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<IEnumerable<Book>> GetBooksAsync();

    }
}
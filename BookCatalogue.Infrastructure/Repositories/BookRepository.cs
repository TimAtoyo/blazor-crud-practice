using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCatalogue.Application.Interfaces;
using BookCatalogue.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
namespace BookCatalogue.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookCatalogueDbContext context;
        public BookRepository(IDbContextFactory<BookCatalogueDbContext> factory)
        {
            context = factory.CreateDbContext();
        }
    }
}
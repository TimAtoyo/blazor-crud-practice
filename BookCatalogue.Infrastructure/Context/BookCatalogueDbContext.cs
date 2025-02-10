using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCalalogue.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogue.Infrastructure.Context
{
    public class BookCatalogueDbContext : DbContext
    {
        public BookCatalogueDbContext(DbContextOptions<BookCatalogueDbContext> options) : base(options)
        {
            
        }


        public DbSet<Book> Books { get; set; }
    }
}
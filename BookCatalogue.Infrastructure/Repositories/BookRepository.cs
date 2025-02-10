using BookCalalogue.Domain;
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

        public async Task AddAsync(Book book)
        {
            try
            {
                await context.Books.AddAsync(book);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new ApplicationException("An error occurred while saving the book.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An Error has occured.", ex);
            }
        }
    }
}
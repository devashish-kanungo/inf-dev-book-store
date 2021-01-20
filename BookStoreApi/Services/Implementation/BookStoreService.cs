using BookStoreApi.Entities;
using BookStoreApi.Services.Contract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreApi.Services.Implementation 
{
    /// <summary>
    /// Represents BookStore Service.
    /// </summary>
    public class BookStoreService : IBookStoreService  
    {
        readonly BookStoreContext _bookStoreContext;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context"></param>
        public BookStoreService(BookStoreContext context)
        {
            _bookStoreContext = context; 
        }
       
        /// <summary>
        /// Gets all Authors.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _bookStoreContext.Authors.ToListAsync();
        }

        /// <summary>
        /// Deletes an Author.
        /// </summary>
        /// <returns></returns>
        public async Task DeleteAuthor(int id)
        {
            var author = await _bookStoreContext.Authors.FirstOrDefaultAsync(p => p.Id == id).ConfigureAwait(false); 
            if (author != null)
            {
                _bookStoreContext.Authors.Remove(author);
                await _bookStoreContext.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Gets an Author by Id.
        /// </summary>
        /// <returns></returns>
        public async Task<Author> GetAuthorById(int id) 
        {
            var author = await _bookStoreContext.Authors.FirstOrDefaultAsync(p => p.Id == id).ConfigureAwait(false);           
            return author;
        }

        /// <summary>
        /// Adds an Author.
        /// </summary>
        /// <returns></returns>
        public async Task<Author> AddAuthor(Author author) 
        {
            _bookStoreContext.Authors.Add(author);
            await _bookStoreContext.SaveChangesAsync();
            return author;
        }
    }
}

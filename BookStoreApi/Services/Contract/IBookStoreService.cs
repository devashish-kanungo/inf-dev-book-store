using BookStoreApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreApi.Services.Contract 
{
    /// <summary>
    /// Represents an interface for BookStore Service.
    /// </summary>
    public interface IBookStoreService
    {
        /// <summary>
        /// Get all authors.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Author>> GetAllAuthors();

        /// <summary>
        /// Deletes an author.
        /// </summary>
        /// <returns></returns>
        Task DeleteAuthor(int id);

        /// <summary>
        /// Gets an author by Id.
        /// </summary>
        /// <returns>A single instance of author object.</returns>
        Task<Author> GetAuthorById(int id);

        /// <summary>
        /// Adds an author.
        /// </summary>
        /// <returns>A single instance of author object.</returns>
        Task<Author> AddAuthor(Author author);
    }
}

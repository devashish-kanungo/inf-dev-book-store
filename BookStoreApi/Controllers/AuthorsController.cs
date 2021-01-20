using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Entities;
using BookStoreApi.Services.Contract;
using System.Net;

namespace BookStoreApi.Controllers
{
    /// <summary>
    /// This controller supports all CRUD operations for Authors which maps to Author table.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        /// <summary>
        /// Service instance.
        /// </summary>
        private readonly IBookStoreService bookStoreService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsController"/> class with necessary dependencies.
        /// </summary>
        /// <param name="service">Service object.</param>
        public AuthorsController(IBookStoreService service)
        {
            this.bookStoreService = service;
        }

        /// <summary>
        /// Gets all authors.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(IEnumerable<Author>))]
        public async Task<ActionResult<IEnumerable<Author>>> GetAll()
        {
            return this.Ok(await this.bookStoreService.GetAllAuthors().ConfigureAwait(false));
        }

        /// <summary>
        /// Deletes an author.
        /// </summary>
        /// <param name="id">id of the author to be deleted.</param>
        /// <returns>204-No Content.</returns>
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await this.bookStoreService.DeleteAuthor(id).ConfigureAwait(false);
            return this.NoContent();
        }

        /// <summary>
        /// Gets an author Id.
        /// </summary>
        /// <returns>A single instance of Author.</returns>
        [HttpGet("{id}", Name = "GetAuthorDetail")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [Produces(typeof(Author))]
        public async Task<ActionResult<Author>> GetById(int id)  
        {
            return this.Ok(await this.bookStoreService.GetAuthorById(id).ConfigureAwait(false));
        }

        /// <summary>
        /// Adds an author.
        /// </summary>
        /// <returns>A single instance of Author.</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(Author))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<Author>> Post([FromBody] Author author) 
        {
            var newAuthor = await this.bookStoreService.AddAuthor(author).ConfigureAwait(false);  
            return this.CreatedAtRoute("GetAuthorDetail", new { id = newAuthor.Id }, newAuthor);
        } 
    }
}

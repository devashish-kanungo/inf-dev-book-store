using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the BookStore Context Class.
    /// </summary>
    public class BookStoreContext : DbContext
    {
        /// <summary>
        /// BookStore Context Class.
        /// </summary>
        /// <param name="options"></param>
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        /// <summary>
        /// DBSet for Authors.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// DBSet for BookShelf.
        /// </summary>
        public DbSet<BookShelf> BookShelf { get; set; }

        /// <summary>
        /// DBSet for BookRating.
        /// </summary>
        public DbSet<BookRating> BookRating { get; set; }

        /// <summary>
        /// DBSet for Customer.
        /// </summary>
        public DbSet<Customer> Customer { get; set; }

        /// <summary>
        /// DBSet for CustomerOrder.
        /// </summary>
        public DbSet<CustomerOrder> CustomerOrder { get; set; }

        /// <summary>
        /// DBSet for CustomerPaymentDetails.
        /// </summary>
        public DbSet<CustomerPaymentDetails> CustomerPaymentDetails { get; set; }

        /// <summary>
        /// DBSet for MembershipDetail.
        /// </summary>
        public DbSet<MembershipDetail> MembershipDetail { get; set; }

        /// <summary>
        /// DBSet for OrderDetails.
        /// </summary>
        public DbSet<OrderDetails> OrderDetails { get; set; }

        /// <summary>
        /// DBSet for OrderInventory.
        /// </summary>
        public DbSet<OrderInventory> OrderInventory { get; set; }

        /// <summary>
        /// DBSet for PublisherDetails.
        /// </summary>
        public DbSet<PublisherDetails> PublisherDetails { get; set; }

        /// <summary>
        /// DBSet for PublisherOrder.
        /// </summary>
        public DbSet<PublisherOrder> PublisherOrder { get; set; }

        /// <summary>
        /// DBSet for PublisherOrderDetails.
        /// </summary>
        public DbSet<Author> PublisherOrderDetails { get; set; }


        /// <summary>
        /// OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookShelf>().HasData(new BookShelf
            {
                BookId = 1,
                BookName = "Azure Basics",
                Category = "Infomation Technology",
                SubCategory = "Cloud Computing",
                Cost = 500,
                Count = 20,
                Medium = "E Book",
                Publisher = "O Reilly",
                Summary = "This a basic book for understanding Azure Fundamentals"

            }, new BookShelf
            {
                BookId = 2,
                BookName = "AWS Basics",
                Category = "Infomation Technology",
                SubCategory = "Cloud Computing",
                Cost = 600,
                Count = 25,
                Medium = "E Book",
                Publisher = "O Reilly",
                Summary = "This a basic book for understanding AWS Fundamentals"

            },
             new BookShelf
             {
                 BookId = 3,
                 BookName = "NetWorking Basics",
                 Category = "Infomation Technology",
                 SubCategory = "Networks",
                 Cost = 400,
                 Count = 50,
                 Medium = "E Book",
                 Publisher = "O Reilly",
                 Summary = "This a basic book for understanding NetWorking Fundamentals"

             });
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the BookShelf table.
    /// </summary>
    [Table("BookShelf", Schema = "dbo")]
    public class BookShelf
    {
        /// <summary>
        /// Gets or Sets BookId of the Book Shelf Table.
        /// </summary>
        [Key]
        [Display(Name = "'Book Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        /// <summary>
        /// Gets or Sets Book Name of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(200)]
        [Display(Name = "'Book Name'")]
        public string BookName { get; set; }

        /// <summary>
        /// Gets or Sets Category of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "'Category'")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Sub Category of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "'Sub Category'")]
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or Sets Publisher of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(20)]
        [Display(Name = "'Publisher'")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or Sets Publisher of the Book Shelf Table.
        /// </summary>
        [Display(Name = "'Cost'")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or Sets Medium of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(20)]
        [Display(Name = "'Medium'")]
        public string Medium { get; set; }

        /// <summary>
        /// Gets or Sets Medium of the Book Shelf Table.
        /// </summary>
        [Display(Name = "'Rating'")]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or Sets Summary of the Book Shelf Table.
        /// </summary>
        [Required]
        [StringLength(300)]
        [Display(Name = "'Summary'")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Count of the Book Shelf Table.
        /// </summary>
        [Display(Name = "'Count'")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets BookId.
        /// </summary>
        [ForeignKey("BookId")]
        public IEnumerable<BookRating> BookRating { get; set; }

        /// <summary>
        /// Gets or sets BookId.
        /// </summary>
        [ForeignKey("BookId")]
        public IEnumerable<OrderDetails> OrderDetails { get; set; } 

    }
}

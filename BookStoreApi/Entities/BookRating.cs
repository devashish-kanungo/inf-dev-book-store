using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the BookRating table.
    /// </summary>
    [Table("BookRating", Schema = "dbo")]
    public class BookRating

    {

        /// <summary>
        /// Gets or Sets Id of the BookRating Table.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId of the BookRating Table.
        /// </summary>
        [Display(Name = "'Customer Id'")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Rating Comments of the BookRating Table.
        /// </summary>
        [Display(Name = "'Rating Comments'")]
        public string RatingComments { get; set; }

        /// <summary>
        /// Gets or Sets Recommendation Id of the BookRating Table.
        /// </summary>
        [Display(Name = "'Recommendation'")]
        public string Recommendation { get; set; }

        /// <summary>
        /// Gets or Sets BookId of the BookRating Table.
        /// </summary>
        [Display(Name = "'Book Id'")]
        public int BookId { get; set; }

        /// <summary>
        /// Gets or Sets Rating of the BookRating Table.
        /// </summary>
        [Display(Name = "'Rating'")]
        public string Rating { get; set; }


    }
}

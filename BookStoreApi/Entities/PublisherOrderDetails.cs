using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the PublisherOrderDetails table.
    /// </summary>
    [Table("PublisherOrderDetails", Schema = "dbo")]
    public class PublisherOrderDetails

    {

        /// <summary>
        /// Gets or Sets Id of the PublisherOrderDetails Table.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets PublisherOrderId of the PublisherDetails Table.
        /// </summary>
        public int PublisherOrderId { get; set; }

        /// <summary>
        /// Gets or Sets BookName of the PublisherOrderDetails Table.
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "'Book Name'")]
        public string BookName { get; set; }

        /// <summary>
        /// Gets or Sets Quantity of the PublisherDetails Table.
        /// </summary>
        [Display(Name = "'Quantity'")]
        public int Quantity { get; set; } 

    }
}

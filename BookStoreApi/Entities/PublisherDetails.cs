using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the PublisherDetails table.
    /// </summary>
    [Table("PublisherDetails", Schema = "dbo")]
    public class PublisherDetails

    {
        /// <summary>
        /// Gets or Sets PublisherId of the PublisherDetails Table.
        /// </summary>
        [Key]
        [Display(Name = "'Publisher Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { get; set; }

        /// <summary>
        /// Gets or Sets PublisherName of the PublisherDetails Table.
        /// </summary>
        [Required]
        [StringLength(30)]
        [Display(Name = "'Publisher Name'")]
        public string PublisherName { get; set; }
     
    }
}

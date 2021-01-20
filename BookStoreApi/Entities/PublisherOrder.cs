using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the PublisherOrder table.
    /// </summary>
    [Table("PublisherOrder", Schema = "dbo")]
    public class PublisherOrder

    {
        /// <summary>
        /// Gets or Sets PublisherId of the PublisherOrder Table.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherOrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderDetailId of the PublisherOrder Table.
        /// </summary>
        [Display(Name = "'OrderDetail Id'")]
        public int OrderDetailId { get; set; }

        /// <summary>
        /// Gets or Sets OrderRaisedDate of the PublisherOrder Table.
        /// </summary>
        public DateTime OrderRaisedDate { get; set; }

        /// <summary>
        /// Gets or sets PublisherOrderId.
        /// </summary>
        [ForeignKey("PublisherOrderId")]
        public IEnumerable<PublisherOrderDetails> PublisherOrderDetails { get; set; }

    }
}

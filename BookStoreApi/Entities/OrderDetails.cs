using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the OrderDetails table.
    /// </summary>
    [Table("OrderDetails", Schema = "dbo")]
    public class OrderDetails

    {
        /// <summary>
        /// Gets or Sets Id of the CustomerPaymentDetails Table.
        /// </summary>
        [Key]
        [Display(Name = "'Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        /// <summary>
        /// Gets or Sets CustomerOrderId of the OrderDetails Table.
        /// </summary>
        [Display(Name = "'Customer OrderId '")]
        public int CustomerOrderId { get; set; }

        /// <summary>
        /// Gets or Sets BookId of the OrderDetails Table.
        /// </summary>
        [Display(Name = "'Book Id'")]
        public int BookId { get; set; }

        /// <summary>
        /// Gets or Sets Cost of the OrderDetails Table.
        /// </summary>
        [Display(Name = "'Cost'")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or Sets Quantity of the OrderDetails Table.
        /// </summary>
        [Display(Name = "'Quantity'")]
        public int Quantity { get; set; }


        /// <summary>
        /// Gets or Sets OrderDetailId of the OrderDetails Table.
        /// </summary>
        [Display(Name = "'OrderDetail Id'")]
        public int OrderDetailId { get; set; }

        /// <summary>
        /// Gets or sets OrderDetailId.
        /// </summary>
        [ForeignKey("OrderDetailId")]
        public IEnumerable<PublisherOrder> PublisherOrder { get; set; }



    }
}

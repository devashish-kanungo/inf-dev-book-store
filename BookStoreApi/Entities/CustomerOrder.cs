using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the CustomerOrder table.
    /// </summary>
    [Table("CustomerOrder", Schema = "dbo")]
    public class CustomerOrder

    {

        /// <summary>
        /// Gets or Sets CustomerOrderId of the CustomerOrder Table.
        /// </summary>
        [Display(Name = "'Customer OrderId'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerOrderId { get; set; }


        /// <summary>
        /// Gets or Sets Delivery Address of the CustomerOrder Table.
        /// </summary>
        [Required]
        [StringLength(200)]
        [Display(Name = "'Delivery Address'")]
        public string DeliveryAddress { get; set; }


        /// <summary>
        /// Gets or Sets PaymentMode of the CustomerPaymentDetails Table.
        /// </summary>
        [Required]
        [Display(Name = "'Payment Mode'")]
        public string PaymentMode { get; set; }


        /// <summary>
        /// Gets or Sets Payment Details of the CustomerPaymentDetails Table.
        /// </summary>
        [Required]
        [Display(Name = "'Payment Details'")]
        public string PaymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets CourierId of the CustomerOrder Table.
        /// </summary>
        [Display(Name = "'Courier Id'")]
        public int CourierId { get; set; }

        /// <summary>
        /// Gets or Sets Publisher of the CustomerOrder Table.
        /// </summary>
        [Display(Name = "'Total Cost'")]
        public decimal TotalCost { get; set; }


        /// <summary>
        /// Gets or Sets OrderDateRaised of the CustomerOrder Table.
        /// </summary>
        [Display(Name = "'Order DateRaised'")]
        public DateTime OrderDateRaised { get; set; }


        /// <summary>
        /// Gets or Sets Status of the CustomerOrder Table.
        /// </summary>
        public string Status { get; set; }


        /// <summary>
        /// Gets or sets CustomerOrderId.
        /// </summary>
        [ForeignKey("CustomerOrderId")]
        public IEnumerable<OrderDetails> OrderDetails { get; set; }

        /// <summary>
        /// Gets or sets CustomerOrderId.
        /// </summary>
        [ForeignKey("CustomerOrderId")]
        public IEnumerable<OrderInventory> OrderInventory { get; set; }


    }
}

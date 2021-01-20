using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the OrderInventory table.
    /// </summary>
    [Table("OrderInventory", Schema = "dbo")]
    public class OrderInventory

    {

        /// <summary>
        /// Gets or Sets Id of the OrderInventory Table.
        /// </summary>
        [Key]
        [Display(Name = "'Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets PublisherOrderId of the OrderInventory Table.
        /// </summary>
        [Display(Name = "'Publisher OrderId'")]
        public int PublisherOrderId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerOrderId of the OrderInventory Table.
        /// </summary>
        [Display(Name = "'Customer OrderId'")]
        public int CustomerOrderId { get; set; }


        /// <summary>
        /// Gets or Sets Status of the OrderInventory Table.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets OrderType of the OrderInventory Table.
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or Sets DateRaised of the OrderInventory Table.
        /// </summary>
        public DateTime DateRaised { get; set; }

    }
}

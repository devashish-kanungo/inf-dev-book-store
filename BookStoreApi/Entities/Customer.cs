using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the Customer table.
    /// </summary>
    [Table("Customer", Schema = "dbo")]
    public class Customer

    {
        /// <summary>
        /// Gets or Sets CustomerId of the Customer Table.
        /// </summary>
        [Display(Name = "'Customer Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Display Name of the Customer Table.
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "'Display Name'")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Membership Id of the Customer Table.
        /// </summary>
        [Display(Name = "'Membership Id'")]
        public int MembershipId { get; set; }

        /// <summary>
        /// Gets or Sets Main Delivery Address of the Customer Table.
        /// </summary>
        [Required]
        [StringLength(200)]
        [Display(Name = "'Main Delivery Address'")]
        public string MainDeliveryAddress { get; set; }

        /// <summary>
        /// Gets or Sets Active Directory Id of the Customer Table.
        /// </summary>
        [Display(Name = "'Active Directory Id'")]
        public Guid ActiveDirectoryId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [ForeignKey("CustomerId")]
        public IEnumerable<BookRating> BookRating { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [ForeignKey("CustomerId")]
        public IEnumerable<CustomerPaymentDetails> CustomerPaymentDetails { get; set; }


    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the CustomerPaymentDetails table.
    /// </summary>
    [Table("CustomerPaymentDetails", Schema = "dbo")]
    public class CustomerPaymentDetails

    {

        /// <summary>
        /// Gets or Sets Id of the CustomerPaymentDetails Table.
        /// </summary>
        [Key]
        [Display(Name = "'Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        /// <summary>
        /// Gets or Sets CustomerId of the CustomerPaymentDetails Table.
        /// </summary>
        [Display(Name = "'Customer Id'")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Preferred Payment Option of the CustomerPaymentDetails Table.
        /// </summary>
        [Required]
        [StringLength(10)]
        [Display(Name = "'Preferred Payment Option'")]
        public string PreferredPaymentOption { get; set; }

        /// <summary>
        /// Gets or Sets CardNumber of the CustomerPaymentDetails Table.
        /// </summary>
        [CreditCard]
        [Display(Name = "'Card Number'")]
        public int CardNumber { get; set; }

        /// <summary>
        /// Gets or Sets CardType of the CustomerPaymentDetails Table.
        /// </summary>
        [Required]
        [StringLength(10)]
        [Display(Name = "'Card Type'")]
        public string CardType { get; set; }


    }
}

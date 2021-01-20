using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the MembershipDetail table.
    /// </summary>
    [Table("MembershipDetail", Schema = "dbo")]
    public class MembershipDetail

    {
        /// <summary>
        /// Gets or Sets MembershipId of the MembershipDetail Table.
        /// </summary>
        [Key]
        [Display(Name = "'Membership Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembershipId { get; set; }

        /// <summary>
        /// Gets or Sets Discount of the MembershipDetail Table.
        /// </summary>
        [Display(Name = "'Discount'")]
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryCharges of the MembershipDetail Table.
        /// </summary>
        [Display(Name = "'Delivery Charges'")]
        public decimal DeliveryCharges { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryPriority of the MembershipDetail Table.
        /// </summary>
        [Required]
        [Display(Name = "'Delivery Priority'")]
        public string DeliveryPriority { get; set; }

        /// <summary>
        /// Gets or Sets MembershipType of the MembershipDetail Table.
        /// </summary>
        [Required]
        [Display(Name = "'Membership Type'")]
        public string MembershipType { get; set; }

        /// <summary>
        /// Gets or sets MembershipId.
        /// </summary>
        [ForeignKey("MembershipId")]
        public IEnumerable<Customer> Customer { get; set; }


    }
}

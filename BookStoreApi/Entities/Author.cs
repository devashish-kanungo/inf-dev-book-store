using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Entities
{
    /// <summary>
    /// Represents the Author table.
    /// </summary>
    [Table("Author", Schema = "dbo")]
    public class Author
    {
        /// <summary>
        /// Gets or Sets First Name of the Author Id.
        /// </summary>
        [Display(Name = "'Id'")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets First Name of the Author.
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "'First Name'")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Last Name of the Author.
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "'Last Name'")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Genre of the Author.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    [Table("Authors", Schema = "dbo")]
    public class Author
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false),MaxLength(25)]
        [Display(Name = "Author ID")]
        public string au_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(40)]
        [Display(Name = "Last Name")]
        public string au_lname { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(20)]
        [Display(Name = "First Name")]
        public string au_fname { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(12)]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [MaxLength(40)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [MaxLength(20)]
        [Display(Name = "City")]
        public string city { get; set; }

        [MaxLength(2)]
        [Display(Name = "State")]
        public string state { get; set; }

        [MaxLength(5)]
        [Display(Name = "Zip")]
        public string zip { get; set; }

        [Display(Name = "Contract")]
        public bool contract { get; set; }

        public virtual ICollection<TitleAuthor> TitleAuthors { get; set; }
    }
}
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
        public string au_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(40)]
        public string au_lname { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(20)]
        public string au_fname { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(12)]
        public string phone { get; set; }

        [MaxLength(40)]
        public string address { get; set; }

        [MaxLength(20)]
        public string city { get; set; }

        [MaxLength(2)]
        public string state { get; set; }

        [MaxLength(5)]
        public string zip { get; set; }

        public bool contract { get; set; }

        public virtual ICollection<Title> Titles { get; set; }
    }
}
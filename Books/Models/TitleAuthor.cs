using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Books.Models
{
    [Table("TitleAuthor", Schema = "dbo")]
    public class TitleAuthor
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(25)]
        public string au_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(25)]
        public string title_id { get; set; }

        public Nullable<int> au_ord { get; set; }

        public Nullable<int> royaltyper { get; set; }
    }
}
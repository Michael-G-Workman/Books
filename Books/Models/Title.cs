using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Books.Models
{
    [Table("Titles", Schema = "dbo")]
    public class Title
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(25)]
        public string title_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(80)]
        public string title { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(12)]
        public string type { get; set; }

        [MaxLength(4)]
        public string pub_id { get; set; }

        public Nullable<decimal> price { get; set; }

        public Nullable<decimal> advance { get; set; }

        public Nullable<int> royalty { get; set; }

        public Nullable<int> ytd_sales { get; set; }

        [MaxLength(200)]
        public string notes { get; set; }

        [Required]
        public DateTime pubdate { get; set; }
    }
}
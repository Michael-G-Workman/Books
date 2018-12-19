using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    [Table("Sales", Schema = "dbo")]
    public class Sale
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false),MaxLength(4)]
        public string stor_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(20)]
        public string ord_num { get; set; }

        [Required]
        public DateTime ord_date { get; set; }

        [Required]
        public int qty { get; set; }
    }
}
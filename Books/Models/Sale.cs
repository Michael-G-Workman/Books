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
        [Display(Name = "Store ID")]
        public string stor_id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(20)]
        [Display(Name = "Order Number")]
        public string ord_num { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime ord_date { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int qty { get; set; }
    }
}
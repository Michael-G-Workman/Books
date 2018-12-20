using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.ViewModels
{
    public class TitleVM
    {
        [MaxLength(25)]
        [Display(Name = "Title ID")]
        public string title_id { get; set; }

        [MaxLength(80)]
        [Display(Name = "Title")]
        public string title { get; set; }

        [MaxLength(12)]
        [Display(Name = "Type")]
        public string type { get; set; }

        [MaxLength(4)]
        [Display(Name = "Publisher ID")]
        public string pub_id { get; set; }

        [Display(Name = "Price")]
        public Nullable<decimal> price { get; set; }

        [Display(Name = "Advance")]
        public Nullable<decimal> advance { get; set; }

        [Display(Name = "Royalty")]
        public Nullable<int> royalty { get; set; }

        [Display(Name = "YTD Sales")]
        public Nullable<int> ytd_sales { get; set; }

        [MaxLength(200)]
        [Display(Name = "Notes")]
        public string notes { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime pubdate { get; set; }

    }
}

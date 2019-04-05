namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [Key]
        [StringLength(50)]
        public string Rent_id { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string unit_type { get; set; }

        public string price { get; set; }

        public string year { get; set; }

        public string month { get; set; }

        public virtual Region Region { get; set; }
    }
}

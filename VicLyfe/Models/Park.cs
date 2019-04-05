namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Park")]
    public partial class Park
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Park_id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public virtual Region Region { get; set; }
    }
}

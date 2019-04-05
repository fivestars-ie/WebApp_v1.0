namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Job_id { get; set; }

        public string Area_type { get; set; }

        [StringLength(50)]
        public string Region_name { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string Total { get; set; }

        public virtual Region Region { get; set; }
    }
}

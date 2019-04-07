namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Training_Institutions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int College_id { get; set; }

        public string Region_name { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string Institution_name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Area_type { get; set; }

        public virtual Region Region { get; set; }
    }
}

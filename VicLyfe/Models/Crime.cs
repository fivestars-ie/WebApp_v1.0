namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Crime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Crime_id { get; set; }

        public int? Year { get; set; }

        public string Police_region { get; set; }

        public string Police_area { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string CSA_Offence_Division { get; set; }

        public string CSA_Offence_Subdivision { get; set; }

        public string CSA_Offence_Group { get; set; }

        public string Offence_Count { get; set; }

        public string LGA_ERP { get; set; }

        public string Victorian_ERP { get; set; }

        public string Region_name { get; set; }

        public string Area_type { get; set; }

        public virtual Region Region { get; set; }
    }
}

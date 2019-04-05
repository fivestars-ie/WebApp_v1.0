namespace VicLyfe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Current_Location
    {
        [Key]
        public DateTime Time { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Filter_1 { get; set; }

        public string Filter_2 { get; set; }

        public string Filter_3 { get; set; }

        public string Filter_4 { get; set; }

        public string Filter_5 { get; set; }

        public string Filter_6 { get; set; }
    }
}

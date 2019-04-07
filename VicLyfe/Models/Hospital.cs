namespace VicLyfe.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Hospital")]
    public partial class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hospital_id { get; set; }

        public string Hospital_name { get; set; }

        public string Type { get; set; }

        [StringLength(50)]
        public string Suburb_name { get; set; }

        public string Postcode { get; set; }

        public string Region_name { get; set; }

        public virtual Region Region { get; set; }
    }
}

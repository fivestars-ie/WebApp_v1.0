namespace VicLyfe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Crime> Crimes { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Training_Institutions> Training_Institutions { get; set; }
        public virtual DbSet<User_Current_Location> User_Current_Location { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

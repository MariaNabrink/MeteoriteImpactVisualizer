namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MeteoriteContext : DbContext
    {
        public MeteoriteContext()
            : base("name=MeteoriteContext")
        {
        }

        public virtual DbSet<Meteorite> Meteorite { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meteorite>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Meteorite>()
                .Property(e => e.Mass)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Meteorite>()
                .Property(e => e.RowVersion)
                .IsFixedLength();
        }
    }
}

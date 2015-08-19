namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HQContext : DbContext
    {
        public HQContext()
            : base("name=HQContext")
        {
        }

        public virtual DbSet<CM_Account> CM_Account { get; set; }
        public virtual DbSet<CM_Category> CM_Category { get; set; }
        public virtual DbSet<CM_Discount> CM_Discount { get; set; }
        public virtual DbSet<CM_Product> CM_Product { get; set; }
        public virtual DbSet<CM_Site> CM_Site { get; set; }
        public virtual DbSet<CM_Theme> CM_Theme { get; set; }
        public virtual DbSet<CM_Unit> CM_Unit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CM_Category>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<CM_Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CM_Unit>()
                .Property(e => e.Description)
                .IsFixedLength();
        }
    }
}

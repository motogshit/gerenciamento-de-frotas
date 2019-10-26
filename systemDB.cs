namespace sistemasfrotas
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class systemDB : DbContext
    {
        public systemDB()
            : base("name=systemDB")
        {
        }

        public virtual DbSet<empresas> empresas { get; set; }
        public virtual DbSet<funcionarios> funcionarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

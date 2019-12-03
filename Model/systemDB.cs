namespace sistemasfrotas.Model
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

        public virtual DbSet<alugados> alugados { get; set; }
        public virtual DbSet<empresas> empresas { get; set; }
        public virtual DbSet<funcionarios> funcionarios { get; set; }
        public virtual DbSet<logins> logins { get; set; }
        public virtual DbSet<manutencao> manutencao { get; set; }
        public virtual DbSet<recibos> recibos { get; set; }
        public virtual DbSet<veiculos> veiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

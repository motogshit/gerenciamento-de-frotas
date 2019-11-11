namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empresas
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Razao { get; set; }

        [Required]
        [StringLength(150)]
        public string Fantasia { get; set; }

        [Required]
        [StringLength(150)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(150)]
        public string Telefone1 { get; set; }

        [StringLength(150)]
        public string Telefone2 { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(150)]
        public string Website { get; set; }

        [StringLength(150)]
        public string Filial { get; set; }

        [StringLength(150)]
        public string Filial_Numero { get; set; }

        [StringLength(150)]
        public string CNPJ_Sede { get; set; }

        [Required]
        [StringLength(150)]
        public string Rua { get; set; }

        [Required]
        [StringLength(150)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(150)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(150)]
        public string Estado { get; set; }

        [Required]
        [StringLength(150)]
        public string Numero { get; set; }

        [Required]
        [StringLength(150)]
        public string CEP { get; set; }

        public DateTime Adicionado_em { get; set; }
    }
}

namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class funcionarios
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        public string Cargo { get; set; }

        [Required]
        [StringLength(150)]
        public string CPF { get; set; }

        [Required]
        [StringLength(150)]
        public string CHN { get; set; }

        [StringLength(150)]
        public string Telefone { get; set; }

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
        public string Numero_da_casa { get; set; }

        [Required]
        [StringLength(150)]
        public string Numero_Cracha { get; set; }

        [Required]
        [StringLength(150)]
        public string CNPJ_Empresa { get; set; }

        public DateTime Adicionado_em { get; set; }
    }
}

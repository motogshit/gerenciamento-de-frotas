namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class veiculos
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(150)]
        public string Marca { get; set; }

        [Required]
        [StringLength(150)]
        public string Ano { get; set; }

        [Required]
        [StringLength(150)]
        public string Placa_Veiculo { get; set; }

        [Required]
        [StringLength(150)]
        public string Numero_chassi { get; set; }

        [Required]
        [StringLength(150)]
        public string Km_Inicial { get; set; }

        [Required]
        [StringLength(150)]
        public string Km_Atual { get; set; }

        [Required]
        [StringLength(150)]
        public string empresa { get; set; }

        [Required]
        [StringLength(150)]
        public string cnpj { get; set; }

        [Required]
        [StringLength(150)]
        public string Status { get; set; }

        public DateTime Adicionado_em { get; set; }
    }
}

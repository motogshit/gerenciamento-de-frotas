namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("manutencao")]
    public partial class manutencao
    {
        public int ID { get; set; }

        public int CodigoCarro { get; set; }

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

        public double Custo { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        public DateTime Data_Manutencao { get; set; }

        public DateTime? Data_Devolvido { get; set; }
    }
}

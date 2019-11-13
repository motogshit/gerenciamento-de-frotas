namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class alugados
    {
        public int ID { get; set; }

        public int codigo_carro { get; set; }

        [Required]
        [StringLength(150)]
        public string Placa_Veiculo { get; set; }

        public int Codigo_funcionario { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        public string Km_Inicial { get; set; }

        [StringLength(150)]
        public string Km_Entregue { get; set; }

        [Required]
        [StringLength(150)]
        public string status { get; set; }

        [Required]
        [StringLength(150)]
        public string cnpj { get; set; }

        public DateTime Alugado_em { get; set; }

        public DateTime? Devolvido_em { get; set; }
    }
}

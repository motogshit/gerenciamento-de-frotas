namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class recibos
    {
        public int ID { get; set; }

        public int? Cod_Funcionario { get; set; }

        [StringLength(150)]
        public string Nome_Funcionario { get; set; }

        [Required]
        [StringLength(150)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(150)]
        public string Razao { get; set; }

        [Required]
        [StringLength(150)]
        public string Descricao { get; set; }

        public int? CodigoManutencao { get; set; }

        public double Valor { get; set; }

        public DateTime data { get; set; }
    }
}

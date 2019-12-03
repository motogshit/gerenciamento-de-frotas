namespace sistemasfrotas.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logins
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string User { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        public int AcessLevel { get; set; }
    }
}

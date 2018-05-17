namespace Jabil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [Key]
        public int PKCustomers { get; set; }

        [Column("Customer")]
        [Required]
        [StringLength(100)]
        public string Customer1 { get; set; }

        [Required]
        [StringLength(5)]
        public string Prefix { get; set; }

        public int? FKBuilding { get; set; }

        public virtual Building Building { get; set; }
    }
}

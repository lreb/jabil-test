namespace Jabil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            PartNumbers = new HashSet<PartNumber>();
        }

        [Key]
        public int PKCustomers { get; set; }

        [Column("Customer")]
        [Required]
        [StringLength(100)]
		[Display(Name = "Name")]
		public string Customer1 { get; set; }

        [Required]
        [StringLength(5)]
        public string Prefix { get; set; }

        public int? FKBuilding { get; set; }

        public virtual Building Building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartNumber> PartNumbers { get; set; }
    }
}

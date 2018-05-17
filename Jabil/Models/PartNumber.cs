namespace Jabil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	public partial class PartNumber
	{
		[Key]
		public int PKPartNumber { get; set; }

		[Column("PartNumber")]
		[Required]
		[StringLength(50)]
		[Display(Name ="Number")]
        public string PartNumber1 { get; set; }

        public int? FKCustomer { get; set; }

        public bool Available { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

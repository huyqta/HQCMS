namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CM_Product
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public Guid? RefCategory { get; set; }

        public Guid? RefUnit { get; set; }

        public Guid? RefDiscount { get; set; }

        public Guid? RefSite { get; set; }

        public DateTime? CREDate { get; set; }

        public DateTime? DELDate { get; set; }
    }
}

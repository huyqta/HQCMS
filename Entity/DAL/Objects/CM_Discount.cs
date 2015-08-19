namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CM_Discount
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string DiscountName { get; set; }

        [StringLength(50)]
        public string DiscountCode { get; set; }

        public string Description { get; set; }

        public DateTime? StartDiscount { get; set; }

        public DateTime? EndDiscount { get; set; }

        [StringLength(50)]
        public string DiscountType { get; set; }

        public decimal? DiscountValue { get; set; }

        public Guid? RefSite { get; set; }

        public DateTime? CREDate { get; set; }

        public DateTime? DELDate { get; set; }
    }
}

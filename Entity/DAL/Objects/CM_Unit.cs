namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CM_Unit
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        [StringLength(50)]
        public string UnitCode { get; set; }

        [StringLength(10)]
        public string Description { get; set; }

        public Guid? RefSite { get; set; }

        public DateTime? CREDate { get; set; }

        public DateTime? DELDate { get; set; }
    }
}

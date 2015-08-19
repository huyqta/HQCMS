namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CM_Theme
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string ThemeName { get; set; }

        public DateTime? CREDate { get; set; }

        public DateTime? DELDate { get; set; }
    }
}

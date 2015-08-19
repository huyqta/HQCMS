namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CM_Site
    {
        public Guid Id { get; set; }

        [StringLength(250)]
        public string SiteName { get; set; }

        [StringLength(250)]
        public string SiteDomain { get; set; }

        [StringLength(250)]
        public string SiteHost { get; set; }

        public Guid? RefAccount { get; set; }

        public Guid? RefTheme { get; set; }

        public DateTime CREDate { get; set; }

        public DateTime? DELDate { get; set; }
    }
}

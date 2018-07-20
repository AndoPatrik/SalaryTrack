namespace SalaryTrackWebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Records
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }

        [StringLength(20)]
        public string Workplace { get; set; }

        public int? SalarayPerHour { get; set; }

        public int? TaxPrecent { get; set; }

        public DateTime? WorkedDate { get; set; }

        public int? WorkedHours { get; set; }

        public int? UserID { get; set; }

        public virtual Users Users { get; set; }
    }
}

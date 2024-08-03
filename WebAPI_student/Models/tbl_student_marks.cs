namespace WebAPI_student.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_marks
    {
        public int id { get; set; }

        [StringLength(50)]
        public string student_name { get; set; }

        public int? tamil { get; set; }

        public int? english { get; set; }

        public int? maths { get; set; }

        public int? science { get; set; }

        public int? social_science { get; set; }

        public int? total { get; set; }

        public decimal? percentage { get; set; }
    }
}

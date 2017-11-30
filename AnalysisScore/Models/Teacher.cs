using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable InconsistentNaming

namespace AnalysisScore.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [Required]
        [Key]
        public Guid Tch_Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Tch_Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Tch_Sex { get; set; }
        [Required]
        public DateTime Tch_In { get; set; }
        [Required]
        public Guid Class_Id { get; set; }

        public virtual Class Class { get; set; }
    }
}

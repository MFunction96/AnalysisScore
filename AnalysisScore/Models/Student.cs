using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable InconsistentNaming

namespace AnalysisScore.Models
{
    [Table("Student")]
    public class Student
    {
        [Required]
        [Key]
        public Guid Stu_Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Stu_Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Stu_Sex { get; set; }
        [Required]
        public DateTime Stu_Birth { get; set; }
        [Required]
        public DateTime Stu_In { get; set; }
        [Required]
        public Guid Class_Id { get; set; }

        public virtual Class Class { get; set; }
    }
}

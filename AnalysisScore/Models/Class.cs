using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable InconsistentNaming

namespace AnalysisScore.Models
{
    [Table("Class")]
    public class Class
    {
        [Required]
        [Key]
        public Guid Class_Id { get; set; }
        [Required]
        public int Class_Grade { get; set; }
        [Required]
        public int Class_Index { get; set; }
    }
}

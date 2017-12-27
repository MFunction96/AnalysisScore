using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable InconsistentNaming

namespace AnalysisScore.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Student")]
    public class Student
    {
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(18)]
        [Key]
        [Required]
        public string Stu_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(64)]
        [Required]
        public string Stu_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(6)]
        [Required]
        public string Stu_Class { get; set; }
    }
}

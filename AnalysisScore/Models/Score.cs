using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// ReSharper disable InconsistentNaming

namespace AnalysisScore.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Score")]
    public class Score
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Stu_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Score_Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Chinese { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Math { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_English { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Physics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Chemistry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Biology { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Politics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Score_Geography { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Student Student { get; set; }
    }
}

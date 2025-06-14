﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estigo.Models
{
    public class lesson
    {
        [Key]
        public int lessonId { get; set; }
        public string lessonTitle { get; set; }
        public string? lessonVideo { get; set; }

        public bool isLive { get; set; } = false;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }


        // Navigation Properties
        [ForeignKey("Course")]
        public int courseId { get; set; }
        public Course Course { get; set; }
        public Exam Exam { get; set; }


    }
}

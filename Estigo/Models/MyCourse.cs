using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Estigo.Models;

public class MyCourse
{
    [Key]
    public int MycourseId { get; set; }

    public int attendance { get; set; }

    [ForeignKey("Student")]
    public string StudentId { get; set; }
    public Student Student { get; set; }

    [ForeignKey("Course")]
    public int courseId { get; set; }
    public Course Course { get; set; }

    public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
    
}
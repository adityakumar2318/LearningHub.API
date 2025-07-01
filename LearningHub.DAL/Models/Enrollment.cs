using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Enrollment")]
public partial class Enrollment
{
    [Key]
    public int EnrollmentId { get; set; }

    public int UserId { get; set; }

    public int CourseId { get; set; }

    public DateTime? EnrolledAt { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course Course { get; set; } = null!;

    [InverseProperty("Enrollment")]
    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();

    [ForeignKey("UserId")]
    [InverseProperty("Enrollments")]
    public virtual User User { get; set; } = null!;
}

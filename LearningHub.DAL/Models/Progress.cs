using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Progress")]
public partial class Progress
{
    [Key]
    public int ProgressId { get; set; }

    public int EnrollmentId { get; set; }

    public int LessonId { get; set; }

    public bool? IsCompleted { get; set; }

    public DateTime? CompletedAt { get; set; }

    [ForeignKey("EnrollmentId")]
    [InverseProperty("Progresses")]
    public virtual Enrollment Enrollment { get; set; } = null!;

    [ForeignKey("LessonId")]
    [InverseProperty("Progresses")]
    public virtual Lesson Lesson { get; set; } = null!;
}

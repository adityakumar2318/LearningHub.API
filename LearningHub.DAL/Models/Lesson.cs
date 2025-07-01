using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Lesson")]
public partial class Lesson
{
    [Key]
    public int LessonId { get; set; }

    public int ModuleId { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    public string? Content { get; set; }

    public int? DurationInMinutes { get; set; }

    public int? Order { get; set; }

    [InverseProperty("Lesson")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    [ForeignKey("ModuleId")]
    [InverseProperty("Lessons")]
    public virtual Module Module { get; set; } = null!;

    [InverseProperty("Lesson")]
    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();

    [InverseProperty("Lesson")]
    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}

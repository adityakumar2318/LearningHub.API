using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Quiz")]
public partial class Quiz
{
    [Key]
    public int QuizId { get; set; }

    public int LessonId { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    public string? Description { get; set; }

    [ForeignKey("LessonId")]
    [InverseProperty("Quizzes")]
    public virtual Lesson Lesson { get; set; } = null!;

    [InverseProperty("Quiz")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    [InverseProperty("Quiz")]
    public virtual ICollection<Submission> Submissions { get; set; } = new List<Submission>();
}

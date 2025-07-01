using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Question")]
public partial class Question
{
    [Key]
    public int QuestionId { get; set; }

    public int QuizId { get; set; }

    public string? QuestionText { get; set; }

    [StringLength(50)]
    public string? QuestionType { get; set; }

    [InverseProperty("Question")]
    public virtual ICollection<Option> Options { get; set; } = new List<Option>();

    [ForeignKey("QuizId")]
    [InverseProperty("Questions")]
    public virtual Quiz Quiz { get; set; } = null!;
}

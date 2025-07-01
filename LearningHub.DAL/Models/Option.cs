using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Option")]
public partial class Option
{
    [Key]
    public int OptionId { get; set; }

    public int QuestionId { get; set; }

    [StringLength(500)]
    public string? Text { get; set; }

    public bool? IsCorrect { get; set; }

    [ForeignKey("QuestionId")]
    [InverseProperty("Options")]
    public virtual Question Question { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Submission")]
public partial class Submission
{
    [Key]
    public int SubmissionId { get; set; }

    public int UserId { get; set; }

    public int QuizId { get; set; }

    public DateTime? SubmittedAt { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Score { get; set; }

    [ForeignKey("QuizId")]
    [InverseProperty("Submissions")]
    public virtual Quiz Quiz { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Submissions")]
    public virtual User User { get; set; } = null!;
}

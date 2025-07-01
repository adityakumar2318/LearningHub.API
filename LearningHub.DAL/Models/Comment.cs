using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearningHub.DAL.Models;

[Table("Comment")]
public partial class Comment
{
    [Key]
    public int CommentId { get; set; }

    public int LessonId { get; set; }

    public int UserId { get; set; }

    public string? Text { get; set; }

    public DateTime? CreatedAt { get; set; }

    [ForeignKey("LessonId")]
    [InverseProperty("Comments")]
    public virtual Lesson Lesson { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Comments")]
    public virtual User User { get; set; } = null!;
}

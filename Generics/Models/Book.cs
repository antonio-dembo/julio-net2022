using System;

#nullable enable

namespace Generics.Models
{
  public class Book
  {
    public int Isbn { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime? PublishDate { get; set; }
  }

}
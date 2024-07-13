using System.ComponentModel.DataAnnotations;

namespace SeniorProject.Models;

public class Option
{
    public int Id { get; set; }
    public string? Value { get; set; }
    public string? Text { get; set; }
}
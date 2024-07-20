using System.ComponentModel.DataAnnotations;

namespace SeniorProject.Models;

public class Review
{
    public int Id { get; set; }
    public string? UserId {get; set;}
    public string? ProductReview {get; set;}
    public int? ProductRating {get; set;}
    public int? productId {get; set;}

}
using System.ComponentModel.DataAnnotations;

namespace SeniorProject.Models;

public class Cart
{
    public int Id { get; set; }
    public string? UserId {get; set;}

    public float? ProductId {get; set;}

    public string? ProductImg {get; set;}
    public float? ProductPrice {get; set;}

    public string? ProductName {get; set;}
   

}
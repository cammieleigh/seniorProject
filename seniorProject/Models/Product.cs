using System.ComponentModel.DataAnnotations;

namespace SeniorProject.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name {get; set;}
    public float? Price {get; set;}

    public string? Color {get; set;}
    public string? Img {get; set;}
  

}
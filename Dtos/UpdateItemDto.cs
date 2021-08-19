using System.ComponentModel.DataAnnotations;

namespace GamerApi.Dtos
{
  public record UpdateItemDto
  {

    [Required]
    public string Name { get; init; }

    [Required]
    [Range(1, 9999)]
    public decimal Price { get; init; }
  }
}

namespace ApiMarvel.Application.Dtos;

public class ComicDetailsDto
{
    public Guid Id {  get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }  
    public string Reference { get; set; }
    public int Pages { get; set; }

}


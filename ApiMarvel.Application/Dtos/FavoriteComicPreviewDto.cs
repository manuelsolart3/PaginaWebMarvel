namespace ApiMarvel.Application.Dtos;

public class FavoriteComicPreviewDto
{
    public Guid FavoriteId { get; set; }
    public Guid ComicId { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
}



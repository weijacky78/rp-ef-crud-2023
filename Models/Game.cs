
using System.ComponentModel.DataAnnotations;

namespace rp_ef_crud.Models;


public class Game
{
    public uint GameId { get; set; }

    public string Title { get; set; } = default!;

    public string Genre { get; set; } = default!;

    [DataType(DataType.DateTime)]
    public DateTime ReleaseDate { get; set; }

    public decimal Price { get; set; }
}
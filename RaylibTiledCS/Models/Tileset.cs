namespace RaylibTiledCS.Models;

/// <summary>
/// Tiled Tile Set
/// </summary>
public class Tileset
{
    public int FirstGid { get; set; }
    public string Source { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int TileWidth { get; set; }
    public int TileHeight { get; set; }
    public int Spacing { get; set; }
    public int Margin { get; set; }
    public int TileCount { get; set; }
    public int Columns { get; set; }

    public Tileset(){

    }

}
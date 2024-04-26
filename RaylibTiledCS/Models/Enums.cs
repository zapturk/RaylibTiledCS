namespace RaylibTiledCS.Models;

/// <summary>
/// Tiled Layer Type
/// </summary>
public enum LayerType
{
    /// <summary>
    /// Tiled Tile Layer
    /// </summary>
    TileLayer,

    /// <summary>
    /// Tiled Object Layer
    /// </summary>
    ObjectLayer,

    /// <summary>
    /// Tiled Image Layer
    /// </summary>
    ImageLayer,

    /// <summary>
    /// Tiled Group Layer
    /// </summary>
    GroupLayer
}

/// <summary>
/// Tiled Property Type
/// </summary>
public enum PropertyType
{
    /// <summary>
    /// Tiled Bool
    /// </summary>
    Bool,

    /// <summary>
    /// Tiled Color
    /// </summary>
    Color,

    /// <summary>
    /// Tiled File
    /// </summary>
    File,

    /// <summary>
    /// Tiled Float
    /// </summary>
    Float,

    /// <summary>
    /// Tiled Int
    /// </summary>
    Int,

    /// <summary>
    /// Tiled Object
    /// </summary>
    Object,

    /// <summary>
    /// Tiled String
    /// </summary>
    String
}

namespace RaylibTiledCS.Models;

/// <summary>
/// Tiled Property
/// </summary>
public class Property{

    /// <summary>
    /// Name of the property
    /// </summary>
    public string Name { get; set;}

    /// <summary>
    /// Type of the property
    /// </summary>
    public PropertyType Type { get; set;}

    /// <summary>
    /// Value of the property
    /// </summary>
    public string Value { get; set;}
}
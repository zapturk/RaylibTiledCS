using System;
using System.Xml;

namespace RaylibTiledCS;

public class RaylibTiled
{
    public RaylibTiled()
    {
    }

    public void ParseMapXml(string xml)
    {
        try
        {
            // Load the xml document
            var document = new XmlDocument();
            document.LoadXml(xml);


        }
        catch (Exception ex)
        {
            throw new RaylibTiledCSException("An error occurred while trying to parse the Tiled map file", ex);
        }
    }
}


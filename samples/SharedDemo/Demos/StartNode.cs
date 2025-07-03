using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class StartNode : NodeModel
{
    public string Title { get; set; } = "Title";
    public string Subtitle { get; set; } = "Subtitle";

    // Add this for storing uploaded image
    public string? ImageDataUrl { get; set; }

    public StartNode(Point position) : base(position)
    {
        AddPort(PortAlignment.Right);
        AddPort(PortAlignment.Left);
    }
}
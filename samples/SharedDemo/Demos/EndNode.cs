using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class EndNode : NodeModel
{
    public string Title { get; set; } = "Title";
    public string Subtitle { get; set; } = "Subtitle";
    // public string? ImageDataUrl { get; set; }

    public EndNode(Point position) : base(position)
    {
        AddPort(PortAlignment.Left);
    }
}
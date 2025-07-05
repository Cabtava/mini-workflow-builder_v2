using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class StartNode : NodeModel
{
    public StartNode(Point position = null) : base(position)
    {
    }

    public string Title { get; set; } = "Start";
    public string Subtitle { get; set; } = "Initial step";
}
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class ScopeNode : NodeModel
{
    public string Title { get; set; } = "Title";
    public string Subtitle { get; set; } = "Subtitle";

    public ScopeNode(Point position) : base(position)
    {
        AddPort(PortAlignment.Right);
        AddPort(PortAlignment.Left);
    }
}

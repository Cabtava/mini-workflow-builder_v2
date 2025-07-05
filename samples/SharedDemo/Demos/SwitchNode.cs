using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class SwitchNode : NodeModel
{
    public string Title { get; set; } = "Switch";
    public string Subtitle { get; set; } = "Workflow";

    public SwitchNode(Point position) : base(position)
    {
        AddPort(PortAlignment.Right);
        AddPort(PortAlignment.Left);
        AddPort(PortAlignment.Top);
        AddPort(PortAlignment.Bottom);
    }
}

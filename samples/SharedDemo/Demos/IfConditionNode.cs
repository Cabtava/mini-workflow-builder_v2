using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class IfConditionNode : NodeModel
{
    public IfConditionNode(Point position = null) : base(position)
    {
        InputPort = AddPort(new PortModel(this, PortAlignment.Left));
        TruePort = AddPort(new PortModel(this, PortAlignment.Right));
        FalsePort = AddPort(new PortModel(this, PortAlignment.Right));
    }

    public string Title { get; set; } = "If Condition";
    public string Subtitle { get; set; } = "Flow controls";

    public PortModel InputPort { get; }
    public PortModel TruePort { get; }
    public PortModel FalsePort { get; }
}

using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace SharedDemo.Demos;

public class IfConditionNode : NodeModel
{
    public IfConditionNode(Point position = null) : base(position)
    {
    }

    public string Title { get; set; } = "If Condition";
    public string Subtitle { get; set; } = "Flow controls";
}


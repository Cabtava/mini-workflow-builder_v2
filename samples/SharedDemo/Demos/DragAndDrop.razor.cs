using Blazor.Diagrams;
using Blazor.Diagrams.Core.Models;
using Microsoft.AspNetCore.Components.Web;

namespace SharedDemo.Demos;

public partial class DragAndDrop
{
    private readonly BlazorDiagram _blazorDiagram = new BlazorDiagram();
    private int? _draggedType;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        // LayoutData.Title = "Drag & Drop";
        // LayoutData.Info = "A very simple drag & drop implementation using the HTML5 events.";
        LayoutData.DataChanged();

        _blazorDiagram.RegisterComponent<StartNode, StartNodeWidget>();
        _blazorDiagram.RegisterComponent<IfConditionNode, IfConditionNodeWidget>();
        _blazorDiagram.RegisterComponent<ForEachLoopNode, ForEachLoopNodeWidget>();

    }

    private void OnDragStart(int key)
    {
        _draggedType = key;
    }

    private void OnDrop(DragEventArgs e)
    {
        if (_draggedType == null)
            return;

        var position = _blazorDiagram.GetRelativeMousePoint(e.ClientX, e.ClientY);

        NodeModel node = _draggedType switch
        {
            0 => new StartNode(position),
            1 => new IfConditionNode(position),
            2 => new BotAnswerNode(position),
            3 => new ForEachLoopNode(position),
        };

        // ✅ Add 1 input and 1 output port
        node.AddPort(PortAlignment.Left);  // input
        node.AddPort(PortAlignment.Right); // output

        _blazorDiagram.Nodes.Add(node);
        _draggedType = null;
    }

}



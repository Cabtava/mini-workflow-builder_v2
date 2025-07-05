using Blazor.Diagrams;
using Blazor.Diagrams.Core.Models;
using Microsoft.AspNetCore.Components.Web;

namespace SharedDemo.Demos;

public partial class DragAndDrop
{
    private readonly BlazorDiagram _blazorDiagram = new BlazorDiagram();
    private int? _draggedType;

    private NodeModel? SelectedNode;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        LayoutData.DataChanged();

        _blazorDiagram.RegisterComponent<StartNode, StartNodeWidget>();
        _blazorDiagram.RegisterComponent<IfConditionNode, IfConditionNodeWidget>();
        _blazorDiagram.RegisterComponent<ScopeNode, ScopeNodeWidget>();
        _blazorDiagram.RegisterComponent<SwitchNode, SwitchNodeWidget>();
        _blazorDiagram.RegisterComponent<ForEachLoopNode, ForEachLoopNodeWidget>();
        _blazorDiagram.RegisterComponent<EndNode, EndNodeWidget>();

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
            2 => new ScopeNode(position),
            3 => new ForEachLoopNode(position),
            4 => new EndNode(position),
            5 => new SwitchNode(position),
        };

        node.AddPort(PortAlignment.Left);
        node.AddPort(PortAlignment.Right);

        _blazorDiagram.Nodes.Add(node);
        _draggedType = null;
    }
    private void HandleNodeClicked(NodeModel node)
    {
        SelectedNode = node;
    }
}



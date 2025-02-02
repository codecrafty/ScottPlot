﻿
namespace ScottPlot.Axis.StandardAxes;
public sealed class MirroredYAxis : YAxisBase, IYAxis
{
    private readonly Edge _edge;
    private readonly IYAxis _axis;
    public override Edge Edge => _edge;
    public override CoordinateRange Range => _axis.Range;

    public MirroredYAxis(IYAxis axis, Edge? edge)
    {
        _axis = axis;
        _edge = edge ?? axis.Edge;
        TickGenerator = axis.TickGenerator;
    }
}

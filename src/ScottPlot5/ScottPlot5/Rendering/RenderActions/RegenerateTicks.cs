namespace ScottPlot.Rendering.RenderActions;

public class RegenerateTicks : IRenderAction
{
    public void Render(RenderPack rp)
    {
        var xAxesWithData = rp.Plot.PlottableList.Select(x => x.Axes.XAxis).Distinct();
        try
        {
            foreach (IXAxis xAxis in xAxesWithData)
            {
                if (xAxis != null)
                    xAxis.RegenerateTicks(rp.DataRect.Width, rp.Paint);
            }

            var yAxesWithData = rp.Plot.PlottableList.Select(x => x.Axes.YAxis).Distinct();
            foreach (IYAxis yAxis in yAxesWithData)
            {
                if (yAxis != null)
                    yAxis.RegenerateTicks(rp.DataRect.Height, rp.Paint);
            }
        }
        catch { }
    }
}

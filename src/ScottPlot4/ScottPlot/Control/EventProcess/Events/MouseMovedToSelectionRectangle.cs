namespace ScottPlot.Control.EventProcess.Events
{
    public class MouseMovedToSelectionRectangle : IUIEvent
    {
        private readonly float X;
        private readonly float Y;
        private readonly Settings Settings;
        private readonly Configuration Configuration;
        public RenderType RenderType => Configuration.QualityConfiguration.MouseInteractiveDragged;

        public MouseMovedToSelectionRectangle(float x, float y, Settings settings, Configuration configuration)
        {
            X = x;
            Y = y;
            Settings = settings;
            Configuration = configuration;
        }

        public void ProcessEvent()
        {
            Settings.MouseSelectionRect(X, Y);
        }
    }
}

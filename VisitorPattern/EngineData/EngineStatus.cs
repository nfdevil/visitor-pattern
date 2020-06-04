namespace VisitorPattern.EngineData
{
    // Split Engine data in 2 data classes, which keep the data without the behavior
    // This way, we can add properties without having to change the Visitor's interface and implementations
    // Like the added oil pressure
    public class EngineStatus
    {
        public bool IsRunning { get; }
        public float OilPressure { get; }

        public EngineStatus(bool isRunning, float oilPressure)
        {
            IsRunning = isRunning;
            OilPressure = oilPressure;
        }
    }
}

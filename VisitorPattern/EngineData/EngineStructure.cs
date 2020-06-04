namespace VisitorPattern.EngineData
{
    // Split Engine data in 2 data classes, which keep the data without the behavior
    // This way, we can add properties without having to change the Visitor's interface and implementations
    // Like the added oil pressure in EngineStatus
    public class EngineStructure
    {
        public float HorsePower { get; }
        public float CylinderCount { get; }
        public EngineStructure(float horsePower, float cylinderCount)
        {
            HorsePower = horsePower;
            CylinderCount = cylinderCount;
        }
    }
}

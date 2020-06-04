namespace VisitorPattern.EngineData
{
    public class Engine : IVisitable<ICarPartVisitor>
    {
        private readonly float _cylinderCount;
        private readonly float _horsePower;
        private bool _isRunning;

        public Engine(float cylinderCount, float horsePower)
        {
            _cylinderCount = cylinderCount;
            _horsePower = horsePower;
        }

        public void Accept(ICarPartVisitor visitor)
        {
            var engineStructure = new EngineStructure(_horsePower, _cylinderCount);
            var engineStatus = new EngineStatus(_isRunning, 0);
            visitor.VisitEngine(engineStructure, engineStatus);
        }

        public void StartEngine() => _isRunning = true;
    }
}
using System;

namespace VisitorPattern.EngineData
{
    public class Engine
    {
        private readonly float _cylinderCount;
        private readonly float _horsePower;
        private bool _isRunning;

        public Engine(float cylinderCount, float horsePower)
        {
            _cylinderCount = cylinderCount;
            _horsePower = horsePower;
        }

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            var engineStructure = new EngineStructure(_horsePower, _cylinderCount);
            var engineStatus = new EngineStatus(_isRunning, 0);
            visitorFactory().VisitEngine(engineStructure, engineStatus);
        }

        public void StartEngine() => _isRunning = true;
    }
}
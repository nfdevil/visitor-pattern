namespace VisitorPattern
{
    public class Engine : IVisitable<ICarPartVisitor>
    {
        private readonly float _cylinderCount;
        private readonly float _horsePower;
        private bool _engineStarted;

        public Engine(float cylinderCount, float horsePower)
        {
            _cylinderCount = cylinderCount;
            _horsePower = horsePower;
        }

        public void Accept(ICarPartVisitor visitor)
        {
            visitor.VisitEngine(_cylinderCount, _horsePower, _engineStarted);
        }

        public void StartEngine() => _engineStarted = true;
    }
}
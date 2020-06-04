namespace VisitorPattern
{
    public class Engine : IVisitable<ICarPartVisitor>
    {
        public float CylinderCount { get; }
        public float HorsePower { get; }

        public Engine(float cylinderCount, float horsePower)
        {
            CylinderCount = cylinderCount;
            HorsePower = horsePower;
        }

        public void Accept(ICarPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
using System;

namespace VisitorPattern
{
    public interface ICar
    {
        CarRegistration Register();
        // The received visitor is a factory (Func<>) to create it, so there is always 1 instance
        void Accept(Func<ICarVisitor> visitorFactory);

        T Accept<T>(Func<ICarVisitor<T>> visitorFactory);
    }
}
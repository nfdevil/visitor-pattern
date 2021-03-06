﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    // This interface is not needed, but I added this to see which classes are visitable and have the base version of the Visitor pattern visible
    public interface IVisitable<TVisitor> where TVisitor : IVisitor
    {
    }

    public interface IVisitor { }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.creational.factory
{

    /// <summary>
    /// Factory class, with abstract method to be overriden in sub classes 
    /// </summary>
    public abstract class SamsungFactory
    {
        public abstract IMobile CreateMobile();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.creational.factory
{

    /// <summary>
    /// SSeries implementation of IMobile - Product
    /// </summary>
    public class SSeries : IMobile
    {
        public string ModelName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Prize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

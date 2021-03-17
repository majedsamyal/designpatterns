using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.creational.factory
{
    /// <summary>
    /// Product interface, IMobile
    /// </summary>
    public interface IMobile
    {
        public string ModelName { get; set; }
        public string Prize { get; set; }
    }
}

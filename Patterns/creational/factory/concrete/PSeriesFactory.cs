using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.creational.factory
{
    public class PSeriesFactory : SamsungFactory
    {
        public override IMobile CreateMobile()
        {
            return new PSeries();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace somecode.Protected
{
    internal class Human
    {
        protected int protectedAge { get; set; }
        protected int publicAge { get; set; }
        public void DisplayAge()
        {
            this.protectedAge = 25;
            Console.WriteLine($"Protected Age: {protectedAge}");
        }
    }
}

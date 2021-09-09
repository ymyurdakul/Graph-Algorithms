using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Gen
    {
        private char value;
        public char Value { get { return this.value; } set { this.value = value; } }
        public Gen(char value)
        {
            this.value = value;
        }
    }
}

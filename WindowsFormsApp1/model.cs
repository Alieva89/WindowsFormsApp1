using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class model: Controller

    {

        public delegate void ResultDelegate(int result);
        public event ResultDelegate NotiFicate;
        public int Sum(int a, int b)
        {
            NotiFicate.Invoke(a + b);
        }

        public int Sub(int a, int b)
        {
            NotiFicate.Invoke(a - b);
        }
        public int Dev(int a, int b)
        {
            NotiFicate.Invoke(a * b);
        }
        public int Multy(int a, int b)
        {
            NotiFicate.Invoke(a / b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public delegate void Alive();
    public class AliveChecker
    {
        public event Alive CheckVitals;
        public event Alive Beep;

        public void Start()
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                System.Threading.Thread.Sleep(1000);
                CheckVitals();
                Beep();
            }
        }
    }
}

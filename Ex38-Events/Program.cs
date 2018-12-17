using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            ImAlive isIAlive = new ImAlive();
            AliveChecker aliveChecker = new AliveChecker();
            aliveChecker.CheckVitals += isIAlive.StillHere;
            aliveChecker.Beep += isIAlive.BeepBeep;

            aliveChecker.Start();
        }
    }
}

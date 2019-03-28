using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class Cronometro
    {
        public static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public static int alarmCounter = 1;
        public static bool exitFlag = false;

        public static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();
            exitFlag = true;
        }
    }
}

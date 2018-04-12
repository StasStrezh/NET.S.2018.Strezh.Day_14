using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    class Listener
    {
        private Timer timer;
        public Listener(Timer timer)
        {
        }

        public void OnTimerTimeout(object sender, TimeoutEventArgs e)
        {
            System.Console.WriteLine("First listener: timer {0} reached {1} second timeout.", sender, e.Seconds);
        }
    }
}

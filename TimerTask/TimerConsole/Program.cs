using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    class TimerConsole
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Listener first = new Listener(timer);

            timer.StartTimer(5);

            timer.Timeout += first.OnTimerTimeout;

            System.Threading.Thread.Sleep(5500);

            timer.Timeout -= first.OnTimerTimeout;
            timer.StartTimer(5);

            System.Threading.Thread.Sleep(5500);

            Console.WriteLine("Timer reached timeout.");
            Console.ReadKey();
        }
    }
}

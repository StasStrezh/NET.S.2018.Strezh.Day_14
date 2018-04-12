using System;

namespace TimerTask
{
    public class TimeoutEventArgs : EventArgs
    {
        public int Seconds { get; set; }
        public TimeoutEventArgs(int seconds) : base()
        {
            Seconds = seconds;
        }
    }
}

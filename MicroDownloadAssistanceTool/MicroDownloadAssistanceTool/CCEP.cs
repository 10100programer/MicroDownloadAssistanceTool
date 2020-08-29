using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MicroDownloadAssistanceTool
{
    /// <summary>
    /// Constant Clipboard Examination Process
    /// 
    /// </summary>
    class CCEP
    {
        private System.Timers.Timer aTimer;
        public CCEP(double TimeinMStoCheck)
        {
            aTimer = new System.Timers.Timer(TimeinMStoCheck);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object source,ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
        }
        void Enable()
        {

        }
        void Disable()
        {

        }
    }
}

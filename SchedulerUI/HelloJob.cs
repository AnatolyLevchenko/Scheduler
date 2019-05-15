using System;
using System.Windows.Forms;
using Quartz;

namespace SchedulerUI
{
    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            MessageBox.Show("Invoked");
        }
    }
}

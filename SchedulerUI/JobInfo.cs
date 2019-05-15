using Quartz;

namespace SchedulerUI
{
    public class JobInfo
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string KeyName { get; set; }
        //public string KeyGroup { get; set; }
        //public string TriggerTypeName { get; set; }

        public TriggerState TriggerState { get; set; }

        public string NextFireTime { get; set; }

        public string PreviousFireTime { get; set; }
        public string TriggerName { get; set; }
        public string TriggerKeyGroup { get; set; }
    }
}

using System;

namespace SchedulerUI.ViewModels
{
    public class TriggerModel
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public string PreviousFireTimeUTC { get; set; }
        public string NextFireTimeUTC { get; set; }
    }
}

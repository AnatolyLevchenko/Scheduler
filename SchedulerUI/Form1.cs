using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
//using Quartz;
//using Quartz.Impl;
using Scheduler.Data;

namespace SchedulerUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            StdSchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler Scheduler =  schedFact.GetScheduler();

            var jobs = GetAllJobs(Scheduler);
            dataGridView1.DataSource = jobs;

            try
            {
                Scheduler.Start();
            }
            catch (Quartz.SchedulerConfigException ex)
            {
                RemoveNonExistingJobs(ex, Scheduler);
                Scheduler.Start();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            WriteToFile("Quartz.Net Started ...");

            //Test001(Scheduler);

            //WriteToFile("Quartz.Net Running ...");

            
            
           




        }

        private static void Test001(IScheduler Scheduler)
        {
            IJobDetail helloJob = JobBuilder.Create<HelloJob>()
                .WithIdentity("HelloJob")
                // .RequestRecovery(true)
                // .StoreDurably(false)
                .Build();

            ITrigger helloTrigger = TriggerBuilder.Create()
                .WithIdentity("HelloTrigger")
                .StartNow()
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(1).RepeatForever())
                .Build();

            Scheduler.ScheduleJob(helloJob, helloTrigger);

        }

        private static bool RemoveNonExistingJobs(Exception ex, IScheduler scheduler)
        {
            IList<string> typesToRemove = new List<string>();

            Exception innerException = ex;

            while (innerException != null)
            {
                if (innerException is System.TypeLoadException)
                {
                    typesToRemove.Add((innerException as System.TypeLoadException).TypeName);
                }
                innerException = ParseExceptions(innerException);
            }

            if (typesToRemove.Count > 0)
            {
                foreach (var jobName in typesToRemove)
                {
                    if (!scheduler.CheckExists(new JobKey(jobName)))
                    {
                        scheduler.DeleteJob(new JobKey(jobName));
                    }
                }
            }

            return (true);
        }

        private static Exception ParseExceptions(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return (ex.InnerException);
            }
            return (null);
        }


        private static List<JobInfo> GetAllJobs(IScheduler scheduler)
        {
            List<JobInfo> ls=new List<JobInfo>();

            IList<string> jobGroups = scheduler.GetJobGroupNames();

            foreach (string group in jobGroups)
            {
                var groupMatcher = GroupMatcher<JobKey>.GroupContains(group);
                var jobKeys = scheduler.GetJobKeys(groupMatcher);
                foreach (var jobKey in jobKeys)
                {
                    var detail = scheduler.GetJobDetail(jobKey);
                    var triggers = scheduler.GetTriggersOfJob(jobKey);
                    foreach (ITrigger trigger in triggers)
                    {
                        JobInfo job = new JobInfo
                        {
                            Group = group,
                            Description = detail.Description,
                            TriggerName = trigger.Key.Name,
                            TriggerKeyGroup = trigger.Key.Group,
                            TriggerState = scheduler.GetTriggerState(trigger.Key),
                            Name = jobKey.Name
                        };

                        DateTimeOffset? nextFireTime = trigger.GetNextFireTimeUtc();
                        if (nextFireTime.HasValue)
                        {
                            job.NextFireTime=nextFireTime.Value.LocalDateTime.ToString();
                        }

                        DateTimeOffset? previousFireTime = trigger.GetPreviousFireTimeUtc();
                        if (previousFireTime.HasValue)
                        {
                            job.PreviousFireTime=previousFireTime.Value.LocalDateTime.ToString();
                        }
                        ls.Add(job);
                    }
                }
            }

            return ls;
        }

        void WriteToFile(string s)
        {
            this.textBox1.Text += s;
        }

    }
}

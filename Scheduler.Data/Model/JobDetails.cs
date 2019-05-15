using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace Scheduler.Data.Model
{
    [Table("qrtz_job_details")]
    class JobDetails
    {
        public string Name { get; set; }
    }

}

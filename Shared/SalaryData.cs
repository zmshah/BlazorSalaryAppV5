using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSalaryAppV5.Shared
{
    public class SalaryData
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public string College { get; set; }
        public string Division { get; set; }
        public string JobTitle { get; set; }
        public float PayYearly { get; set; }
        public float PayYTD { get; set; }
    }
}

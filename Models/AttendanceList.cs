using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2
{
    [Serializable]
    public class AttendanceList
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        
    }
}

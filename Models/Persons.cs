using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2
{
    [Serializable]
    public class Persons
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; } = DateTime.Now;
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool Status { get; set; } = false;

    }
}

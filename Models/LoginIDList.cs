using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2
{
    [Serializable]
    public class LoginIDList
    {
        public int ID { get; set; }
        public string LoginID { get; set; }
        public string Password { get; set; }

    }
}

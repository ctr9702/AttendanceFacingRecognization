using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2
{
    public class AttendanceVM
    {
        public BindingSource AttendanceListBindingSource { get; set; }
        
        public void Load()
        {
            List<AttendanceList> attendanceLists;
            var formatter = new BinaryFormatter();
            //using file to save data
            if (!File.Exists("AttendanceListData.dat"))
            {
                attendanceLists = new List<AttendanceList>();
                var stream = File.Create("AttendanceListData.dat");
                formatter.Serialize(stream, attendanceLists);
                stream.Close();
            }
            else
            {
                using (var stream = File.OpenRead("AttendanceListData.dat"))
                {
                    attendanceLists = formatter.Deserialize(stream) as List<AttendanceList>;
                }
            }


            AttendanceListBindingSource.ResetBindings(false);
            AttendanceListBindingSource.DataSource = attendanceLists;
        }
        public void Save()
        {
            using (var stream = File.OpenWrite("AttendanceListData.dat"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, AttendanceListBindingSource.DataSource);
            }
        }
        public void Add(AttendanceList c)
        {
            AttendanceListBindingSource.Add(c);

        }
        public void AddNew() => AttendanceListBindingSource.AddNew();
        public void Delete() => AttendanceListBindingSource.RemoveCurrent();
    }
}

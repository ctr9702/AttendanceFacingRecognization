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
    public class PersonsVM
    {
        public BindingSource PersonsBindingSource { get; set; }

        public void Load()
        {
            List<Persons> persons;
            var formatter = new BinaryFormatter();
            //using file to save data
            if (!File.Exists("PersonsData.dat"))
            {
                persons = new List<Persons>();
                var stream = File.Create("PersonsData.dat");
                formatter.Serialize(stream, persons);
                stream.Close();
            }
            else
            {
                using (var stream = File.OpenRead("PersonsData.dat"))
                {
                    persons = formatter.Deserialize(stream) as List<Persons>;
                }
            }


            PersonsBindingSource.ResetBindings(false);
            PersonsBindingSource.DataSource = persons;
        }
        public void Save()
        {
            using (var stream = File.OpenWrite("PersonsData.dat"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, PersonsBindingSource.DataSource);
            }
        }
        public void Add(AttendanceList c)
        {
            PersonsBindingSource.Add(c);

        }
        public void AddNew() => PersonsBindingSource.AddNew();
        public void Delete() => PersonsBindingSource.RemoveCurrent();
    }
}

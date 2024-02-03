using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2
{
    public partial class FormAttendanceList : Form
    {
        AttendanceVM _at= new AttendanceVM();
        public FormAttendanceList()
        {
            InitializeComponent();
            _at.AttendanceListBindingSource = attendanceListBindingSource;
            Load += delegate { _at.Load(); };
            btnSave.Click += delegate { _at.Save(); };
            btnReset.Click += delegate { _at.Load(); };
            btnDelete.Click += delegate { _at.Delete(); };
            btnAdd.Click += delegate { _at.AddNew(); };
        }

       
    }
}

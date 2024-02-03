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
    public partial class FormPersons : Form
    {
        PersonsVM _p = new PersonsVM();
        FormTrainingPic _tp = new FormTrainingPic();
        public FormPersons()
        {
            InitializeComponent();
            _p.PersonsBindingSource = personsBindingSource;
            Load += delegate { _p.Load(); };
            btnSave.Click += delegate { _p.Save(); };
            btnReset.Click += delegate { _p.Load(); };
            btnDelete.Click += delegate { _p.Delete(); };
            btnAdd.Click += delegate { _p.AddNew(); };
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            _tp.Show();
        }
    }
}

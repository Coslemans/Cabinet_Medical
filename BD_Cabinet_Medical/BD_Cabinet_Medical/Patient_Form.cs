using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Cabinet_Medical
{
    public partial class Patient_Form : Form
    {
        private Patient Abouts;
        public Patient_Form(Patient P)
        {
            InitializeComponent();
            Abouts = P;
            Show();
        }
    }
}

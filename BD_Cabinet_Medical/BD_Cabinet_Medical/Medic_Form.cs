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
    public partial class Medic_Form : Form
    {
        Employee Abouts;
        public Medic_Form(Employee E)
        {
            InitializeComponent();
            Abouts = E;
            Show();
            
        }
    }
}

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
    
    public partial class View_Form : Form
    {
        Patient Pacient;
        public View_Form(Patient P)
        {
            InitializeComponent();
            Pacient = P;
           
        }

        private void labelAdaugare_Click(object sender, EventArgs e)
        {

        }

        private void buttonReteta_Click(object sender, EventArgs e)
        {

        }

        private void View_Form_Load(object sender, EventArgs e)
        {
            labelNume.Text = Pacient.Nume.ToString().Trim();
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from ist in context.History_Patients
                            select new
                            {
                                ist.Data,
                                ist.ID_Afectiune
                            };

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNume_Click(object sender, EventArgs e)
        {
          

        }

        private void ViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

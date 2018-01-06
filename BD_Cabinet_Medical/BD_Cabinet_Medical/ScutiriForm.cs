using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;


namespace BD_Cabinet_Medical
{
    public partial class ScutiriForm : Form
    {
        Patient Pacient;
        public ScutiriForm(Patient P)
        {
            InitializeComponent();
            Pacient = P;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new Cabinet_MedicalEntities())
            {
                string medic = textBoxMedic.Text;
                string afectiune = textBoxAfectiune.Text;
                var query = (from m in context.Employees
                             where m.Nume.Equals(medic)
                             select m).First();
                var query2 = (from a in context.Diseases

                              where a.Denumire.Equals(afectiune)
                              select a).First();
         
                var addnew = new History_Patients
                {

                    ID_Medic = query.ID,
                    
                    Data = DateTime.Now,
                    ID_Pacient = Pacient.ID,
                    ID_Afectiune = query2.ID

                };
                context.History_Patients.Add(addnew);
                context.SaveChanges();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            View_Form view = new View_Form(Pacient);
            view.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

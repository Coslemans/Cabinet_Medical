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
    public partial class RetetaForm : Form
    {
        Patient Pacient;
        Form formParent;
       
        public RetetaForm(Patient P,Form formparent)
        {
            InitializeComponent();
            Pacient = P;
            formParent = formparent;
            labelData.Text = labelData.Text +": "+ DateTime.Now.ToString();
            labelNume.Text = labelNume.Text + ": " + Pacient.Nume.ToString();
            labelCNP.Text = labelCNP.Text + ": " + Pacient.CNP.ToString();
            button1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMedic_Click(object sender, EventArgs e)
        {

        }

        private void labelMed_Click(object sender, EventArgs e)
        {

        }

        private void RetetaForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAf_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formParent.Show();
            this.Close();
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new Cabinet_MedicalEntities())
            {
                
            }
        }
    }
}

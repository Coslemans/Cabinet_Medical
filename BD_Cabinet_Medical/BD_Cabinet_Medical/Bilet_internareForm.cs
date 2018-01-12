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
    public partial class Bilet_internareForm : Form
    {
        Employee medic;
        Patient pacient;

        void FillCombo()
        {
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from emp in context.Diseases
                            select emp.Denumire;
                if(query.Count()!=0)
                {
                    foreach(var dis in query)
                    {
                        diseaseBox.Items.Add(dis.ToString().Trim());
                    }
                }
            }
        }
        public Bilet_internareForm(Employee E,Patient p)
        {
            InitializeComponent();
            medic = E;
            pacient = p;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void Bilet_internareForm_Load(object sender, EventArgs e)
        {
            this.Text = "Bilet internare";
            regLabel.Text= "Registered as " + medic.Nume.ToString().Trim();
            unitTextBox.Text = "S.C. BITmedical S.A." ;
            countyTextBox.Text = "Bucuresti";
            cityTextBox.Text = "Bucuresti";
            FillCombo();
            nameTextBox.Text = pacient.Nume.ToString().Trim();
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void regLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveTicket_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Cabinet_MedicalEntities())
                {


                    var af = (from afect in context.Diseases
                              where afect.Denumire.Equals(diseaseBox.SelectedItem.ToString().Trim())
                              select afect.ID).ToList().First();
                    History_Patients hist = new History_Patients
                    {
                        ID_Afectiune = af,
                        ID_Pacient = pacient.ID,
                        ID_Medic = medic.ID,
                        Data = DateTime.Now

                    };
                    context.History_Patients.Add(hist);
                    context.SaveChanges();

                        Internment_Tickets bilet = new Internment_Tickets
                        {
                            ID_Istoric = hist.ID,
                            Descriere = diseaseBox.Text.ToString().Trim()
                        };
                        context.Internment_Tickets.Add(bilet);
                        context.SaveChanges();
                    MessageBox.Show("Biletul de trimitere a fost inregistrat!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

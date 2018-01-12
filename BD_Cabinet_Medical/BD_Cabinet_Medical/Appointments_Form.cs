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
    public partial class Appointments_Form : Form
    {
        Employee Abouts;
        Form Login;
        public Appointments_Form(Employee E, Form F)
        {
            InitializeComponent();
            Abouts = E;
            Login = F;
            Show();
        }

        private void Appointments_Form_Load(object sender, EventArgs e)
        {
            try
            {
                Name_Label.Text = Abouts.Nume.ToString().Trim();
                Specs_Label.Text = Abouts.Specializare.ToString().Trim();


                using (var context = new Cabinet_MedicalEntities())
                {
                    var query = from app in context.Appointments
                                join pat in context.Patients
                                on app.ID_Pacient equals pat.ID
                                where app.ID_Medic.Equals(Abouts.ID)
                                select new
                                {
                                    pat.Nume,
                                    app.Date,
                                    app.Accepted
                                };
                    if (query.Count() != 0)
                    {
                        foreach (var line in query)
                        {
                            if (line.Accepted == 1)
                                PatientsData.Rows.Add(line.Nume.ToString().Trim(), line.Date.ToString().Trim(), "In Asteptare");
                            else if (line.Accepted == 2)
                                PatientsData.Rows.Add(line.Nume.ToString().Trim(), line.Date.ToString().Trim(), "Consultat");
                            else if (line.Accepted == 3)
                                PatientsData.Rows.Add(line.Nume.ToString().Trim(), line.Date.ToString().Trim(), "Refuzat");
                        }
                    }
                    else
                        throw new Exception("Nu sunt programari in asteptare!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            new Medic_Form(Abouts, Login);
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(PatientsData.SelectedRows.Count==0)
                {
                    throw new Exception("Selectati o programare!");
                }
                if (PatientsData.SelectedCells[2].Value.ToString().Equals("Consultat"))
                    throw new Exception("Pacientul a fost deja consultat!");
                if (PatientsData.SelectedCells[2].Value.ToString().Equals("Refuzat"))
                    throw new Exception("Pacientul a fost deja refuzat!");
                using (var context = new Cabinet_MedicalEntities())
                {
                    string name = PatientsData.SelectedCells[0].Value.ToString();
                    var query = (from app in context.Appointments
                                join pat in context.Patients
                                on app.ID_Pacient equals pat.ID
                                where pat.Nume.Equals(name)
                                select new
                                {
                                    app.Accepted,
                                    pat.ID
                                }).First();
                    PatientsData.SelectedCells[2].Value = "Consultat";
                    var query2 = (from app in context.Appointments
                                  where app.ID_Pacient == query.ID
                                  select app).First();
                    var query3 = (from pat in context.Patients
                                 where pat.Nume.Equals(name)
                                 select pat).First();
                    query2.Accepted = 2;
                    context.SaveChanges();
                    Form p = new View_Form(query3, this,Abouts);
                    p.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deny_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (PatientsData.SelectedRows.Count == 0)
                {
                    throw new Exception("Selectati o programare!");
                }
                if (PatientsData.SelectedCells[2].Value.ToString().Equals("Consultat"))
                    throw new Exception("Pacientul a fost deja consultat!");
                if (PatientsData.SelectedCells[2].Value.ToString().Equals("Refuzat"))
                    throw new Exception("Pacientul a fost deja refuzat!");
                using (var context = new Cabinet_MedicalEntities())
                {
                    string name = PatientsData.SelectedCells[0].Value.ToString();
                    var query = (from app in context.Appointments
                                 join pat in context.Patients
                                 on app.ID_Pacient equals pat.ID
                                 where pat.Nume.Equals(name)
                                 select new
                                 {
                                     app.Accepted,
                                     pat.ID
                                 }).First();
                    PatientsData.SelectedCells[2].Value = "Refuzat";
                    var query2 = (from app in context.Appointments
                                  where app.ID_Pacient == query.ID
                                  select app).First();
                    var query3 = (from pat in context.Patients
                                  where pat.Nume.Equals(name)
                                  select pat).First();
                    query2.Accepted = 3;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

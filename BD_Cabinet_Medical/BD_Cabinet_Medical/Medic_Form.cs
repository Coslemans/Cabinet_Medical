using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace BD_Cabinet_Medical
{
    public partial class Medic_Form : Form
    {
        Employee Abouts;
        Form Login;
        public Medic_Form(Employee E, Form F)
        {
            InitializeComponent();
            Abouts = E;
            Show();
            Login = F;
        }

        private void Medic_Form_Load(object sender, EventArgs e)
        {
            this.Text = Abouts.Nume.ToString().Trim() + " Window";
            Name_Label.Text = Abouts.Nume.ToString().Trim();
            Specs_Label.Text = Abouts.Specializare.ToString().Trim();
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from emp in context.Patients
                            select new
                            {
                                emp.Nume,
                                emp.CNP,
                                emp.Serie_Buletin,
                                emp.Numar_Buletin,
                                emp.Data_Nasterii
                            };
                            

                foreach(var row in query)
                {
                    
                    PacientsData.Rows.Add(row.Nume.ToString().Trim(), row.CNP.ToString().Trim(),
                        row.Serie_Buletin.ToString().Trim(), row.Numar_Buletin.ToString().Trim(),
                        row.Data_Nasterii.ToString().Trim());
                }
            }
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from app in context.Appointments
                            where app.ID_Medic.Equals(Abouts.ID)
                            select app;
                Request_Label.Text = query.Count().ToString().Trim() + " Appointments";
                if(query.Count()!=0)
                {
                    Request_Label.BackColor = Color.Red;
                }
            }

            if(Equals(Abouts.Specializare.ToString().Trim(),"Asistent")==true)
            {

                Add_Button.Enabled = false;
                Delete_Button.Enabled = false;
                
            }
        }

        ~Medic_Form()
        {
            this.Close();
            Application.Exit();
        }

        private void Request_Label_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Doresti sa te deloghezi?", "Message",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
            else if (res == DialogResult.No)
                return;
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (PacientsData.SelectedRows.Count == 0)
                {
                    throw new Exception("Selectati un pacient!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (PacientsData.SelectedRows.Count == 0)
                {
                    throw new Exception("Selectati un pacient!");
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

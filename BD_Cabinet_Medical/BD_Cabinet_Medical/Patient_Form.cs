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
        Form Login;
        public Patient_Form(Patient P,Form f)
        {
            InitializeComponent();
            Abouts = P;
            Show();
            Login = f;
        }
        void FillCombo()
        {
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from emp in context.Employees
                            where emp.Specializare != "Asistent"
                            select                         
                                emp.Nume;
                if(query.Count()!=0)
                {
                    foreach(var doc in query)
                    {
                        Doctors.Items.Add(doc.ToString());
                    }
                }           
            
            }
        }

        private void Patient_Form_Load(object sender, EventArgs e)
        {
            this.Text = Abouts.Nume.ToString().Trim() + " Window";
            nameLabel.Text = Abouts.Nume.ToString().Trim();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Doresti sa te deloghezi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
            else if (res == DialogResult.No)
                return;
        }

        private void newAppointment_Click(object sender, EventArgs e)
        {
            Doctors.Enabled = true;
            dateTime.Enabled = true;
            saveAppointment.Enabled = true;
            FillCombo();
        }

        private void saveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if(Doctors.SelectedItem==null)
                {
                    throw new Exception("Selectati un medic!");

                }
                else if(dateTime.Checked==false)
                {
                    throw new Exception("Selectati o data!");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

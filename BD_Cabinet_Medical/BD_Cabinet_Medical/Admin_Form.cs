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
    public partial class Admin_Form : Form
    {
        Form Login;
        public Admin_Form(Form F)
        {
            InitializeComponent();
            Login = F;
            Show();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(Password_Box.Text.Length==0)
                {
                    throw new Exception("Introduceti parola!");
                }
                string username = "admin";
                string password = Password_Box.Text.Trim();

                using (var context = new Cabinet_MedicalEntities())
                {
                    var query = from app in context.Employees
                                where app.Username.Equals(username) && app.Parola.Equals(password)
                                select app;
                    if(query.Count()==0)
                    {
                        throw new Exception("Parola este incorecta!");
                    }

                    User_Label.Visible = false;
                    Password_Label.Visible = false;
                    admin_label.Visible = false;
                    Password_Box.Visible = false;
                    Login_Button.Visible = false;
                    Cancel_Button.Visible = false;
                    Exit.Visible = true;
                    AddMed.Visible = true;
                    AddPill.Visible = true;
                   

                    
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
            Login.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
            Login.Show();
        }

        private void AddMed_Click(object sender, EventArgs e)
        {
            Name_Box.Visible = true;
            Name_Label.Visible = true;
            Specializare_Label.Visible = true;
            Spec_Box.Visible = true;
            Username_Box.Visible = true;
            Username_Label.Visible = true;
            Parola_Label.Visible = true;
            Parola_Box.Visible = true;
            Date_Label.Visible = false;
            Stoc_Label.Visible = false;
        }

        private void AddPill_Click(object sender, EventArgs e)
        {
            Name_Box.Visible = true;
            Name_Label.Visible = true;
            Specializare_Label.Visible = false;
            Spec_Box.Visible = false;
            Username_Box.Visible = true;
            Username_Label.Visible = false;
            Parola_Label.Visible = false;
            Parola_Box.Visible = false;
            Date_Label.Visible = true;
            Stoc_Label.Visible = true;
        }
    }
}

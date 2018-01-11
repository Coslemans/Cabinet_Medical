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
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string getMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for(int i=0;i<result.Length;i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (Username_Box.Text.Length == 0)
                {
                    throw new Exception("Nu ati introdus numele utilizatorului!");
                }
                else if (Password_Box.Text.Length == 0)
                {
                    throw new Exception("Nu ati introdus parola utilizatorului!");
                }
                else if (Login_Type.SelectedItem == null)
                {
                    throw new Exception("Nu ati selectat tipul de utilizator!");
                }
                else
                {
                    string Username = Username_Box.Text.ToString();
                    string Password = getMD5(Password_Box.Text.ToString());
                    //string Password = Password_Box.Text.ToString();
                    string Type = Login_Type.SelectedItem.ToString();
                    using (var context = new Cabinet_MedicalEntities())
                    {
                       
                        if (Equals(Type, "Pacient"))
                        {
                            var employee = (from emp in context.Patients
                                           where emp.Username.Equals(Username) &&
                                           emp.Parola.Equals(Password)
                                           select emp).ToList();
                            if (employee.Count==0)
                            {
                                throw new Exception("Utilizatorul nu exista!");
                            }
                            else if(employee.Count==1)
                            {
                                MessageBox.Show("Logarea s-a efectuat cu succes!",
                                    "Message", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                                Hide();
                                new Patient_Form(employee[0],this);
                                Username_Box.Text = "";
                                Password_Box.Text = "";
                                // Show();
                            }
                        }
                        
                        else if(Equals(Type,"Medic/Asistent"))
                        {
                            var employee = (from emp in context.Employees
                                            where emp.Username.Equals(Username) &&
                                            emp.Parola.Equals(Password)
                                            select emp).ToList();
                            if (employee.Count == 0)
                            {
                                throw new Exception("Utilizatorul nu exista!");
                            }
                            else if(employee.Count==1)
                            {
                                MessageBox.Show("Logarea s-a efectuat cu succes!", 
                                    "Message", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                                Hide();
                                new Medic_Form(employee[0],this);
                                // Show();
                                Username_Box.Text = "";
                                Password_Box.Text = "";
                            }
                        }

                        
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Button_Click(object sender, EventArgs e)
        {
            new Admin_Form(this);
            Hide();
        }
    }
}

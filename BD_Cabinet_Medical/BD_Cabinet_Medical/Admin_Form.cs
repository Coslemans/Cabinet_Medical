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

        public string getMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
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
                string password = getMD5(Password_Box.Text.Trim());

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
                    DatePick.Visible = false;
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

            Add_Med.Visible = true;
            Add_Pill.Visible = false;
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
            DatePick.Visible = false;
            Name_Box.Text = "";
            Username_Box.Text = "";
            Spec_Box.Text = "";
            Parola_Box.Text = "";
            
        }

        private void AddPill_Click(object sender, EventArgs e)
        {
            Add_Med.Visible = false;
            Add_Pill.Visible = true;
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
            DatePick.Visible = true;
            Name_Box.Text = "";
            Username_Box.Text = "";
            DatePick.Text = "";
           
        }

        private void admin_label_Click(object sender, EventArgs e)
        {

        }

        private void Add_Med_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Box.Text.Length == 0)
                    throw new Exception("Introduceti numele!");
                if (Spec_Box.Text.Length == 0)
                    throw new Exception("Introduceti specializarea!");
                if (Username_Box.Text.Length == 0)
                    throw new Exception("Introduceti username-ul!");
                if (Parola_Box.Text.Length == 0)
                    throw new Exception("Introduceti parola!");
                Employee E = new Employee();
                E.Nume = Name_Box.Text.Trim();
                E.Specializare = Spec_Box.Text.Trim();
                E.Username = Username_Box.Text.Trim();
                E.Parola = getMD5(Parola_Box.Text.Trim());
             //  E.Parola = Parola_Box.Text.Trim();
                using (var context = new Cabinet_MedicalEntities())
                {
                    var query = from emp in context.Employees
                                where emp.Nume.Equals(E.Nume) ||
                                emp.Username.Equals(E.Username)
                                select emp;
                    if (query.Count() != 0)
                        throw new Exception("Medicul sau Username-ul exista deja in baza de date!");
                    context.Employees.Add(E);
                    context.SaveChanges();
                    MessageBox.Show("Adaugarea s-a efectuat cu succes!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Pill_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Box.Text.Length == 0)
                    throw new Exception("Introduceti numele medicamentului!");
                if (DatePick.Text.Length == 0)
                    throw new Exception("Alegeti data expirarii!");
                if (Username_Box.Text.Length == 0)
                    throw new Exception("Introduceti numarul de produse!");

                Drug med = new Drug();
                med.Denumire = Name_Box.Text.Trim();
                med.Stoc = Int32.Parse(Username_Box.Text.Trim());
                med.Data_Expirarii = DatePick.Value;
                
                using (var context = new Cabinet_MedicalEntities())
                {
                    var query = (from pill in context.Drugs
                                where pill.Denumire.Equals(med.Denumire)
                                select pill).First();
                    if(query!=null)
                    {
                        query.Stoc += med.Stoc;
                        context.SaveChanges();
                        MessageBox.Show("Stocul de " + med.Denumire + " a fost actualizat!", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        context.Drugs.Add(med);
                        context.SaveChanges();
                        MessageBox.Show("Adaugarea s-a efectuat cu succes!", "Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BD_Cabinet_Medical
{
    public partial class Add_Form : Form
    {
        Employee Abouts;
        public Add_Form(Employee E)
        {
            InitializeComponent();
            Abouts = E;
            //Show();
        }

        
        private void Add_Form_Load(object sender, EventArgs e)
        {
            this.Text = "Adaugare pacient";
            nameBox.Focus();
            registerLabel.Text = "Registered as "+Abouts.Nume;
        }
        bool check_Pass(string pass)
        {
            if (pass.Length < 6)
                return false;
            else
                return true;
        }
        bool numberOnly(string element)
        {
            for(int i=0;i<element.Length;i++)
            {
                if (Char.IsNumber(element, i) == false)
                    return false;
            }
            return true;
        }
        bool letterOnly(string element)
        {
            for(int i=0;i<element.Length;i++)
            {
                if (char.IsLetter(element, i) == false)
                    return false;
            }
            return true;
        }

        bool checkExists(string nume,string cnp, string Serie,string numar)
        {
            var context = new Cabinet_MedicalEntities();
            var query = from pat in context.Patients
                        select new
                        {
                            pat.Nume,
                            pat.CNP,
                            pat.Serie_Buletin,
                            pat.Numar_Buletin,
                            //pat.Data_Nasterii
                        };
            foreach(var patient in query)
            {
                if (nume.Equals(patient.Nume.Trim()) && cnp.Equals(patient.CNP.Trim()) && Serie.Equals(patient.Serie_Buletin.Trim()) && numar.Equals(patient.Numar_Buletin.Trim()) /*&& p.Data_Nasterii.Equals(patient.Data_Nasterii)*/)
                    return true;
            }
            return false;
        }

        bool userExists(string user)
        {
            var context = new Cabinet_MedicalEntities();
            var query = from username in context.Patients
                        select new
                        {
                            username.Username
                        };
            foreach(var usr in query)
            {
                if (usr.Username.ToString().Trim().Equals(user))
                    return true;
            }
            return false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text == "")
                    throw new Exception("Campul nume nu a fost commpletat!");
                else if (cnpBox.Text == "")
                    throw new Exception("Campul CNP nu a fost completat!");
                else if (serieBox.Text == "")
                    throw new Exception("Campul Serie_buletin nu a fost completat!");
                else if (numberBox.Text == "")
                    throw new Exception("Campul Numar_buletin nu a fost completat!");
                else if (data_nasterePick.Value == null)
                    throw new Exception("Nu ati ales Data nasterii!");
                else if (userBox.Text == "")
                    throw new Exception("Nu ati ales un username!");
                else if (passwordBox.Text == "")
                    throw new Exception("Nu ati introdus o parola!");
                else if (passwordBox.Text != confirmBox.Text)
                    throw new Exception("Parola nu se potriveste!");
                
                else
                {
                    if (cnpBox.Text.Length < 13)
                        throw new Exception("CNP-ul trebuie sa contina 13 cifre!");
                    if (serieBox.Text.Length < 2)
                        throw new Exception("Seria buletinului este formata din 2 litere!");
                    if (numberBox.Text.Length < 6)
                        throw new Exception("Numarul butletinului este format din 6 cifre!");
                    if (check_Pass(passwordBox.Text.ToString()) == false)
                        throw new Exception("Parola trebuie sa contina cel putin 6 caractere!");
                    if (numberOnly(cnpBox.Text.ToString())==false)
                        throw new Exception("Campul CNP trebuie sa contina doar cifre!");
                    if (numberOnly(numberBox.Text.ToString())==false)
                        throw new Exception("Campul Numar_buletin trebuie sa contina doar cifre!");
                    if (letterOnly(serieBox.Text.ToString()) == false)
                        throw new Exception("Campul Serie_buletin trebuie sa contina doar lietere!");

                    else
                    {
                        Patient p = new Patient();
                        p.Nume = nameBox.Text.ToString();
                        p.CNP = cnpBox.Text.ToString();
                        p.Serie_Buletin = serieBox.Text.ToString();
                        p.Numar_Buletin = numberBox.Text.ToString();
                        p.Data_Nasterii = data_nasterePick.Value;
                        p.Username = userBox.Text.ToString();
                        p.Parola = passwordBox.Text.ToString();
                        if (checkExists(nameBox.Text,cnpBox.Text,serieBox.Text,numberBox.Text) == true)
                            throw new Exception("Pacientul este deja inregistrat!");
                        else if (userExists(userBox.Text) == true)
                            throw new Exception("Username-ul este deja inregistrat!\nIncercati alt username!");
                        else
                        {
                            //var context = new Cabinet_MedicalEntities();
                            var con = new SqlConnection();
                            con.ConnectionString = ConfigurationManager.ConnectionStrings["BD_Cabinet_Medical.Properties.Settings.Cabinet_MedicalConnectionString"].ConnectionString;
                            //con.ConnectionString = @"Data Source=DESKTOP-3R1BJRO;Initial Catalog=Cabinet_Medical;Integrated Security=True";
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "INSERT INTO Patients (ID,Nume,CNP,Serie_buletin,Numar_buletin,Data_nasterii,Username,Parola) VALUES (@ID,@Nume,@CNP,@Serie,@Numar,@Data,@User,@Pass)";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = 4;
                            cmd.Parameters.Add("@Nume", SqlDbType.NChar, 25).Value = nameBox.Text.ToString();
                            cmd.Parameters.Add("@CNP", SqlDbType.Char, 13).Value = cnpBox.Text.ToString();
                            cmd.Parameters.Add("@Serie", SqlDbType.NChar, 2).Value = serieBox.Text.ToString();
                            cmd.Parameters.Add("@Numar", SqlDbType.NChar, 6).Value = numberBox.Text.ToString();
                            cmd.Parameters.Add("@Data", SqlDbType.Date).Value = data_nasterePick.Value;
                            cmd.Parameters.Add("@User", SqlDbType.NChar, 25).Value = userBox.Text.ToString();
                            cmd.Parameters.Add("@Pass", SqlDbType.NChar, 25).Value = passwordBox.Text.ToString();
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Pacientul a fost inregistrat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //context.Patients.Add(p);
                            //context.SaveChanges();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reintroduceti datele", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            cnpBox.Text = "";
            serieBox.Text = "";
            numberBox.Text = "";
            userBox.Text = "";
            passwordBox.Text = "";
            confirmBox.Text = "";
            nameBox.Focus();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
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


                foreach (var row in query)
                {

                    PacientsData.Rows.Add(row.Nume.ToString().Trim(), row.CNP.ToString().Trim(),
                        row.Serie_Buletin.ToString().Trim(), row.Numar_Buletin.ToString().Trim(),
                        row.Data_Nasterii.ToString().Trim());
                }
            }
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from app in context.Appointments
                            where app.ID_Medic.Equals(Abouts.ID) && app.Accepted == 1
                            select app;
                Request_Label.Text = query.Count().ToString().Trim() + " Appointments";
                if (query.Count() != 0)
                {
                    Request_Label.BackColor = Color.Red;
                }
            }

            if (Equals(Abouts.Specializare.ToString().Trim(), "Asistent") == true)
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
            new Appointments_Form(Abouts, Login);
            Close();
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
                using (var context = new Cabinet_MedicalEntities())
                {
                    string cell = PacientsData.SelectedRows[0].Cells[0].Value.ToString();
                    var query2 = (from pat in context.Patients
                                  where pat.Nume.Equals(cell)
                                  select pat).First();



                    if (PacientsData.SelectedRows.Count == 0)
                    {
                        throw new Exception("Selectati un pacient!");
                    }


                    else
                    {
                        this.Hide();

                        View_Form view = new View_Form(query2, this,Abouts);
                        view.Show();
                    }
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

                string name = PacientsData.SelectedCells[0].Value.ToString();

                using (var context = new Cabinet_MedicalEntities())
                {
                    var PacientDel = (from c in context.Patients
                                      where c.Nume.Equals(name)
                                      select c).First();
                    //context.Patients.Remove(PacientDel);
                    //context.SaveChanges();
                    //PacientsData.Rows.Remove(PacientsData.SelectedRows[0]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Form add = new Add_Form(Abouts);
            add.Show();
        }

        private void CSVExport(string filename)
        {
            var csv = new StringBuilder();
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


                foreach (var row in query)
                {
                    var newline = string.Format("{0},{1},{2},{3},{4}", row.Nume.ToString().Trim(),
                        row.CNP.ToString().Trim(), row.Serie_Buletin.ToString().Trim(), row.Numar_Buletin.ToString().Trim(),
                        row.Data_Nasterii.ToString().Trim());
                    csv.AppendLine(newline);
                }
                File.WriteAllText(filename, csv.ToString());
            }

        }

        private void ExcelExport(string filename)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                    throw new Exception("Eroare exportare foaie de calcul!");

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
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

                    int i = 1;
                    foreach (var row in query)
                    {
                        xlWorkSheet.Cells[i, 1] = row.Nume.ToString().Trim();
                        xlWorkSheet.Cells[i, 2] = row.CNP.ToString().Trim();
                        xlWorkSheet.Cells[i, 3] = row.Serie_Buletin.ToString().Trim();
                        xlWorkSheet.Cells[i, 4] = row.Numar_Buletin.ToString().Trim();
                        xlWorkSheet.Cells[i, 5] = row.Data_Nasterii.ToString().Trim();
                        i++;
                    }
                }
                xlWorkBook.SaveAs(filename);
             }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExportType.SelectedItem == null)
                    throw new Exception("Selectati tipul fisierului!");
                string Type = ExportType.SelectedItem.ToString();
               
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Save Report";

                if(Equals(Type,"Excel"))
                {
                    saveFile.Filter = "Excel 2007 |*.xlsx| Excel 2003 |*.xls";
                    saveFile.ShowDialog();
                    
                        if (saveFile.FileName == "")
                        {
                            throw new Exception("Alegeti un nume pentru fisier!");
                        }

                        ExcelExport(saveFile.FileName);
                        return;
                    
                }
                else if(Equals(Type,"CSV"))
                {
                    saveFile.Filter = "CSV |*.csv";
                    saveFile.ShowDialog();
                   
                    if (saveFile.FileName == "")
                    {
                         throw new Exception("Alegeti un nume pentru fisier!");
                    }

                    CSVExport(saveFile.FileName);
                    return;
                }
                else if(Equals(Type,"PDF"))
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

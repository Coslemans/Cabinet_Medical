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
    
    public partial class View_Form : Form
    {
        Patient Pacient;
        public View_Form(Patient P)
        {
            InitializeComponent();
            Pacient = P;
           
        }

        private void labelAdaugare_Click(object sender, EventArgs e)
        {

        }

        private void buttonReteta_Click(object sender, EventArgs e)
        {

        }

        private void View_Form_Load(object sender, EventArgs e)
        {
            labelNume.Text = Pacient.Nume.ToString().Trim();
            ViewData.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNume_Click(object sender, EventArgs e)
        {
          

        }

        private void ViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTipC_SelectedIndexChanged(object sender, EventArgs e)
        {

            ViewData.ClearSelection();
            ViewData.CurrentCell = null;
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            ViewData.Show();
            string tipConsutatie = comboBoxTipC.SelectedItem.ToString();
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from ist in context.History_Patients
                            join d in context.Diseases on ist.ID_Afectiune
                            equals d.ID
                            select new
                            {
                                ist.Data,
                                d.Denumire,
                                ist.ID_Medic,
                                ist.ID
                            };

                if (Equals(tipConsutatie, "Reteta"))
                {
                    ViewData.ClearSelection();
                    ViewData.CurrentCell = null;
                    foreach (var row in query)
                    {
                        Column1.HeaderText = "Numar flacoane";
                        Column2.HeaderText = "Denumire";

                        var query1 = (from n in context.Employees
                                      where n.ID.Equals(row.ID_Medic)
                                      select n).First();


                        var query3 = from r in context.Recipes
                                     where r.ID_Istoric.Equals(row.ID)
                                     select new
                                     {
                                         r.ID_Medicament,
                                         r.Numar_Flacoane
                                     };
                   


                        if (query3.Count() != 0)
                        {
                            
                            foreach (var ret in query3)
                            {
                                var query5 = (from den in context.Drugs
                                              where den.ID.Equals(ret.ID_Medicament)
                                              select den).First();
                                ViewData.Rows.Add(row.Data.ToString().Trim(), query1.Nume.ToString().Trim(), row.Denumire.ToString().Trim(), ret.Numar_Flacoane.ToString().Trim(), query5.Denumire.ToString().Trim());
                            }
                        }

                    }
                  
                }
                else if (Equals(tipConsutatie, "Bilet internare"))
                {

                   
                    ViewData.ClearSelection();
                    ViewData.CurrentCell = null;
                    Column1.HeaderText = "Numar bilet";
                    Column2.HeaderText = "Descriere";
                    foreach (var row in query)
                    {


                        var query1 = (from n in context.Employees
                                      where n.ID.Equals(row.ID_Medic)
                                      select n).First();
                        var query2 = from i in context.Internment_Tickets
                                     where i.ID_Istoric.Equals(row.ID)
                                     select new
                                     {
                                         i.Numar_Bilet,
                                         i.Descriere
                                     };
                      
                        if (query2.Count() != 0)
                        {
                            foreach (var bilet in query2)
                            {
                                ViewData.Rows.Add(row.Data.ToString().Trim(), query1.Nume.ToString().Trim(), row.Denumire.ToString().Trim(), "Bilet internare", bilet.Numar_Bilet.ToString().Trim(), bilet.Descriere.ToString().Trim());
                            }
                        }
                    }
                   
                }
               else if (Equals(tipConsutatie, "Scutire"))
                {
                    ViewData.ClearSelection();
                    ViewData.CurrentCell = null;
                    Column1.HeaderText = "Zile repaus";
                    Column2.HeaderText = "Tip scutire";
                    foreach (var row in query)
                    {
                        var query1 = (from n in context.Employees
                                      where n.ID.Equals(row.ID_Medic)
                                      select n).First();
                        var query4 = from s in context.Exemptions
                                     where s.ID_Istoric.Equals(row.ID)
                                     select new
                                     {
                                         s.Tip,
                                         s.Zile_Repaus
                                     };
                         if (query4.Count() != 0)
                        {
                            foreach (var sc in query4)
                            {
                                ViewData.Rows.Add(row.Data.ToString().Trim(), query1.Nume.ToString().Trim(), row.Denumire.ToString().Trim(), sc.Zile_Repaus.ToString().Trim(), sc.Tip.ToString().Trim());
                            }
                        }
                    }
                   
                }

            }
          

        }

        private void ViewData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

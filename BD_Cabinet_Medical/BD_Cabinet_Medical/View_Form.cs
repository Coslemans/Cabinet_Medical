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
namespace BD_Cabinet_Medical
{
    
    public partial class View_Form : Form
    {
        Patient Pacient;
        Form med;
        Employee Medic;
        public View_Form(Patient P, Form ParentForm,Employee E)
        {
            InitializeComponent();
            Pacient = P;
            med = ParentForm;
            Medic = E;
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
            RetetaData.Hide();
            BiletData.Hide();
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

           
        }
        private void RetetaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Hide();
                string tipConsutatie = comboBoxTipC.SelectedItem.ToString();
                using (var context = new Cabinet_MedicalEntities())
                {
                    RetetaData.Show();
                    ViewData.Hide();
                    BiletData.Hide();
                    var q = from i in context.History_Patients
                            where i.ID_Pacient.Equals(Pacient.ID)
                            select i;


                    if (Equals(tipConsutatie, "Reteta"))
                    {
                        foreach (var reteta in q)
                        {
                            var query = (from r in context.Recipes
                                         where r.ID_Istoric.Equals(reteta.ID)
                                         select new
                                         {
                                             r.ID_Medicament,
                                             r.Numar_Flacoane
                                         }).FirstOrDefault();
                            if (query != null)
                            {

                                var afect = (from a in context.Diseases
                                             where a.ID.Equals(reteta.ID_Afectiune)
                                             select a).FirstOrDefault();
                                var med = (from m in context.Employees
                                           where m.ID.Equals(reteta.ID_Medic)
                                           select m).FirstOrDefault();
                                var medicament = (from d in context.Drugs
                                                  where d.ID.Equals(query.ID_Medicament)
                                                  select d).FirstOrDefault();
                                RetetaData.Rows.Add(reteta.Data.ToString().Trim(), med.Nume.ToString().Trim(), afect.Denumire.ToString().Trim(), query.Numar_Flacoane.ToString().Trim(), medicament.Denumire.ToString().Trim());

                            }

                        }


                    }
                    else if (Equals(tipConsutatie, "Bilet internare"))
                    {
                        RetetaData.Hide();
                        ViewData.Hide();
                        BiletData.Show();
                        foreach (var bilet in q)
                        {
                            var query = (from b in context.Internment_Tickets
                                         where b.ID_Istoric.Equals(bilet.ID)
                                         select new
                                         {
                                             b.Descriere,
                                             b.Numar_Bilet,

                                         }).FirstOrDefault();
                            if (query != null)
                            {

                                var afect = (from af in context.Diseases
                                             where af.ID.Equals(bilet.ID_Afectiune)
                                             select af).FirstOrDefault();
                                var med = (from mm in context.Employees
                                           where mm.ID.Equals(bilet.ID_Medic)
                                           select mm).FirstOrDefault();
                                BiletData.Rows.Add(bilet.Data.ToString().Trim(), med.Nume.ToString().Trim(), afect.Denumire.ToString().Trim(), query.Numar_Bilet.ToString().Trim(), query.Descriere.ToString().Trim());

                            }

                        }
                       

                    }
                    else if (Equals(tipConsutatie, "Scutire"))
                    {
                        ViewData.Show();
                        RetetaData.Hide();
                        BiletData.Hide();
                        foreach (var scutire in q)
                        {
                            var query = (from s in context.Exemptions
                                         where s.ID_Istoric.Equals(scutire.ID)
                                         select new
                                         {
                                             s.Zile_Repaus,
                                             s.Tip
                                             
                                         }).FirstOrDefault();
                            if (query != null)
                            {

                                var afect = (from aa in context.Diseases
                                             where aa.ID.Equals(scutire.ID_Afectiune)
                                             select aa).FirstOrDefault();
                                var med = (from n in context.Employees
                                           where n.ID.Equals(scutire.ID_Medic)
                                           select n).FirstOrDefault();
                             
                                ViewData.Rows.Add(scutire.Data.ToString().Trim(), med.Nume.ToString().Trim(), afect.Denumire.ToString().Trim(), query.Zile_Repaus.ToString().Trim(),query.Tip.ToString().Trim());

                            }

                        }
                      
                    }
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BiletData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonScutire_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScutiriForm sc = new ScutiriForm(Pacient,this);
            sc.Show();
        }

        private void buttonBAck_Click(object sender, EventArgs e)
        {
            med.Show();
            this.Close();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void buttonBilet_Click(object sender, EventArgs e)
        {
            Bilet_internareForm bilet = new Bilet_internareForm(Medic);
            bilet.Show();
        }
    }
    
}

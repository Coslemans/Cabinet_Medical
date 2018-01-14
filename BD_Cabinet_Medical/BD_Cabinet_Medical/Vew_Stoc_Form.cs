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
    public partial class Vew_Stoc_Form : Form
    {
        Form f;
        public Vew_Stoc_Form(Form parentForm)
        {
            InitializeComponent();
            f = parentForm;
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from i in context.Drugs_Diseases
                            join m in context.Diseases on i.ID_Afectiune equals m.ID
                            join p in context.Drugs on i.ID_Medicament equals p.ID
                            select new {
                                m.Denumire,
                                den=p.Denumire,
                                p.Data_Expirarii,
                                p.Stoc
                            };
                foreach(var j in query)
                {
                    if(DateTime.Compare(DateTime.Now,j.Data_Expirarii)<0)
                    {
                        StocView.Rows.Add(j.Denumire.ToString().Trim(), j.den.ToString().Trim(), j.Data_Expirarii.ToString().Trim(), j.Stoc.ToString().Trim());
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }
    }
}

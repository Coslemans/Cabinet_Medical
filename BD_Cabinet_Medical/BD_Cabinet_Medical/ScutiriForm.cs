using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;


namespace BD_Cabinet_Medical
{
    public partial class ScutiriForm : Form
    {
        Patient Pacient;
        Form formParent;
        public ScutiriForm(Patient P, Form formparent)
        {
            InitializeComponent();
            Pacient = P;
            textBoxData.Text = DateTime.Now.ToString();
            formParent = formparent;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Cabinet_MedicalEntities())
                {
                    string medic = textBoxMedic.Text;
                    string afectiune = textBoxAfectiune.Text;
                    int zile = Int32.Parse(textBoxZile.Text);
                    var query = (from m in context.Employees
                                 where m.Nume.Equals(medic)
                                 select m).First();

                    var query2 = (from a in context.Diseases

                                  where a.Denumire.Equals(afectiune)
                                  select a).First();
                    if (query == null)
                        throw new Exception("Numele medicului introdus esti incorect!");
                    else if (query2 == null)
                        throw new Exception("Denumirea afectiunii este incorecta!");
                    else
                    {

                        var addnew = new History_Patients
                        {

                            ID_Medic = query.ID,

                            Data = DateTime.Now,
                            ID_Pacient = Pacient.ID,
                            ID_Afectiune = query2.ID

                        };
                        context.History_Patients.Add(addnew);
                        context.SaveChanges();

                        var addsc = new Exemption
                        {
                            ID_Istoric = addnew.ID,
                            Zile_Repaus = zile,
                            Tip = textBoxTipScutire.Text

                        };
                        if (textBoxMedic.Text.Length == 0)
                        {
                            throw new Exception("Nu ati introdus numele medicului/asistentului!");

                        }

                        else if (textBoxAfectiune.Text.Length == 0)
                            throw new Exception("Nu ati introdus denumirea afectiunii!");
                        else if (textBoxZile.Text.Length == 0)
                            throw new Exception("Nu ati introdus numarul de zile!");
                        else if (textBoxTipScutire.Text.Length == 0)
                            throw new Exception("Nu ati introdus tipul scutirii!");
                        else
                        {

                            context.Exemptions.Add(addsc);
                            context.SaveChanges();

                            MessageBox.Show("Scutirea a fost inregistrata cu succes!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            textBoxAfectiune.Text = "";
                            textBoxMedic.Text = "";
                            textBoxTipScutire.Text = "";

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            formParent.Show();
            this.Close();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}

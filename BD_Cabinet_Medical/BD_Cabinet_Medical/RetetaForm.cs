﻿using System;
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
    public partial class RetetaForm : Form
    {
        Patient Pacient;
        Form formParent;
        Employee m;

        public RetetaForm(Patient P, Form formparent,Employee nMed)
        {
            InitializeComponent();
            Pacient = P;
            formParent = formparent;
            m = nMed;
            labelData.Text = labelData.Text + ": " + DateTime.Now.ToString();
            labelNume.Text = labelNume.Text + ": " + Pacient.Nume.ToString();
            labelCNP.Text = labelCNP.Text + ": " + Pacient.CNP.ToString();
            labelMedic.Text = labelMedic.Text + ": " + m.Nume.ToString();
            button1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMedic_Click(object sender, EventArgs e)
        {

        }

        private void labelMed_Click(object sender, EventArgs e)
        {

        }

        private void RetetaForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAf_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formParent.Show();
            this.Close();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            using (var context = new Cabinet_MedicalEntities())
            {
                try
                {


                    if (textBoxAf.Text.Length == 0)
                        throw new Exception("Nu ati introdus denumirea afectiunii!");
                    else if (textBoxMed.Text.Length == 0)
                        throw new Exception("Nu ati introdus denumirea medicamentului!");
                    else if (textBoxNrF.Text.Length == 0)
                        throw new Exception("Nu ati introdus numarul de flacoane!");

                    else
                    {
                        var res = (from p in context.Drugs
                                   where p.Denumire.Equals(textBoxMed.Text)
                                   select p).FirstOrDefault();
                        int numar = Int32.Parse(textBoxNrF.Text);




                        var query2 = (from a in context.Diseases

                                      where a.Denumire.Equals(textBoxAf.Text)
                                      select a).FirstOrDefault();



                        if (query2==null)
                        {
                            throw new Exception("Denumirea afectiunii este incorecta!");
                        }
                        string den = res.Denumire;

                        if (res.Stoc > numar)
                        {
                            var addnew = new History_Patients
                            {

                                ID_Medic = m.ID,

                                Data = DateTime.Now,
                                ID_Pacient = Pacient.ID,
                                ID_Afectiune = query2.ID

                            };
                            context.History_Patients.Add(addnew);
                            context.SaveChanges();

                            var addret = new Recipe
                            {
                                ID_Istoric = addnew.ID,
                                ID_Medicament = res.ID,
                                Numar_Flacoane = numar

                            };


                            context.Recipes.Add(addret);
                            context.SaveChanges();

                            using (var dbContextTransaction = context.Database.BeginTransaction())
                            {
                                try
                                {


                                    var pp = from dr in context.Drugs
                                             where dr.Denumire.Equals(den)
                                             select dr;
                                    foreach (var pastile in pp)
                                    {
                                        pastile.Stoc = pastile.Stoc - numar;
                                    }
                                    context.SaveChanges();
                                    dbContextTransaction.Commit();

                                }
                                catch (Exception)
                                {
                                    dbContextTransaction.Rollback();
                                }
                            }
                            MessageBox.Show("Reteta a fost inregistrata cu succes!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxAf.Text = "";
                            textBoxMed.Text = "";
                            textBoxNrF.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Stoc insuficient!");
                        }

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vew_Stoc_Form stoc = new Vew_Stoc_Form(this);
            this.Hide();
            stoc.Show();
        }
    }
        
}

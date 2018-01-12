﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace BD_Cabinet_Medical
{
    public partial class Patient_Form : Form
    {
        private Patient Abouts;
        Form Login;
        public Patient_Form(Patient P, Form f)
        {
            InitializeComponent();
            Abouts = P;
            Show();
            Login = f;
        }
        void FillCombo()
        {
            using (var context = new Cabinet_MedicalEntities())
            {
                var query = from emp in context.Employees
                            where emp.Specializare != "Asistent"
                            select
                                emp.Nume;
                if (query.Count() != 0)
                {
                    foreach (var doc in query)
                    {
                        Doctors.Items.Add(doc.ToString());
                    }
                }

            }
        }

        bool checkAppointment(int medic, int pacient, DateTime date)
        {
            var context = new Cabinet_MedicalEntities();
            var app = from cab in context.Appointments
                      where cab.ID_Pacient.Equals(pacient) && cab.ID_Medic.Equals(medic) && cab.Date.Equals(date)
                      select new
                      {
                          cab.ID_Medic,
                          cab.ID_Pacient,
                          cab.Date
                      };
            if (app.Count() != 0)
                return true;
            else
                return false;
        }

        private void Patient_Form_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'cabinet_MedicalDataSet.Appointments' table. You can move, or remove it, as needed.
               // appointmentsTableAdapter.Fill(this.cabinet_MedicalDataSet.Appointments);
                this.Text = Abouts.Nume.ToString().Trim() + " Window";
                nameLabel.Text = Abouts.Nume.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Doresti sa te deloghezi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Login.Show();
            }
            else if (res == DialogResult.No)
                return;
        }

        private void newAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                Doctors.Enabled = true;
                dateTime.Enabled = true;
                saveAppointment.Enabled = true;
                FillCombo();
                History.Enabled = false;
                hView.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAppointment_Click(object sender, EventArgs e)
        {

            try
            {


                if (Doctors.SelectedItem == null)
                {
                    throw new Exception("Selectati un medic!");

                }
                else if (dateTime.Checked == false)
                {
                    throw new Exception("Selectati o data!");
                }
                else
                {
                    

                    using (var context = new Cabinet_MedicalEntities())
                    {
                        var medic = (from med in context.Employees
                                     where med.Nume.Equals(Doctors.SelectedItem.ToString())
                                     select med).First();

                        var newapp = new Appointment()
                        {
                            ID_Medic = medic.ID,
                            ID_Pacient = Abouts.ID,
                            Date = dateTime.Value, Accepted = 1
                            
                        };
                        if (checkAppointment(newapp.ID_Medic, newapp.ID_Pacient, newapp.Date) == true)
                            throw new Exception("Ati mai facut o programare identica!\n");
                        else
                        {
                            context.Appointments.Add(newapp);
                            context.SaveChanges();
                        }
                    }
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Doctors.Text = "";
            Doctors.Enabled = false;
            dateTime.Enabled = false;
            saveAppointment.Enabled = false;
            Doctors.Items.Clear();

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            try
            {
                hView.Enabled = true;
                History.Enabled = true;
                Doctors.Enabled = false;
                saveAppointment.Enabled = false;
                dateTime.Enabled = false;
                using (var cont = new Cabinet_MedicalEntities())
                {
                    var quer = from hist in cont.historyViews
                               where hist.ID.Equals(Abouts.ID)
                               select new
                               {
                                   hist.Denumire,
                                   hist.Nume,
                                   hist.Specializare,
                                   hist.Data
                               };
                    DataTable tabel = new DataTable();
                    tabel.Columns.Add("Afectiune", typeof(string));
                    tabel.Columns.Add("Medic",typeof(string));
                    tabel.Columns.Add("Specializare", typeof(string));
                    tabel.Columns.Add("Data examinare", typeof(DateTime));
                    foreach(var item in quer)
                    {
                        DataRow Row = null;
                        Row = tabel.NewRow();
                        Row["Afectiune"] = item.Denumire.ToString().Trim();
                        Row["Medic"] = item.Nume.ToString().Trim();
                        Row["Specializare"] = item.Specializare.ToString().Trim();
                        Row["Data examinare"] = item.Data;
                        tabel.Rows.Add(Row);
                    }
                    hView.DataSource = tabel;

                }
                //DataTable data = new DataTable();
                //data.Columns.Add("Afectiune", typeof(string));
                //data.Columns.Add("Medic", typeof(string));
                //data.Columns.Add("Specializare", typeof(string));
                //data.Columns.Add("Data_examinare", typeof(DateTime));
                //var context = new Cabinet_MedicalEntities();
                //var query = from hist in context.History_Patients
                //            where hist.ID_Pacient.Equals(Abouts.ID)
                //            select new
                //            {
                //                hist.ID,
                //                hist.ID_Afectiune,
                //                hist.ID_Medic,
                //                hist.Data
                //            };
                //foreach (var ist in query)
                //{
                //    DataRow row = null;
                //    row = data.NewRow();
                //    var disease = from dis in context.Diseases
                //                  where dis.ID == ist.ID_Afectiune
                //                  select new
                //                  {
                //                      dis.Denumire,
                //                      dis.ID
                //                  };

                //    var medic = from doc in context.Employees
                //                where doc.ID.Equals(ist.ID_Medic)
                //                select new
                //                {
                //                    doc.Nume,
                //                    doc.Specializare,
                //                    doc.ID
                //                };
                //    var dat = from da in context.History_Patients
                //              where da.ID.Equals(ist.ID)
                //              select new
                //              {
                //                  da.Data,
                //                  da.ID
                //              };
                //    foreach (var nou in dat)
                //    {
                //        if (nou.ID == ist.ID)
                //            row["Data_examinare"] = nou.Data.ToString().Trim();
                //    }
                //    foreach (var doc in medic)
                //    {
                //        if (doc.ID == ist.ID_Medic)
                //        {
                //            row["Medic"] = doc.Nume.ToString().Trim();
                //            row["Specializare"] = doc.Specializare.ToString().Trim();
                //        }
                //    }
                //    foreach (var dis in disease)
                //    {
                //        if (dis.ID == ist.ID_Afectiune)
                //            row["Afectiune"] = dis.Denumire.ToString().Trim();

                //    }
                //    data.Rows.Add(row);


                //}


                //History.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void historyGroup_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

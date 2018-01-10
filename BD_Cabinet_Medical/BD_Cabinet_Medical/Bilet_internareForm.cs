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
    public partial class Bilet_internareForm : Form
    {
        Employee medic;
        public Bilet_internareForm(Employee E)
        {
            InitializeComponent();
            medic = E;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void Bilet_internareForm_Load(object sender, EventArgs e)
        {
            this.Text = "Bilet internare";
            regLabel.Text= "Registered as " + medic.Nume.ToString().Trim();
            //
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void regLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

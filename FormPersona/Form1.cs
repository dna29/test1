using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCity_Click(object sender, EventArgs e)
        {

        }

        private void rbMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
            this.Controls.OfType<GroupBox>().ToList()[0].Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Checked = false);


            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string apellidos = txtSurname.Text;
            string sexo = (string)this.gbSex.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text;
            string ciudad = cbCity.SelectedText;

            Persona person = new Persona(nombre, apellidos, sexo, ciudad);
            Console.WriteLine(comprobar(person));
            
        }

        public Boolean comprobar(Persona person)
        {
            if (person!=null)
            {
                return true;
            }
            return false;
        }
    }
}

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
/// <summary>
/// 
/// </summary>
namespace FormPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtName.Focus();
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Text = "");
            this.Controls.OfType<GroupBox>().ToList()[0].Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Checked = false);   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string sex = (string)this.gbSex.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text;
            string city = cbCity.Text;

            Persona person = new Persona(name, surname, sex, city);
            Console.WriteLine(writeIn(person));
            
        }
        /// <summary>
        /// Writes an object in a txt file
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Boolean writeIn(Persona person)
        {
            try
            {
                if (System.IO.File.Exists(@"C:\Users\DTUser\Documents\Prueba\txtPrueba.txt"))
                {
                    using (StreamWriter objectWriter = new StreamWriter(@"C:\Users\DTUser\Documents\Prueba\txtPrueba.txt", true))
                    {
                        objectWriter.WriteLine(person.ToString());
                        return true;
                    }
                    return false;
                }
                else
                {
                    using (StreamWriter w = File.CreateText(@"C:\Users\DTUser\Documents\Prueba\txtPrueba.txt"))
                    {
                        w.WriteLine(person.ToString());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

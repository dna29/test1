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
            string city = cbCity.SelectedText;

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

            if (System.IO.File.Exists("C:/Users/dnieto/Documents/TXT_Prueba.txt"))
            {
                using (StreamWriter objectWriter = new StreamWriter("C:/Users/dnieto/Documents/TXT_Prueba.txt", true))
                {
                    objectWriter.WriteLine(person.ToString());
                    return true;
                }
                return false;
            }else
            {
                string file_name = @"C:\\Users\\dnieto\\Documents\\TXT_Prueba.txt";
                using (StreamWriter generate = File.AppendText(file_name))
                {
                    generate.WriteLine(person.ToString());
                    generate.Close();
                    return true;

                }
                    
                
               
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

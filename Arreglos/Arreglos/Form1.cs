using System;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

            try
            {
                string cadena = "";

                string[] materias = new string[5];
                materias[0] = txtMatematicas.Text;
                materias[1] = txtEspañol.Text;
                materias[2] = txtCalculo.Text;
                materias[3] = txtHistoria.Text;
                materias[4] = txtProgramacion.Text;
                


                for (int i = 0; i < 5; i++)
                {
                    cadena = materias[i];

                    for (int j = 0; j < cadena.Length; j++)
                    {
                        if ((int)cadena[j] < 48 || (int)cadena[j] > 58)
                        {
                            throw new FormatException("Ingrese porfavor solo numeros enteros");

                        }
                    }
                    if (int.Parse(cadena) > 10)
                    {
                        throw new ApplicationException();
                    }
                    else if (cadena == ""||txtNombre.Text=="")
                    {
                        throw new NullReferenceException();
                    }



                }
                Promedio alumno = new Promedio(int.Parse(txtMatematicas.Text), int.Parse(txtEspañol.Text), int.Parse(txtCalculo.Text), int.Parse(txtHistoria.Text), int.Parse(txtProgramacion.Text));
                txtPromedio.Text = alumno.prom.ToString();
                alumno.Varianza(materias ,alumno.prom);
                txtVarianza.Text = alumno.resultado.ToString();


            }
            catch (FormatException error)
            {
                MessageBox.Show("Fomato no valido");

            }
            catch (ApplicationException error)
            {
                MessageBox.Show("Te sales del rango");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No puedes dejar casillas en blanco");
            }

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVarianza_Click(object sender, EventArgs e)
        {

        }
    }
}

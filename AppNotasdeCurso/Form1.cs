using AppNotasdeCurso.Clases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotasdeCurso
{
    public partial class Form1 : Form
    {
        private Curso curso;
        public Form1()
        {
            InitializeComponent();
            curso = new Curso();
        }

        void imprimirNotas()
        {
            lblNotaEst1.Text = curso.obtenerNota(0).ToString("N2");
            lblNotaEst2.Text = curso.obtenerNota(1).ToString("N2");
            lblNotaEst3.Text = curso.obtenerNota(2).ToString("N2");
            lblNotaEst4.Text = curso.obtenerNota(3).ToString("N2");
            lblNotaEst5.Text = curso.obtenerNota(4).ToString("N2");
            lblNotaEst6.Text = curso.obtenerNota(5).ToString("N2");
            lblNotaEst7.Text = curso.obtenerNota(6).ToString("N2");
            lblNotaEst8.Text = curso.obtenerNota(7).ToString("N2");
            lblNotaEst9.Text = curso.obtenerNota(8).ToString("N2");
            lblNotaEst10.Text = curso.obtenerNota(9).ToString("N2");
            lblNotaEst11.Text = curso.obtenerNota(10).ToString("N2");
            lblNotaEst12.Text = curso.obtenerNota(11).ToString("N2");
        }

        void realizarCambiodeNota(Curso curso, int index)
        {
            try
            {
                float nota = float.Parse(Interaction.InputBox("Digite la nueva nota: ", "Cambio de Nota", "5.00"));
                if (nota >= 0 && nota <= 5)
                {
                    curso.cambiarNota(index, nota);
                    imprimirNotas();
                }
                else
                {
                    MessageBox.Show("La nota registra debe estar dentro del rango 0 - 5");
                }
            }
            catch(Exception e) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imprimirNotas();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio del curso es: " + curso.promedio().ToString("N2"));
        }

        private void btnDestacados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de estudiantes que superan el promedio del curso es: " + curso.cantidadAlumnosSobrePromedio());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCambiarNotaEst1_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 0);
        }

        private void btnCambiarNotaEst2_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 1);
        }

        private void btnCambiarNotaEst3_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 2);
        }

        private void btnCambiarNotaEst4_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 3);
        }

        private void btnCambiarNotaEst5_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 4);
        }

        private void btnCambiarNotaEst6_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 5);
        }

        private void btnCambiarNotaEst7_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 6);
        }

        private void btnCambiarNotaEst8_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 7);
        }

        private void btnCambiarNotaEst9_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 8);
        }

        private void btnCambiarNotaEst10_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 9);
        }

        private void btnCambiarNotaEst11_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 10);
        }

        private void btnCambiarNotaEst12_Click(object sender, EventArgs e)
        {
            realizarCambiodeNota(curso, 11);
        }
    }
}

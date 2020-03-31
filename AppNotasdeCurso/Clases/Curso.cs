using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasdeCurso.Clases
{
    class Curso
    {
        const int TOTAL_EST = 12;
        private double[] notas;

        public Curso()
        {
            this.notas = new double[TOTAL_EST];
            for(int i = 0; i < this.notas.Length; i++)
            {
                this.notas[i] = 0.00;
            }
        }

        public double promedio()
        {
            double suma = 0;
            foreach(double nota in this.notas)
            {
                suma += nota;
            }
            return (suma / this.notas.Length);
        }

        public int cantidadAlumnosSobrePromedio()
        {
            int cantidad = 0;
            foreach(double nota in this.notas)
            {
                if(nota > promedio())
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        public double obtenerNota(int index)
        {
            return this.notas[index];
        }

        public void cambiarNota(int index, double nuevaNota)
        {
            this.notas[index] = nuevaNota;
        }
    }
}

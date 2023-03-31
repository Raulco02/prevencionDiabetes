using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevencionDiabetes.Dominio
{
    internal class CalculoFindrisk
    {
        Paciente paciente;

        public CalculoFindrisk(Paciente paciente) {
            this.paciente = paciente;
        }
        
        public int calcularPuntos()
        {
            int puntos = 0;
            double IMC = calcularIMC();
            if (paciente.Edad > 45 && paciente.Edad < 54)
                puntos += 2;
            else if (paciente.Edad > 55 && paciente.Edad < 64)
                puntos += 3;
            else if (paciente.Edad > 64)
                puntos += 4;
            if (IMC > 25 && IMC < 30)
                puntos++;
            else if (IMC > 30)
                puntos += 2;
            if ((paciente.Sexo && paciente.Cintura > 94 && paciente.Cintura < 102) || (paciente.Sexo && paciente.Cintura > 80 && paciente.Cintura < 88))
                puntos++;
            if ((paciente.Sexo && paciente.Cintura > 102) || (paciente.Sexo && paciente.Cintura > 88))
                puntos += 2;
            if (paciente.MedicacionPA)
                puntos += 2;
            if (paciente.ActHipoglucemia)
                puntos += 5;
            if (paciente.ActFisica)
                puntos += 2;
            if (!paciente.ConsumoFYV)
                puntos ++;
            if (paciente.AntFamiliares == 1)
                puntos += 3;
            if (paciente.AntFamiliares == 2)
                puntos += 5;

            return puntos;
        }
        public double calcularIMC()
        {
            return paciente.Peso / Math.Pow(paciente.Altura, 2);
        }
        public void obtenerRecomendaciones()
        {
            //TO DO
        }
    }
}

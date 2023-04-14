using Accord.IO;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Models.Regression;
using Accord.Math;
using System.Data;

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
            if (paciente.Edad >= 45 && paciente.Edad < 54)
                puntos += 2;
            else if (paciente.Edad >= 55 && paciente.Edad < 64)
                puntos += 3;
            else if (paciente.Edad >= 64)
                puntos += 4;
            if (IMC >= 25 && IMC < 30)
                puntos++;
            else if (IMC >= 30)
                puntos += 3;
            if ((!paciente.Sexo && paciente.Cintura >= 94 && paciente.Cintura < 102) || (paciente.Sexo && paciente.Cintura >= 80 && paciente.Cintura < 88))
                puntos += 3;
            if ((!paciente.Sexo && paciente.Cintura >= 102) || (paciente.Sexo && paciente.Cintura >= 88))
                puntos += 4;
            if (paciente.MedicacionPA)
                puntos += 2;
            if (paciente.ActHipoglucemia)
                puntos += 2;
            if (!paciente.ActFisica)
                puntos += 2;
            if (!paciente.ConsumoFYV)
                puntos += 2;
            if (paciente.AntFamiliares == 1)
                puntos += 3;
            if (paciente.AntFamiliares == 2)
                puntos += 5;

            return puntos;
        }
        public double calcularIMC()
        {
            return paciente.Peso / Math.Pow(paciente.Altura/100, 2);
        }
        public void obtenerRecomendaciones()
        {
            // Crear un objeto CsvReader
            var csv = new CsvReader(new StreamReader("datos.csv"), hasHeaders: true, delimiter: ';');
            var csvContent = csv.ReadToEnd();
            var data = new DataTable();
            var columnas = new[] { "edad", "sexo", "IMC", "cintura", "medicacionPA", "actHipoglucemia", "actFisica", "consumoFrutasVerduras", "antFamiliares", "puntosFindrisk", "resultado" };//riesgoDiabetes no sé si debería estar

            foreach (var header in columnas)
            {
                data.Columns.Add(header, typeof(Double));
            }
            foreach (var matriz in csvContent)
            {
                var row = data.NewRow(); // Crear una nueva fila con la estructura de la tabla
                for (int i = 0; i < matriz.Length; i++)
                {
                    if (Double.TryParse(matriz[i], out double doubleValue))
                        row[i] = doubleValue; // Asignar el valor a la columna correspondiente en la fila
                    else
                    {
                        Double valorBool = matriz[i].ToLower() == "true" ? 1.0 : 0.0;
                        row[i] = valorBool; // Asignar el valor a la columna correspondiente en la fila
                    }
                }
                data.Rows.Add(row); // Agregar la fila a la tabla
            }
                            
            //var data = csvContent.ToTable();

            // Definir los nombres de las columnas de entrada y salida
            var inputs = new[] { "edad", "sexo", "IMC", "cintura", "medicacionPA", "actHipoglucemia", "actFisica", "consumoFrutasVerduras", "antFamiliares", "puntosFindrisk" };//riesgoDiabetes no sé si debería estar
            var outputIndex = inputs.Length;
            var variables = inputs.Select(v => new DecisionVariable(v, DecisionVariableKind.Continuous)).ToList();

            // Crear el modelo de árbol de decisión
            var tree = new DecisionTree(variables, outputIndex);

            // Entrenar el modelo
            var learner = new C45Learning(tree);
            var inputsData = data.ToJagged(inputs);
            var outputData = data.ToArray<int>(columnas[outputIndex]);//CUIDADO SI RESULTADO TIENE QUE ESTAR EN INPUTS O NO
            //var weights = null; // Puedes usar pesos si tienes un conjunto de datos desbalanceado
            learner.Learn(inputsData, outputData);//, weights);

            // Utilizar el modelo para hacer recomendaciones personalizadas
            double edad = paciente.Edad;//45;
            bool sexo = paciente.Sexo;//true;
            double IMC = calcularIMC();//30;
            double cintura = paciente.Cintura;//95;
            bool medicacionPA = paciente.MedicacionPA;//false;
            bool actHipoglucemia = paciente.ActHipoglucemia;//false;
            bool actFisica = paciente.ActFisica;//false;
            bool consumoFrutasVerduras = paciente.ConsumoFYV;//true;
            double antFamiliares = paciente.AntFamiliares;//2;
            double puntosFindrisk = calcularPuntos();//15;

            var prediction = tree.Decide(new double[] { edad, sexo ? 1 : 0, IMC, cintura, medicacionPA ? 1 : 0, actHipoglucemia ? 1 : 0, actFisica ? 1 : 0, consumoFrutasVerduras ? 1 : 0, antFamiliares, puntosFindrisk });
            switch (prediction)
            {
                case 0:
                    Console.WriteLine("Bajo riesgo de diabetes. Sigue manteniendo hábitos saludables.");
                    break;
                case 1:
                    Console.WriteLine("Ligeramente elevado riesgo de diabetes. Se recomienda hacer cambios en el estilo de vida y visitar al médico.");
                    break;
                case 2:
                    Console.WriteLine("Moderado riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida y visitar al médico.");
                    break;
                case 3:
                    Console.WriteLine("Alto riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida y visitar al médico.");
                    break;
                case 4:
                    Console.WriteLine("Muy alto riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida y visitar al médico.");
                    break;
                default:
                    Console.WriteLine("Error al hacer la predicción.");
                    break;
            }
        }
    }
}

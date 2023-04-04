using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;
using Accord.Statistics.Models.Regression;
using System.IO;
using System.Data;
using Accord.Math;

namespace prevencionDiabetes.Dominio
{
    public class Recomendaciones
    {
        public Recomendaciones()
        {
            // Crear un objeto CsvReader
            var csv = new CsvReader(new StreamReader("datos.csv"), hasHeaders: true, delimiter: ';');

            var data = csv.ToTable();

            // Definir los nombres de las columnas de entrada y salida
            var inputs = new[] { "edad", "sexo", "IMC", "cintura", "medicacionPA" , "actHipoglucemia", "actFisica", "consumoFrutasVerduras", "antFamiliares" };//riesgoDiabetes no sé si debería estar
            var outputIndex = inputs.Length;
            var variables = inputs.Select(v => new DecisionVariable(v, DecisionVariableKind.Continuous)).ToList();

            // Crear el modelo de árbol de decisión
            var tree = new DecisionTree(variables, outputIndex);

            // Entrenar el modelo
            var learner = new C45Learning(tree);
            var inputsData = data.ToJagged(inputs);
            var outputData = data.ToArray<int>(inputs[outputIndex]);
            //var weights = null; // Puedes usar pesos si tienes un conjunto de datos desbalanceado
            learner.Learn(inputsData, outputData);//, weights);

            // Utilizar el modelo para hacer recomendaciones personalizadas
            double edad = 45;
            bool sexo = true;
            double IMC = 30;
            double cintura = 95;
            bool medicacionPA = false;
            bool actHipoglucemia = false;
            bool actFisica = false;
            bool consumoFrutasVerduras = true;
            double antFamiliares = 2;

            var prediction = tree.Decide(new double[] { edad, sexo ? 1 : 0, IMC, cintura, medicacionPA ? 1 : 0, actHipoglucemia ? 1 : 0, actFisica ? 1 : 0, consumoFrutasVerduras ? 1 : 0, antFamiliares });
            switch (prediction)
            {
                case 0:
                    Console.WriteLine("Bajo riesgo de diabetes. Sigue manteniendo hábitos saludables.");
                    break;
                case 1:
                    Console.WriteLine("Moderado riesgo de diabetes. Se recomienda hacer cambios en el estilo de vida y visitar al médico.");
                    break;
                case 2:
                    Console.WriteLine("Alto riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida y visitar al médico.");
                    break;
                default:
                    Console.WriteLine("Error al hacer la predicción.");
                    break;
            }
            /*
            // Cargar datos de entrenamiento
            var reader = new CsvReader("trainingData.csv", hasHeaders: true, delimiter: ',');
            var trainingData = reader.ReadAll();

            // Dividir los datos en entrenamiento y prueba
            var split = new Accord.MachineLearning.CrossValidation.TrainTestSplit(0.8);
            var (trainData, testData) = split.SplitSet(trainingData);

            // Definir el modelo de regresión logística
            var model = new LogisticRegression(inputs: 10, outputs: 2);

            // Entrenar el modelo
            var teacher = new Accord.Statistics.Models.Regression.LogisticRegressionAnalysis(model);
            teacher.Learn(trainData.GetInputs(), trainData.GetOutputs());

            // Evaluar la precisión del modelo
            var predictions = model.Decide(testData.GetInputs());
            var accuracy = new Accord.Statistics.Analysis.MulticlassConfusionMatrix(testData.GetOutputs(), predictions).Accuracy;

            // Utilizar las predicciones para hacer recomendaciones personalizadas
            // (Ejemplo: si el modelo predice un alto riesgo de diabetes, proporcionar recomendaciones específicas para reducir el riesgo)
            // Obtener el nivel de riesgo predicho por el modelo
            int nivelRiesgo = model.Prediccion(paciente);

            // Verificar el nivel de riesgo y proporcionar las recomendaciones correspondientes
            if (nivelRiesgo >= 8)
            {
                Console.WriteLine("Tiene un alto riesgo de diabetes. Se recomienda seguir las siguientes medidas para reducir el riesgo:");
                Console.WriteLine("- Mantener un peso saludable");
                Console.WriteLine("- Realizar actividad física regularmente");
                Console.WriteLine("- Controlar la presión arterial y el colesterol");
                Console.WriteLine("- Reducir el consumo de alimentos y bebidas azucarados");
                Console.WriteLine("- Realizar revisiones médicas regulares");
            }
            else if (nivelRiesgo >= 4 && nivelRiesgo < 8)
            {
                Console.WriteLine("Tiene un riesgo moderado de diabetes. Se recomienda seguir las siguientes medidas para reducir el riesgo:");
                Console.WriteLine("- Mantener un peso saludable");
                Console.WriteLine("- Realizar actividad física regularmente");
                Console.WriteLine("- Controlar la presión arterial y el colesterol");
                Console.WriteLine("- Reducir el consumo de alimentos y bebidas azucarados");
                Console.WriteLine("- Realizar revisiones médicas regulares");
            }
            else
            {
                Console.WriteLine("Tiene un bajo riesgo de diabetes. Se recomienda seguir las siguientes medidas para mantener un estilo de vida saludable:");
                Console.WriteLine("- Mantener un peso saludable");
                Console.WriteLine("- Realizar actividad física regularmente");
                Console.WriteLine("- Consumir una dieta saludable y equilibrada");
                Console.WriteLine("- Realizar revisiones médicas regulares");
            }*/
        }
        

    }
}

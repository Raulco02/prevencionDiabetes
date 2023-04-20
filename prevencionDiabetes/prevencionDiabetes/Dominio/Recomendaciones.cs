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
using System.Security.Cryptography.X509Certificates;

namespace prevencionDiabetes.Dominio
{
    public class Recomendaciones
    {
        public Recomendaciones()
        {   
        }
        
        public string obtener_recomendacion(int recomendacion)
        {
            switch (recomendacion)
            {
                case 0:
                    return "Bajo riesgo de diabetes. Sigue manteniendo hábitos saludables.";
                case 1:
                    return "Ligeramente elevado riesgo de diabetes. Se recomienda hacer cambios en el estilo de vida.";
                case 2:
                    return "Moderado riesgo de diabetes. Es importante hacer cambios inmediatos en el estilo de vida, realiza ejercicio físico, mantén una dieta equilibrada y evita el consumo de alcohol y tabaco.";
                case 3:
                    return "Alto riesgo de diabetes. Realiza ejercicio físico, mantén una dieta equilibrada, evita el consumo de alcohol y tabaco, visita al médico y realiza controles periódicos de glucemia.";
                case 4:
                    return "Muy alto riesgo de diabetes. Es muy importante que visites al médico, mantengas una dieta equilibrada, realices actividad física, evites alcohol y tabaco y que realices controles de glucemia frecuentes.";
                default:
                    return "Error al hacer la predicción.";
            }
        }

    }
}

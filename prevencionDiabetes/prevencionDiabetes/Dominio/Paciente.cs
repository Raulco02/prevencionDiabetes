using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevencionDiabetes.Dominio
{
    public class Paciente : Usuario
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public bool Sexo { get; set; } //True=Mujer, False=Hombre
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Cintura { get; set; }
        public bool MedicacionPA { get; set; }
        public bool ActHipoglucemia { get; set; }
        public bool ActFisica { get; set; }
        public bool ConsumoFYV { get; set; }
        public int AntFamiliares { get; set; }
        public int PuntosFindrisk { get; set; }
        public int Resultado { get; set; }

        // En la base de datos los booleanos hay que guardarlos como INTEGER (0=false, 1=true)
        public Paciente() { }
        public Paciente(string correo, string nombreUsuario, string contrasena, int usuario_id,
                        bool sexo, int edad, double peso, double altura, int cintura, bool medicacionPa,
                        bool actHipoglucemia, bool actFisica, bool consumoFyv, int antFamiliares, int puntosFindrisk,
                        int resultado)
                        : base(correo, nombreUsuario, contrasena)
        {
            Sexo = sexo;
            Edad = edad;
            Peso = peso;
            Altura = altura;
            Cintura = cintura;
            MedicacionPA = medicacionPa;
            ActHipoglucemia = actHipoglucemia;
            ActFisica = actFisica;
            ConsumoFYV = consumoFyv;
            AntFamiliares = antFamiliares;
            Resultado = resultado;
            PuntosFindrisk = puntosFindrisk;
        }
    }
}

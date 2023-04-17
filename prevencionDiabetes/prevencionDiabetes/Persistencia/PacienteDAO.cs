using prevencionDiabetes.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace prevencionDiabetes.Persistencia
{
    public class PacienteDAO
    {
        public Agente agente;

        public PacienteDAO()
        {
            agente = Agente.ObtenerAgente();
        }

        public Paciente Leer(string correo_usuario)
        {
            Paciente paciente = null;
            DataTable pacienteSet = agente.Leer("SELECT * FROM pacientes INNER JOIN usuarios ON usuarios.id = pacientes.usuario_id WHERE usuarios.correo = '" + correo_usuario + "';");
            if (pacienteSet.Rows.Count > 0)
            {
                DataRow fila = pacienteSet.Rows[0];
                paciente = new Paciente()
                {
                    usuario_id = Convert.ToInt32(fila["usuario_id"]),
                    Sexo = Convert.ToBoolean(fila["sexo"]),
                    Edad = Convert.ToInt32(fila["edad"]),
                    Peso = Convert.ToDouble(fila["peso"]),
                    Altura = Convert.ToDouble(fila["altura"]),
                    Cintura = Convert.ToInt32(fila["cintura"]),
                    MedicacionPA = Convert.ToBoolean(fila["medicacionPa"]),
                    ActHipoglucemia = Convert.ToBoolean(fila["actHipoglucemia"]),
                    ActFisica = Convert.ToBoolean(fila["actFisica"]),
                    ConsumoFYV = Convert.ToBoolean(fila["consumoFyv"]),
                    AntFamiliares = Convert.ToInt32(fila["antFamiliares"]),
                    PuntosFindrisk= Convert.ToInt32(fila["puntosFindRisk"]),
                    Resultado = Convert.ToInt32(fila["resultado"])
                };
            }
            return paciente;
        }

        public List<Paciente> LeerTodos()
        {
            List<Paciente> pacientes = new List<Paciente>();
            DataTable pacienteSet = agente.Leer("SELECT * FROM pacientes");
            foreach (DataRow fila in pacienteSet.Rows)
            {
                Paciente paciente = new Paciente();
                paciente.usuario_id = Convert.ToInt32(fila["usuario_id"]);
                paciente.Sexo = Convert.ToBoolean(fila["sexo"]);
                paciente.Edad = Convert.ToInt32(fila["edad"]);
                paciente.Peso = Convert.ToDouble(fila["peso"]);
                paciente.Altura = Convert.ToDouble(fila["altura"]);
                paciente.Cintura = Convert.ToInt32(fila["cintura"]);
                paciente.MedicacionPA = Convert.ToBoolean(fila["medicacionPa"]);
                paciente.ActHipoglucemia = Convert.ToBoolean(fila["actHipoglucemia"]);
                paciente.ActFisica = Convert.ToBoolean(fila["actFisica"]);
                paciente.ConsumoFYV = Convert.ToBoolean(fila["consumoFyv"]);
                paciente.AntFamiliares = Convert.ToInt32(fila["antFamiliares"]);
                paciente.PuntosFindrisk = Convert.ToInt32(fila["puntosFindRisk"]);
                paciente.Resultado = Convert.ToInt32(fila["resultado"]);
                pacientes.Add(paciente);
            }
            return pacientes;
        }

        public bool Insertar(Paciente paciente)
        {
            string consulta = "INSERT INTO pacientes (usuario_id, sexo, edad, peso, altura, cintura, medicacionPa, actHipoglucemia, actFisica, consumoFyv, antFamiliares, puntosFindRisk, resultado) " +
                   "VALUES (" + paciente.usuario_id + ", " + (paciente.Sexo ? "1" : "0") + ", " + paciente.Edad + ", " + paciente.Peso + ", " + paciente.Altura + ", " + paciente.Cintura + ", " +
                   (paciente.MedicacionPA ? "1" : "0") + ", " + (paciente.ActHipoglucemia ? "1" : "0") + ", " +
                   (paciente.ActFisica ? "1" : "0") + ", " + (paciente.ConsumoFYV ? "1" : "0") + ", " + paciente.AntFamiliares + ", " + paciente.PuntosFindrisk + ", '" + paciente.Resultado + "')";

            return agente.Modificar(consulta);
        }
        public bool Modificar(Paciente paciente)
        {
            string consulta = "UPDATE pacientes SET " +
                          "sexo = " + (paciente.Sexo ? "1" : "0") + ", " +
                          "edad = " + paciente.Edad + ", " +
                          "peso = " + paciente.Peso + ", " +
                          "altura = " + paciente.Altura + ", " +
                          "cintura = " + paciente.Cintura + ", " +
                          "medicacionPa = " + (paciente.MedicacionPA ? "1" : "0") + ", " +
                          "actHipoglucemia = " + (paciente.ActHipoglucemia ? "1" : "0") + ", " +
                          "actFisica = " + (paciente.ActFisica ? "1" : "0") + ", " +
                          "consumoFyv = " + (paciente.ConsumoFYV ? "1" : "0") + ", " +
                          "antFamiliares = " + paciente.AntFamiliares + ", " +
                          "puntosFindRisk = " + paciente.PuntosFindrisk + ", " +
                          "resultado = '" + paciente.Resultado + "' " +
                          "WHERE usuario_id = " + paciente.usuario_id;

            return agente.Modificar(consulta);
        }
        /*
        public bool Eliminar(Paciente paciente)
        {
            string consulta = "DELETE FROM pacientes WHERE id = " + paciente.Id; //Por qué atributo buscamos?
            return agente.Modificar(consulta);
        }*/
    }
}


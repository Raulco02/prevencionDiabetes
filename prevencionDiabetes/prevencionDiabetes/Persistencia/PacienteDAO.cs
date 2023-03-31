using prevencionDiabetes.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevencionDiabetes.Persistencia
{
    public class PacienteDAO
    {
        public Agente agente;

        public PacienteDAO()
        {
            agente = Agente.ObtenerAgente();
        }

        public Paciente Leer(string id_paciente)
        {
            Paciente paciente = null;
            DataTable pacienteSet = agente.Leer($"SELECT * FROM pacientes WHERE id_usuario = {id_paciente}");
            if (pacienteSet.Rows.Count > 0)
            {
                DataRow fila = pacienteSet.Rows[0];
                paciente = new Paciente()
                {
                    Id = fila["id"].ToString(),
                    Correo = fila["correo"].ToString(),
                    Nombre_usuario = fila["nombre_usuario"].ToString(),
                    Contrasena = fila["contrasena"].ToString(),
                    Sexo = Convert.ToBoolean(fila["sexo"]),
                    Peso = Convert.ToDouble(fila["peso"]),
                    Altura = Convert.ToDouble(fila["altura"]),
                    Cintura = Convert.ToInt32(fila["cintura"]),
                    MedicacionPA = Convert.ToBoolean(fila["medicacion_pa"]),
                    ActHipoglucemia = Convert.ToBoolean(fila["act_hipoglucemia"]),
                    ActFisica = Convert.ToBoolean(fila["act_fisica"]),
                    ConsumoFYV = Convert.ToBoolean(fila["consumo_fyv"]),
                    AntFamiliares = Convert.ToInt32(fila["ant_familiares"]),
                    Resultado = fila["resultado"].ToString()
                };
            }
            return paciente;
        }

        public List<Paciente> LeerTodos()
        {
            List<Paciente> pacientes = new List<Paciente>();
            DataTable pacienteSet = agente.Leer("SELECT * FROM pacientes");
            foreach (DataRow row in pacienteSet.Rows)
            {
                Paciente paciente = new Paciente();
                paciente.Id = row["id"].ToString();
                paciente.Correo = row["correo"].ToString();
                paciente.Nombre_usuario = row["nombre_usuario"].ToString();
                paciente.Contrasena = row["contrasena"].ToString();
                paciente.Sexo = Convert.ToBoolean(row["sexo"]);
                paciente.Edad = Convert.ToInt32(row["edad"]);
                paciente.Peso = Convert.ToDouble(row["peso"]);
                paciente.Altura = Convert.ToDouble(row["altura"]);
                paciente.Cintura = Convert.ToInt32(row["cintura"]);
                paciente.MedicacionPA = Convert.ToBoolean(row["medicacion_pa"]);
                paciente.ActHipoglucemia = Convert.ToBoolean(row["act_hipoglucemia"]);
                paciente.ActFisica = Convert.ToBoolean(row["act_fisica"]);
                paciente.ConsumoFYV = Convert.ToBoolean(row["consumo_fyv"]);
                paciente.AntFamiliares = Convert.ToInt32(row["ant_familiares"]);
                paciente.Resultado = row["resultado"].ToString();
                pacientes.Add(paciente);
            }
            return pacientes;
        }

        public bool Insertar(Paciente paciente)
        {
            string consulta = "INSERT INTO pacientes (id, correo, nombre_usuario, contrasena, sexo, edad, peso, altura, cintura,  medicacion_pa, act_hipoglucemia, act_fisica, consumo_fyv, ant_familiares, resultado) " +
                              "VALUES (" + paciente.Id + ", '" + paciente.Correo + "', '" + paciente.Nombre_usuario + "', '" + paciente.Contrasena + "', " +
                              (paciente.Sexo ? "1" : "0") + ", " + paciente.Edad + ", " + paciente.Peso + ", " + paciente.Altura + ", " + ", " + paciente.Cintura + ", " +
                              (paciente.MedicacionPA ? "1" : "0") + ", " + (paciente.ActHipoglucemia ? "1" : "0") + ", " +
                              (paciente.ActFisica ? "1" : "0") + ", " + (paciente.ConsumoFYV ? "1" : "0") + ", " + paciente.AntFamiliares + ", '" + paciente.Resultado + "')";
            return agente.Modificar(consulta);
        }
        public bool Modificar(Paciente paciente)
        {
            string consulta = "UPDATE pacientes SET " +
                          "correo = '" + paciente.Correo + "', " +
                          "nombre_usuario = '" + paciente.Nombre_usuario + "', " +
                          "contrasena = '" + paciente.Contrasena + "', " +
                          "sexo = " + (paciente.Sexo ? "1" : "0") + ", " +
                          "edad = " + paciente.Edad + ", " +
                          "peso = " + paciente.Peso + ", " +
                          "altura = " + paciente.Altura + ", " +
                          "cintura = " + paciente.Cintura + ", " +
                          "medicacion_pa = " + (paciente.MedicacionPA ? "1" : "0") + ", " +
                          "act_hipoglucemia = " + (paciente.ActHipoglucemia ? "1" : "0") + ", " +
                          "act_fisica = " + (paciente.ActFisica ? "1" : "0") + ", " +
                          "consumo_fyv = " + (paciente.ConsumoFYV ? "1" : "0") + ", " +
                          "ant_familiares = " + paciente.AntFamiliares + ", " +
                          "resultado = '" + paciente.Resultado + "'" +
                          "WHERE id = " + paciente.Id;

            return agente.Modificar(consulta);
        }

        public bool Eliminar(Paciente paciente)
        {
            string consulta = "DELETE FROM pacientes WHERE id = " + paciente.Id;
            return agente.Modificar(consulta);
        }
    }
}


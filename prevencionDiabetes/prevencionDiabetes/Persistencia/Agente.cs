using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace prevencionDiabetes.Persistencia
{
    public class Agente
    {
        private static Agente instancia;
        private SQLiteConnection conexion;

        private Agente()
        {
            conexion = new SQLiteConnection("Data Source=database.sqlite");
        }

        public static Agente ObtenerAgente()
        {
            if (instancia == null)
            {
                instancia = new Agente();
            }
            return instancia;
        }

        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            if (this.Conectar()) { 
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
                this.Desconectar();
            }
            return tabla;
        }

        public bool Modificar(string consulta)
        {
            bool resultado = false;
            if (Conectar()) { 
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                int filasAfectadas = comando.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
                Desconectar();
            }
            
            return resultado;
        }

        public bool Conectar()
        {
            bool resultado = false;
            try
            {
                conexion.Open();
                resultado = true;
            }
            catch (Exception ex) //Revisar control de excepciones
            {
                Console.WriteLine(ex.Message);
            }
            return resultado;
        }

        public void Desconectar()
        {
            conexion.Close();
        }
    }
}

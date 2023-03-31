using prevencionDiabetes.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevencionDiabetes.Persistencia
{
    public class UsuarioDAO
    {
        public Agente agente;

        public UsuarioDAO()
        {
            agente = Agente.ObtenerAgente();
        }
        public Usuario Leer(string id_usuario)
        {
            Usuario usuario = null;
            DataTable usuarioSet = agente.Leer($"SELECT * FROM usuarios WHERE id_usuario = {id_usuario}");
            if (usuarioSet.Rows.Count > 0)
            {
                DataRow fila = usuarioSet.Rows[0];
                usuario = new Usuario()
                {
                    Id = fila["id"].ToString(),
                    Correo = fila["correo"].ToString(),
                    Nombre_usuario = fila["nombre_usuario"].ToString(),
                    Contrasena = fila["contrasena"].ToString()
                };
            }
            return usuario;
        }

        public List<Usuario> LeerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTable usuarioSet = agente.Leer("SELECT * FROM usuarios");
            foreach (DataRow row in usuarioSet.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.Id = row["id"].ToString();
                usuario.Correo = row["correo"].ToString();
                usuario.Nombre_usuario = row["nombre_usuario"].ToString();
                usuario.Contrasena = row["contrasena"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public bool Insertar(Usuario usuario)
        {
            string consulta = "INSERT INTO usuarios (id, correo, nombre_usuario, contrasena) " +
                              "VALUES (" + usuario.Id + ", '" + usuario.Correo + "', '" + usuario.Nombre_usuario + "', '" + usuario.Contrasena +  "')";
            return agente.Modificar(consulta);
        }
        public bool Modificar(Usuario usuario)
        {
            string consulta = "UPDATE usuarios SET " +
                          "correo = '" + usuario.Correo + "', " +
                          "nombre_usuario = '" + usuario.Nombre_usuario + "', " +
                          "contrasena = '" + usuario.Contrasena + "'" +
                          "WHERE id = " + usuario.Id;

            return agente.Modificar(consulta);
        }

        public bool Eliminar(Usuario usuario)
        {
            string consulta = "DELETE FROM usuarios WHERE id = " + usuario.Id;
            return agente.Modificar(consulta);
        }
    }
}

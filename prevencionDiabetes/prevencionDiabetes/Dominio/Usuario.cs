using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prevencionDiabetes.Dominio
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Correo { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contrasena { get; set; }

        public Usuario() { }
        public Usuario(string id, string correo, string nombreUsuario, string contrasena)
        {
            Id = id;
            Correo = correo;
            Nombre_usuario = nombreUsuario;
            Contrasena = contrasena;
        }
    }
}

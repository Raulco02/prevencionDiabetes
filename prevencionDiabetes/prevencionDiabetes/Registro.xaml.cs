using prevencionDiabetes.Dominio;
using prevencionDiabetes.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prevencionDiabetes
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        UsuarioDAO usuarioDAO;
        private string acceso;
        private static readonly DateTime ultimo_acceso = DateTime.Now;
        public Registro()
        {
            InitializeComponent();
            acceso = ultimo_acceso.ToString();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtContrasena.Password))
            {
                Usuario usuario = new Usuario(txtCorreo.Text, txtUsuario.Text, txtContrasena.Password);
                usuarioDAO = new UsuarioDAO();
                if (usuarioDAO.Leer(txtUsuario.Text) == null)
                {
                    Login.NombreDeUsuario = txtUsuario.Text;
                    usuarioDAO.Insertar(usuario);
                    MainWindow ventana_formulario = new MainWindow();
                    ventana_formulario.lblNombre.Content = txtUsuario.Text;
                    ventana_formulario.lblAcceso.Content = acceso;
                    ventana_formulario.lblEmail.Content = txtCorreo.Text;
                    ventana_formulario.btnUltimosResultados.IsEnabled = false;
                    ventana_formulario.Show();
                    this.Close();
                } 
                lblError.Content = "Ya existe ese usuario";
            }
            else
            {
                lblError.Content = "Rellene todos los campos";
            }
        }
    }
}

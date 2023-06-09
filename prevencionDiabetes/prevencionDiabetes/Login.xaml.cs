﻿using prevencionDiabetes.Dominio;
using prevencionDiabetes.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UsuarioDAO usuarioDAO;
        public static string NombreDeUsuario { get; set; }
        private string acceso;
        private static readonly DateTime ultimo_acceso = DateTime.Now;
        public Login()
        {
            InitializeComponent();

            acceso = ultimo_acceso.ToString();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registro ventana_registro = new Registro();
            ventana_registro.Show();
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsuario.Text) || !string.IsNullOrEmpty(txtContrasena.Password))
            {
                usuarioDAO = new UsuarioDAO();
                Usuario usuario_bbdd = usuarioDAO.Leer(txtUsuario.Text);
                if (usuario_bbdd != null && usuario_bbdd.Contrasena == txtContrasena.Password)
                {
                    NombreDeUsuario = usuario_bbdd.Nombre_usuario;
                    int id = usuarioDAO.LeerId(NombreDeUsuario);
                    
                    MainWindow ventana_formulario = new MainWindow(id);
                    ventana_formulario.lblNombre.Content = NombreDeUsuario;
                    ventana_formulario.lblAcceso.Content = acceso;
                    ventana_formulario.lblEmail.Content = usuario_bbdd.Correo;
                    ventana_formulario.Show();
                    this.Close();
                }
                lblError.Content = "Ese usuario no existe";
            } else
            {
                lblError.Content = "Rellene todos los campos";
            }

        }
    }
}

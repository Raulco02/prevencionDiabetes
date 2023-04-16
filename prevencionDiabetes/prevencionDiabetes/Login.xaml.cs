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
        public Login()
        {
            InitializeComponent();
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
                if (usuarioDAO.Leer(txtUsuario.Text) != null)
                {
                    NombreDeUsuario = txtUsuario.Text;
                    MainWindow ventana_formulario = new MainWindow();
                    ventana_formulario.Show();
                    this.Close();
                }
                lblError.Content = "No existe ese usuario";
            } else
            {
                lblError.Content = "Rellene todos los campos";
            }

        }
    }
}

using prevencionDiabetes.Dominio;
using prevencionDiabetes.Persistencia;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prevencionDiabetes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Paciente paciente;
        PacienteDAO pacienteDAO;
        UsuarioDAO usuarioDAO;
        public MainWindow()
        {
            InitializeComponent();
            paciente = new Paciente();
        }
        public MainWindow(int id)
        {
            InitializeComponent();
            pacienteDAO = new PacienteDAO();
            paciente = pacienteDAO.LeerUltimo(id);
            if (paciente != null)
            {
                cargarDatosPaciente(id);
            } else
            {
                paciente = new Paciente();
                btnUltimosResultados.IsEnabled = false;
            }
        }

        private void cargarDatosPaciente(int id)
        {
            if(paciente.Sexo == true) btnSexoMujer.IsChecked = true;
            else btnSexoHombre.IsChecked = true;

            if(paciente.Edad < 45) btnEdadMenos45.IsChecked = true;
            else if (paciente.Edad >= 45 && paciente.Edad <= 54) btnEdadEntre45y54.IsChecked = true;
            else if (paciente.Edad >= 55 && paciente.Edad <= 64) btnEdadEntre55y64.IsChecked = true;
            else btnEdadMas65.IsChecked = true;

            if(paciente.ActFisica == true) btnActividadFisicaMas4h.IsChecked = true;
            else btnActividadFisicaMenos4h.IsChecked = true;

            if(paciente.ConsumoFYV == true) btnSiConsumoFrutas.IsChecked = true;
            else btnNoConsumoFrutas.IsChecked = true;

            if (paciente.AntFamiliares == 0) btnNoAntecedentesDiabetes.IsChecked = true;
            else if (paciente.AntFamiliares == 1) btnPrimosAntecedentesDiabetes.IsChecked = true; 
            else btnPadresAntecedentesDiabetes.IsChecked = true;

            if(paciente.ActHipoglucemia == true) btnAntecedentesHiperglucemiaSi.IsChecked = true;
            else btnAntecedentesHiperglucemiaNo.IsChecked = true;

            if(paciente.MedicacionPA == true) btnMedicacionArterialSi.IsChecked = true;
            else btnMedicacionArterialNo.IsChecked = true;

            txtPeso.Text = paciente.Peso.ToString();
            txtAltura.Text = paciente.Altura.ToString();
            txtCintura.Text = paciente.Cintura.ToString();

            tbPuntuacion.Text = paciente.PuntosFindrisk.ToString();
            Recomendaciones recomendaciones= new Recomendaciones();
            tbRecomendacion.Text = recomendaciones.obtener_recomendacion(paciente.Resultado);
        }
        private void btnSexoHombre_Click(object sender, RoutedEventArgs e)
        {
            btnSexoMujer.IsChecked = false;
            paciente.Sexo = false;
        }

        private void btnSexoMujer_Click(object sender, RoutedEventArgs e)
        {
            btnSexoHombre.IsChecked = false;
            paciente.Sexo = true;
        }

        private void btnEdadMenos45_Click(object sender, RoutedEventArgs e)
        {
            btnEdadEntre45y54.IsChecked = false;
            btnEdadEntre55y64.IsChecked = false;
            btnEdadMas65.IsChecked = false;
            paciente.Edad = 30;
        }

        private void btnEdadEntre45y54_Click(object sender, RoutedEventArgs e)
        {
            btnEdadMenos45.IsChecked = false;
            btnEdadEntre55y64.IsChecked = false;
            btnEdadMas65.IsChecked = false;
            paciente.Edad = 50;
        }

        private void btnEdadEntre55y64_Click(object sender, RoutedEventArgs e)
        {
            btnEdadMenos45.IsChecked = false;
            btnEdadEntre45y54.IsChecked = false;
            btnEdadMas65.IsChecked = false;
            paciente.Edad = 60;
        }

        private void btnEdadMas65_Click(object sender, RoutedEventArgs e)
        {
            btnEdadMenos45.IsChecked = false;
            btnEdadEntre45y54.IsChecked = false;
            btnEdadEntre55y64.IsChecked = false;
            paciente.Edad = 70;
        }

        private void btnActividadFisicaMas4h_Click(object sender, RoutedEventArgs e)
        {
            btnActividadFisicaMenos4h.IsChecked = false;
            paciente.ActFisica = true;
        }

        private void btnActividadFisicaMenos4h_Click(object sender, RoutedEventArgs e)
        {
            btnActividadFisicaMas4h.IsChecked = false;
            paciente.ActFisica = false;
        }

        private void btnNoConsumoFrutas_Click(object sender, RoutedEventArgs e)
        {
            btnSiConsumoFrutas.IsChecked = false;
            paciente.ConsumoFYV = false;
        }

        private void btnSiConsumoFrutas_Click(object sender, RoutedEventArgs e)
        {
            btnNoConsumoFrutas.IsChecked = false;
            paciente.ConsumoFYV = true;
        }

        private void btnAntecedentesHiperglucemiaNo_Click(object sender, RoutedEventArgs e)
        {
            btnAntecedentesHiperglucemiaSi.IsChecked = false;
            paciente.ActHipoglucemia = false;
        }

        private void btnAntecedentesHiperglucemiaSi_Click(object sender, RoutedEventArgs e)
        {
            btnAntecedentesHiperglucemiaNo.IsChecked = false;
            paciente.ActHipoglucemia = true;
        }

        private void btnMedicacionArterialNo_Click(object sender, RoutedEventArgs e)
        {
            btnMedicacionArterialSi.IsChecked=false;
            paciente.MedicacionPA = false;
        }

        private void btnMedicacionArterialSi_Click(object sender, RoutedEventArgs e)
        {
            btnMedicacionArterialNo.IsChecked = false;
            paciente.MedicacionPA = true;
        }

        private void btnNoAntecedentesDiabetes_Click(object sender, RoutedEventArgs e)
        {
            btnPrimosAntecedentesDiabetes.IsChecked = false;
            btnPadresAntecedentesDiabetes.IsChecked = false;
            paciente.AntFamiliares = 0;
        }

        private void btnPrimosAntecedentesDiabetes_Click(object sender, RoutedEventArgs e)
        {
            btnNoAntecedentesDiabetes.IsChecked = false;
            btnPadresAntecedentesDiabetes.IsChecked = false;
            paciente.AntFamiliares = 1;
        }

        private void btnPadresAntecedentesDiabetes_Click(object sender, RoutedEventArgs e)
        {
            btnNoAntecedentesDiabetes.IsChecked = false;
            btnPrimosAntecedentesDiabetes.IsChecked = false;
            paciente.AntFamiliares = 2;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //Si ningún atributo de paciente es nulo(es decir, se ha clicado un botón por opción), y los textboxes están escritos correctamente
            if ((btnSexoHombre.IsChecked == true || btnSexoMujer.IsChecked == true) &&
                (btnEdadMenos45.IsChecked == true || btnEdadEntre45y54.IsChecked == true ||
                btnEdadEntre55y64.IsChecked == true || btnEdadMas65.IsChecked == true) &&
                (btnActividadFisicaMas4h.IsChecked == true || btnActividadFisicaMenos4h.IsChecked == true) &&
                (btnNoConsumoFrutas.IsChecked == true || btnSiConsumoFrutas.IsChecked == true) &&
                !string.IsNullOrWhiteSpace(txtPeso.Text) && !string.IsNullOrWhiteSpace(txtPeso.Text) &&
                !string.IsNullOrWhiteSpace(txtPeso.Text) &&
                (btnAntecedentesHiperglucemiaNo.IsChecked == true || btnAntecedentesHiperglucemiaSi.IsChecked == true) &&
                (btnMedicacionArterialNo.IsChecked == true || btnMedicacionArterialSi.IsChecked == true) &&
                (btnNoAntecedentesDiabetes.IsChecked == true || btnPrimosAntecedentesDiabetes.IsChecked == true || btnPadresAntecedentesDiabetes.IsChecked == true))
            {
                paciente.Peso = double.Parse(txtPeso.Text);
                paciente.Altura = double.Parse(txtAltura.Text);
                paciente.Cintura = int.Parse(txtCintura.Text);
                CalculoFindrisk calculo = new CalculoFindrisk(paciente);
                Recomendaciones recomendaciones = new Recomendaciones();
                int puntos = calculo.calcularPuntos();
                paciente.PuntosFindrisk = puntos;
                int recomendacion = calculo.obtenerRecomendaciones();
                paciente.Resultado = recomendacion;
                tbPuntuacion.Text = puntos.ToString();
                tbRecomendacion.Text = recomendaciones.obtener_recomendacion(recomendacion);

                pacienteDAO = new PacienteDAO();
                usuarioDAO = new UsuarioDAO();

                paciente.usuario_id = usuarioDAO.LeerId(Login.NombreDeUsuario);
                pacienteDAO.Insertar(paciente);
                btnUltimosResultados.IsEnabled = true;
            }
        }
        private void aceptarDouble(object sender, TextCompositionEventArgs e)
        {
            double result;
            if (!double.TryParse((sender as TextBox).Text + e.Text, out result))
            {
                e.Handled = true;
            }
        }
        private void aceptarInt(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!int.TryParse((sender as TextBox).Text + e.Text, out result))
            {
                e.Handled = true;
            }
        }
        private void txtPeso_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            aceptarDouble(sender, e);
        }

        private void txtAltura_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            aceptarDouble(sender, e);
        }

        private void txtCintura_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            aceptarInt(sender, e);
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Login ventana_login = new Login();
            ventana_login.Show();
            this.Close();
        }

        private void btnUltimosResultados_Click(object sender, RoutedEventArgs e)
        {
            List<Paciente> pacientes = pacienteDAO.LeerConsultas(paciente.usuario_id);
            Historial historial = new Historial(pacientes);
            historial.Show();
        }
    }
}

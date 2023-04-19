using prevencionDiabetes.Dominio;
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
using System.Windows.Shapes;

namespace prevencionDiabetes
{
    /// <summary>
    /// Lógica de interacción para Historial.xaml
    /// </summary>
    public partial class Historial : Window
    {
        public Historial(List<Paciente> pacientes)
        {
            InitializeComponent();
            listaPacientes.ItemTemplate = (DataTemplate)Resources["TemplatePaciente"];
            listaPacientes.ItemsSource = pacientes;
            darResumen(pacientes);
        }
        public void darResumen(List<Paciente> pacientes)
        {
            if (pacientes.Count > 1)
            {
                if (pacientes[0].PuntosFindrisk < pacientes[pacientes.Count - 1].PuntosFindrisk)
                    tbResumen.Text = "Has mejorado tu puntuación respecto a la medida inicial. Continúa introduciendo buenos hábitos en tu día a día.";
                else
                                if (pacientes[0].PuntosFindrisk > 14)
                    tbResumen.Text = "Tu puntuación respecto a la medida inicial ha empeorado. Visita al médico. Come fruta y verdura, realiza actividad física y mantén buenos hábitos.";
                else
                    tbResumen.Text = "Tu puntuación respecto a la medida inicial ha empeorado. Come fruta y verdura, realiza actividad física y mantén buenos hábitos.";
            }
            else
            {
                RowDefinition rowDefinition = miGrid.RowDefinitions[1];
                rowDefinition.Height = new GridLength(0);
            }
        }
    }
}

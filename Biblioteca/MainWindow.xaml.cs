using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_AggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            string autore, titolo, editore;
            int annoPubblicazione, numeroPagine;
            autore = InputAutoreLibro.Text;
            titolo = InputTitoloLibro.Text;
            editore = InputEditoreLibro.Text;
            annoPubblicazione = int.Parse(InputAnnoPubblicazioneLibro.Text);
            numeroPagine = int.Parse(InputNumeroPagineLibro.Text);
            Libro libro = new Libro(autore,titolo, annoPubblicazione,editore,numeroPagine);
            OutputDatiLibro.Text = (string)libro.ToString();
            if (libro.readingTime(numeroPagine) == 1)
            {
                OutputOreDiLettura.Text = "Ore di lettura pari a 1";
            }else if (libro.readingTime(numeroPagine) == 2)
            {
                OutputOreDiLettura.Text = "Ore di lettura pari a 2";
            }else OutputOreDiLettura.Text = "Ore di lettura superiore a 2";
        }

        private void btn_CercaLibro_Click(object sender, RoutedEventArgs e)
        {
            string titolo = InputTitoloLibro2.Text;
        }

        private void btn_CercaLibroAutore_Click(object sender, RoutedEventArgs e)
        {
            string autore = InputAutoreLibro2.Text;
        }

        private void btn_NumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            string numeroLibri = "";
            OutputNumeroLibri.Text = numeroLibri; 
        }
    }
}
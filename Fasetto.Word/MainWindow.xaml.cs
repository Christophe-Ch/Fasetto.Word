using Fasetto.Word.ViewModel;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new WindowViewModel(this);

        }
    }
}

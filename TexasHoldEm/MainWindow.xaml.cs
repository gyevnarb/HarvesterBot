using System.Windows;

namespace TexasHoldEm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Client.TexasHoldEm _texasHoldEm = new Client.TexasHoldEm();
        public MainWindow()
        {
            InitializeComponent();
            _texasHoldEm.Init(MainGrid);
        }
    }
}

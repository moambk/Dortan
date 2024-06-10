using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Dortan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {


            Connexion pageDeConnexion = new Connexion();
            ApplicationData readActivite = new ApplicationData();
            pageDeConnexion.ShowDialog();
            InitializeComponent();
            readActivite.Read();
            readActivite.ReadVisu();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData applicationData = new ApplicationData();
            Activite employe = new Activite();

            foreach (UIElement elements in StackPanelCreerActivite.Children)
            {
                if (elements is TextBox )
                {
                    TextBox information = (TextBox)elements;
                    information.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                    Console.WriteLine(information.Text);

                }
            }

        }
    }
}

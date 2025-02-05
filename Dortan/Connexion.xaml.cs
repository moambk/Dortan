﻿using System;
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

namespace Dortan
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {

        public Connexion()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.DialogResult != true)
            {
                Application.Current.Shutdown();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationData applicationData = new ApplicationData();
            Employe employe = new Employe();
            
            foreach (UIElement elements in StackPanelConnexion.Children)
            {
                if (elements is TextBox)
                {
                    TextBox validite = (TextBox)elements;
                    validite.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                    Console.WriteLine(validite.Text);

                }
            }
            if (applicationData.TryConnexion(nouvelEmploye)) 
            {
                this.DialogResult = true; 
            };
            Console.WriteLine(employe);


        }
    }
}

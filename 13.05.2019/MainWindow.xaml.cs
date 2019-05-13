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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _13._05._2019
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs t)
        {
            newWindow.Margin = new Thickness();
            Uri uri = new Uri(@"https://www.google.ru");
            GoogleButton.Items.Add(new WebBrowser { Source = uri });
        }
    }
}

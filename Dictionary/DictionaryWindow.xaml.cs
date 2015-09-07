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

namespace Dictionary
{
   
    public partial class DictionaryWindow : Window
    {
        public DictionaryWindow()
        {
            InitializeComponent();
            MainMenuGrid.Visibility = Visibility.Visible;
            DictionaryGrid.Visibility = Visibility.Hidden;
        }

        private void DictionaryButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Hidden;
            DictionaryGrid.Visibility = Visibility.Visible;
        }

        private void AddWordButton_Click(object sender, RoutedEventArgs e)
        {
            WordProperties wp = new WordProperties();
            wp.Show();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Visible;
            DictionaryGrid.Visibility = Visibility.Hidden;

        }
    }
}

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
using osuTrainer.ViewModels;

namespace osuTrainer.Views
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (DataContext == null)
            {
                DataContext = new SearchViewModel();
            }
        }

        private void Search_OnInitialized(object sender, EventArgs e)
        {
            GameModeCb.ItemsSource = Enum.GetValues(typeof(GlobalVars.GameMode)).Cast<int>();
        }
    }
}
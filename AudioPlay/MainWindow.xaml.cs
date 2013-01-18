﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using AudioPlay.Pages;

namespace AudioPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private PlayPage playPage;

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            playPage = new PlayPage();
            this.Content = playPage;
            //this.Content = new Page2();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            playPage.Dispose();
            base.OnClosing(e);
        }
    }
}

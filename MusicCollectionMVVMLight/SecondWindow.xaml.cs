﻿using System.Windows;
using MusicCollectionMVVMLight.ViewModel;

namespace MusicCollectionMVVMLight
{
    /// <summary>
    /// This application's main window.
    /// </summary>
    public partial class SecondWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public SecondWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace HousingEstate02.View
{
    /// <summary>
    /// Interaction logic for BoFCreateView.xaml
    /// </summary>
    public partial class BoFCreateView : UserControl
    {
        public string[] bofnums { get; set; }
        public BoFCreateView()
        {
            InitializeComponent();
            bofnums = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            DataContext = this;
            
            if (Keyboard.IsKeyDown(Key.Enter))
            {

            }
        }
    }
}

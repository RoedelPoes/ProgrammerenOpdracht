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

namespace WpfAppGridspelletje
{
    /// <summary>
    /// Interaction logic for VictoryWindow.xaml
    /// </summary>
    public partial class VictoryWindow : Window
    {
        public VictoryWindow(int timeSeconds)
        {
            InitializeComponent();
            tbScore.Text = "Je hebt het plaatje gevangen in " + Convert.ToString(10-timeSeconds) + " seconden!";
        }
    }
}

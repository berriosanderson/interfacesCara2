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

namespace interfacesCara
{
  /// <summary>
  /// Lógica de interacción para Equipos.xaml
  /// </summary>
  public partial class Equipos : Window
  {
    public Equipos()
    {
      InitializeComponent();
    }

    private void btnBack_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}

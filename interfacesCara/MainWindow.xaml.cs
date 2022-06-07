using System;
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

namespace interfacesCara
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Student student;


    public MainWindow()
    {
      InitializeComponent();
    }
    public void select(RoutedEventArgs e)
    {
      int index = int.Parse(((Button)e.Source).Uid);

      UserControl usc =null ;
      switch (index)
      {
        case 0:
          Select se = new Select();
          se.ShowDialog();
          break;
        case 1:
          Equipos equi = new Equipos();
          equi.ShowDialog();
          break;
        case 2:
          editEquipo edE = new editEquipo();
          edE.ShowDialog();
          break;
        default:
          break;
      } if (usc != null) {

        griMain.Children.Add(usc);
      }
    }

    private void editEquipo_Click(object sender, RoutedEventArgs e)
    {
      select(e);
      
    }

    private void Equipos_Click(object sender, RoutedEventArgs e)
    {
      select(e);
      
    }

    private void Seleccion_Click(object sender, RoutedEventArgs e)
    {
      select(e);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}

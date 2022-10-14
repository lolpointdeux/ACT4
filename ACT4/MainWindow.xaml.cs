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

namespace ACT4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();

            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();

            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);
            StackPanel stkBloc1 = new StackPanel();

            Grid.SetColumn(coldef1, 0);
            Grid.SetColumn(coldef2, 1);
            Grid.SetColumn(coldef3, 2);
            Grid.SetRow(rowDef1, 0);
            Grid.SetRow(rowDef2, 1);
            Grid.setRow(rowDef3, 2);

            //buton
            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();

            btn1.Content = "Button 1 ";
            btn2.Content = "Button 2 ";
            btn3.Content = "Button 3 ";

            TextBlock txtb = new TextBlock();
            txtb.Text = "Texte à afficher";
            grdMain.Children.Add(txtb);
           

            
        }
    }
}

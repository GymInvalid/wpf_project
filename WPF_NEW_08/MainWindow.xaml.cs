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
using WPF_NEW_08.ControlConstract;

namespace WPF_NEW_08
{
    public struct ControlVisibility
    {
        public Visibility PrTree;
    }
    public partial class MainWindow : Window
    {
        public static ControlVisibility controlVisibility = new ControlVisibility();
        public static TreeView tv_ProjectTree = new TreeView();
        public static Border b_ProjectTree = new Border();

        public MainWindow()
        {
            InitializeComponent();
            PrTree.Border();
            PrTree.TreeView();

            b_ProjectTree.Child = tv_ProjectTree;
            g_Main.Children.Add(b_ProjectTree);
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public static void ControlRefresh()
        {
            b_ProjectTree.Visibility = controlVisibility.PrTree;
        }
    }
}

using PRACTICA1.PRACTICADataSetTableAdapters;
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

namespace PRACTICA1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        //DirectorsTableAdapter directors = new DirectorsTableAdapter();
        //public Page2()
        //{
        //    InitializeComponent();
        //    Directorsdg.ItemsSource = directors.GetData();
        //}

        private PRACTICAEntities contextD = new PRACTICAEntities();
        public Page2()
        {
            InitializeComponent();
            Directorsdg.ItemsSource = contextD.Directors.ToList();

        }
    }
}

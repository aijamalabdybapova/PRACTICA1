﻿using PRACTICA1.PRACTICADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>

    public partial class Page1 : Page
    {
        //MoviesTableAdapter movies = new MoviesTableAdapter();
        //public Page1()
        //{
        //    InitializeComponent();
        //    Moviesdg.ItemsSource = movies.GetData();
        //}

        private PRACTICAEntities contextM = new PRACTICAEntities();
        public Page1()
        {
            InitializeComponent();
            Moviesdg.ItemsSource = contextM.Movies.ToList();

        }
    }
}
    

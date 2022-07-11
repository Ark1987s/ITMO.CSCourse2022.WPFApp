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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.CSCourse2022.WPFApp.Lab01.Ex01_WPFHello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new 
                    System.IO.StreamWriter("D:\\Study\\engineer\\5_CS_Win\\Lab\\ITMO.CSCourse2022.WPFApp\\ITMO.CSCourse2022.WPFApp.Lab01.Ex01_WPFHello\\test.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader("D:\\Study\\engineer\\5_CS_Win\\Lab\\ITMO.CSCourse2022.WPFApp\\ITMO.CSCourse2022.WPFApp.Lab01.Ex01_WPFHello\\test.txt");
                label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
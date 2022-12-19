using System;
using System.CodeDom;
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

namespace DZ5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    class Vagon
    {
        int number; // Номер рейса
        int sit; // Время вылета Дни недели 
        int lie; // Время вылета Дни недели         

        public Vagon(int n, int s, int l)
        {
            number = n;
            sit = s;
            lie = l;
        }
        public void setSit(int s)
        {
            sit = s;
        }
        public int getSit()
        {
            return sit;
        }
        public void setLie(int l)
        {
            lie = l;
        }
        public int getLie()
        {
            return lie;
        }
        public void setNumber(int n)
        {
            number = n;
        }
        public int getNumber()
        {
            return number;
        }
        public string info()
        {
            return String.Format("\n\tНомер вагона: {0}\tКоличество общих мест: {1}\tКоличество общих мест: {2}\n", number, sit, lie);
        }
    }

    class Kniga {
        int code;
        int year;
        int cost;
        int page;
        
        public Kniga(int c, int y, int co, int p)
        {
            code = c;
            year = y;
            cost = co;
            page = p;
        }

        public void SetCode(int c)
        {
            code = c;
        }

        public void SetYear(int y)
        {
            year = y;
        }

        public void SetCost(int co)
        {
            cost = co;
        }

        public void SetPage(int p)
        {
            page = p;
        }

        public int GetCode()
        {
            return code;
        }

        public int GetYear()
        {
            return year;
        }

        public int GetCost()
        {
            return cost;
        }

        public int GetPage()
        {
            return page;
        }

        public string info()
        {
            return String.Format("\n\tШифр книги: {0}\tГод издания: {1}\tЦена: {2}\tКоличество страниц: {3}\n", code, year, cost, page );
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Kniga[] kniga = new Kniga[5];
            kniga[0] = new Kniga(1, 2003, 10, 100);
            kniga[1] = new Kniga(2, 2004, 2, 30);
            kniga[2] = new Kniga(3, 2006, 34, 30);
            kniga[3] = new Kniga(4, 2001, 11, 400);
            kniga[4] = new Kniga(5, 2008, 13, 10);
            for (int i = 0; i < 5; i++)
                tb1.Text = tb1.Text + String.Format(kniga[i].info());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
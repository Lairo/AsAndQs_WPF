using AsAndQs;
using System;
using System.Windows;

namespace AsAndQs_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new C();
            string q = "";


            // 4 buttons
            // entire answers shown and then the correct answer light up in green?
            // list or buttons?

            q += b.m1();
            q += c.m2();
            q += a.m3();

            Console.WriteLine(q);

            q = "";

            q += c.m1();
            q += c.m2();
            q += c.m3();

            Console.WriteLine(q);

            q = "";

            q += a.m1();
            q += b.m2();
            q += c.m3();

            Console.WriteLine(q);

            q = "";

            q += a2.m1();
            q += a2.m2();
            q += a2.m3();

            Console.WriteLine(q);
        }
    }
}

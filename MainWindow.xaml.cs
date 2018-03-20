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
using System.IO.Ports;

namespace MotorControlGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort serial;

        public MainWindow()
        {
            InitializeComponent();

            SerialPortInit("COM4");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="port"></param>
        private void SerialPortInit(String port)
        {
            serial = new SerialPort();

            serial.PortName = port;

            serial.ReadTimeout = 500;
            serial.WriteTimeout = 500;

            serial.Open();


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void M1Forward_Click(object sender, RoutedEventArgs e)
        {
            String speed = M1Speed.Text;
            Console.WriteLine(speed);
        }
    }
}

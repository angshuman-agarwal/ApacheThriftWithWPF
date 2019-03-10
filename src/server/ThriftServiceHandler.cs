using System;
using System.Windows;

namespace ApacheThriftWithWPF
{
    public class ThriftServiceHandler : MyThriftService.Iface
    {
        public double GetSum(double num1, double num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        public string GetHelloMessage(string name)
        {
            var helloMessage = string.Format("Hello {0}", name);
            return helloMessage;
        }

        public void OpenWindow(string title)
        {
            Application.Current.Dispatcher.Invoke((Action)delegate {
                Window w = new Window();
                w.Title = $"{title} has been created using Apache Thrift";
                w.Show();
            });
        }
    }
}

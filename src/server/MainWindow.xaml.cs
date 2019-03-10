using System.Threading.Tasks;
using System.Windows;
using Thrift.Server;
using Thrift.Transport;

namespace ApacheThriftWithWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {

                var handler = new ThriftServiceHandler();
                var processor = new MyThriftService.Processor(handler);

                TServerTransport transport = new TServerSocket(9090);
                TServer server = new TThreadPoolServer(processor, transport);

                server.Serve();
            });

        }
    }
}

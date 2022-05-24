using System.IO.Ports;

namespace IBMGRX_Terminal
{
    public partial class Form1 : Form
    {
        static SerialPort port;
        Int32 baudrate = 9600;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();

        }

        private void PortSelect_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortSelect.Items.Clear();
            PortSelect.Items.AddRange(ports);
        }

        private void OpenClose_Click(object sender, EventArgs e)
        {
            if (OpenClose.Text == "CONNECT")
            {
                if (PortSelect.Text.Length > 1)
                {
                    baudrate = Convert.ToInt32(BaudrateSelect.Text);
                    port = new SerialPort(PortSelect.Text, baudrate, Parity.None, 8, StopBits.One);

                    port.Open();
                    port.DataReceived += DataReceived;

                    OpenClose.Text = "CLOSE";
                }
            }
            else
            {
                port.Close();
                OpenClose.Text = "CONNECT";
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            port.WriteLine(textBox_send.Text);
            textBox_send.Text = "";
        }

        void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            textBox_rec.Text = port.ReadLine();
        }

    }
}
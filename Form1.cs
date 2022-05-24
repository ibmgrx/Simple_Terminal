using System.IO.Ports;

namespace IBMGRX_Terminal
{
    public partial class Form1 : Form
    {
        static SerialPort port;
        Int32 baudrate = 9600;
        String dataIn = "";
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            timer1.Start();
        }



        private void PortSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                PortSelect.Items.Clear();
                PortSelect.Items.AddRange(ports);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void OpenClose_Click(object sender, EventArgs e)
        {
            if (OpenClose.Text == "CONNECT")
            {
                if (PortSelect.Text.Length > 1)
                {
                    try
                    {
                        baudrate = Convert.ToInt32(BaudrateSelect.Text);
                        port = new SerialPort(PortSelect.Text, baudrate, Parity.None, 8, StopBits.One);

                        port.Open();
                        port.DataReceived += DataReceived;

                        OpenClose.Text = "CLOSE";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    port.Close();
                    OpenClose.Text = "CONNECT";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                port.WriteLine(textBox_send.Text);
                textBox_send.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIn = port.ReadLine();
                this.Invoke(new EventHandler(Show_data));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Show_data(object sender, EventArgs e)
        {
            textBox_rec.AppendText(dataIn);
            textBox_rec.AppendText(Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox_rec.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.txt|*.txt";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBox_rec.Text);
            }
        }
    }
}
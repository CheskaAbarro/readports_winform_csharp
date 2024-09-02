using System.IO.Ports;


namespace readport_winform_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //GetPorts();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            GetPorts();
        }


        public void GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            if (ports != null && ports.Length > 0)
            {
                lblStatus.Text = "Ports found!";
                portList.Items.Clear();

                foreach (string port in ports)
                {
                    portList.Items.Add(port);
                }
            }
            else
            {
                lblStatus.Text = "No ports found!";
            }

        }

    }
}

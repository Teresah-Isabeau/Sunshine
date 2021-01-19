using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class ArduinoForm : Form
    {
        string serialtxt;
        string arduino;

        public ArduinoForm()
        {
            InitializeComponent();
            ArduinoPort.Open();
        }

        private void ArduinoPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialtxt = ArduinoPort.ReadLine(); //uitlezen serialport
            this.Invoke(new EventHandler(ShowData)); //doorzetten data uit serialport
        }
        private void ShowData(object sender, EventArgs e)
        {
            arduino = serialtxt; //omzetten variable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TEST
            MessageBox.Show(arduino);
        }
    }
}

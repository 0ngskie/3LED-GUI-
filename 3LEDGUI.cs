using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoActivity01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led01 ON
            serialPort1.Write("redON");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led02 ON
            serialPort1.Write("blueON");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led03 ON
            serialPort1.Write("yellowON");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led01 OFF
            serialPort1.Write("redOFF");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led02 OFF
            serialPort1.Write("yellowOFF");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //sends a command to the arduino to turn pin led03 OFF
            serialPort1.Write("blueOFF");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Auto_ControllerBluet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("g!");
            }
            catch 
            {
                Console.WriteLine("unable");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("b!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("r!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Write("l!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }

        private void Supmit_Click(object sender, EventArgs e)
        {
            
            serialPort1.Close();
            serialPort1.PortName = PortNameInput.Text;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void schneller_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("m!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }

        private void langsamer_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("w!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }

        private void Horn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("h!");
            }
            catch
            {
                Console.WriteLine("unable");
            }
        }
    }
}

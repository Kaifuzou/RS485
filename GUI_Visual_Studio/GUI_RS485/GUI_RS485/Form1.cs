using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace GUI_RS485
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Baudgate = { "9600", "115200" };
            cbbau.Items.AddRange(Baudgate);
            Control.CheckForIllegalCrossThreadCalls = false;
            cbport.DataSource = SerialPort.GetPortNames();
            cbbau.Text = "9600";
        }

        private void buton1sl1_Click(object sender, EventArgs e)
        {
            serCom.Write("@01B1#");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serCom.Write("@01B2#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serCom.Write("@01B3#");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serCom.Write("@01B4#");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serCom.Write("@02B1#");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serCom.Write("@02B2#");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            serCom.Write("@02B3#");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            serCom.Write("@02B4#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serCom.Write("@01T1#");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serCom.Write("@01T2#");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serCom.Write("@01T3#");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serCom.Write("@01T4#");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serCom.Write("@02T1#");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serCom.Write("@02T2#");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            serCom.Write("@02T3#");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            serCom.Write("@02T4#");
        }

        private void txtsl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic1sl1_Click(object sender, EventArgs e)
        {

        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if (!serCom.IsOpen)
            {
                butConnect.Text = "Dissconnect";
                serCom.PortName = cbport.Text;
                serCom.BaudRate = Convert.ToInt32(cbbau.Text);
                serCom.Open();
            }
            else
            {
                butConnect.Text = "Connect";
                serCom.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serCom.Write("Check");
            picsl1.BackColor = Color.Red;
            picsl2.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serCom.Write("Reset");
        }

        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String allData = "";
            allData = serCom.ReadLine();
            txtdata.Text = allData;
            int leng = allData.Length;
            //@01B1#
            //012345
            if (allData != "")
            {
                if (allData == "ON1")
                {
                    picsl1.BackColor = Color.Green;
                }
                if (allData == "ON2")
                {
                    picsl2.BackColor = Color.Green;
                }
               // if (leng == 6)
               // {
                    String sl = allData.Substring(2, 1);
                    String status = allData.Substring(3, 1);
                    String led = allData.Substring(4, 1);
                    String checksl = allData;
                    if (sl == "1")
                    {
                        txtsl1.Text = allData;
                        if (status == "B")
                        {
                            if (led == "1")
                            {
                                pic1sl1.BackColor = Color.Green;
                            }
                            if (led == "2")
                            {
                                pic2sl1.BackColor = Color.Green;
                            }
                            if (led == "3")
                            {
                                pic3sl1.BackColor = Color.Green;
                            }
                            if (led == "4")
                            {
                                pic4sl1.BackColor = Color.Green;
                            }
                        }
                        if (status == "T")
                        {
                            if (led == "1")
                            {
                                pic1sl1.BackColor = Color.Red;
                            }
                            if (led == "2")
                            {
                                pic2sl1.BackColor = Color.Red;
                            }
                            if (led == "3")
                            {
                                pic3sl1.BackColor = Color.Red;
                            }
                            if (led == "4")
                            {
                                pic4sl1.BackColor = Color.Red;
                            }
                        }
                    }
                    if (sl == "2")
                    {
                        txtsl2.Text = allData;
                        if (status == "B")
                        {
                            if (led == "1")
                            {
                                pic1sl2.BackColor = Color.Green;
                            }
                            if (led == "2")
                            {
                                pic2sl2.BackColor = Color.Green;
                            }
                            if (led == "3")
                            {
                                pic3sl2.BackColor = Color.Green;
                            }
                            if (led == "4")
                            {
                                pic4sl2.BackColor = Color.Green;
                            }
                        }
                        if (status == "T")
                        {
                            if (led == "1")
                            {
                                pic1sl2.BackColor = Color.Red;
                            }
                            if (led == "2")
                            {
                                pic2sl2.BackColor = Color.Red;
                            }
                            if (led == "3")
                            {
                                pic3sl2.BackColor = Color.Red;
                            }
                            if (led == "4")
                            {
                                pic4sl2.BackColor = Color.Red;
                            }
                        }
                    }
               // }
            }
        }
    }
}

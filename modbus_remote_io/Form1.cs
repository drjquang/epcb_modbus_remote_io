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
using Modbus.Device;

namespace modbus_remote_io
{
    public partial class Form1 : Form
    {
        // Variable declaration
        ModbusSerialMaster master;
        public byte default_address = 255;
        public byte slave_address;
        public ushort[] availabe_address;
        public ushort current_address;

        public int progress_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // find the available serial ports
            string[] serial_available = SerialPort.GetPortNames();
            cbo_port_no.Items.AddRange(serial_available);

            // initialize comboBox
            cbo_baudrate.SelectedIndex = 3;
            cbo_data_bits.SelectedIndex = 2;
            cbo_stop_bits.SelectedIndex = 0;
            cbo_parity.SelectedIndex = 0;
            // intialize lbl_address
            lbl_address.Text = default_address.ToString();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbo_port_no.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbo_baudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbo_data_bits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbo_stop_bits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbo_parity.Text);

                serialPort1.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort1);
                // if successfully open serial port
                progressBar1.Value = 100;
                groupBox1.Enabled = false;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                groupBox1.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();                
            }
        }

        private void btn_Get_address_Click(object sender, EventArgs e)
        {
            // display the current_address
            availabe_address = master.ReadHoldingRegisters(0, 0, 1);
            current_address = availabe_address[0];
            lbl_address.Text = Convert.ToString(current_address);
            txt_Set_address.Text = lbl_address.Text;
        }

        private void btn_Set_address_Click(object sender, EventArgs e)
        {
            slave_address = Convert.ToByte(txt_Set_address.Text);
            lbl_address.Text = txt_Set_address.Text;
            ushort[] set_address = new ushort[1];
            set_address[0] = Convert.ToUInt16(txt_Set_address.Text);

            try
            {
                master.WriteMultipleRegisters(0, 0, set_address);
                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                MessageBox.Show("The current address " + current_address.ToString() + " will be set to slave address " + slave_address.ToString());
            }
            
        }

        private void btn_On_RL1_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 0, true);
        }

        private void btn_Off_RL1_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 0, false);
        }

        private void btn_On_RL2_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 1, true);
        }

        private void btn_Off_RL2_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 1, false);
        }

        private void btn_On_RL3_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 2, true);
        }

        private void btn_Off_RL3_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 2, false);
        }

        private void btn_On_RL4_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 3, true);
        }

        private void btn_Off_RL4_Click(object sender, EventArgs e)
        {
            master.WriteSingleCoil(slave_address, 3, false);
        }

        private void btn_Poll_RLstatus_Click(object sender, EventArgs e)
        {            
            bool[] RL_status = new bool[8];
            RL_status = master.ReadCoils(slave_address, 0, 8);
            lbl_RL1_status.Text = RL_status[0].ToString();
            lbl_RL2_status.Text = RL_status[1].ToString();
            lbl_RL3_status.Text = RL_status[2].ToString();
            lbl_RL4_status.Text = RL_status[3].ToString();
        }

        private void btn_Poll_INstatus_Click(object sender, EventArgs e)
        {
            bool[] IN_status = new bool[8];
            IN_status = master.ReadInputs(slave_address, 0, 8);
            lbl_IN1_status.Text = IN_status[0].ToString();
            lbl_IN2_status.Text = IN_status[1].ToString();
            lbl_IN3_status.Text = IN_status[2].ToString();
            lbl_IN4_status.Text = IN_status[3].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Value = progress_count;
            if (progress_count >= 100)
            {
                btn_Poll_RLstatus_Click(btn_Poll_RLstatus, EventArgs.Empty);
                btn_Poll_INstatus_Click(btn_Poll_INstatus, EventArgs.Empty);
                progress_count = 0;
                timer1.Enabled = false;
                timer2.Enabled = true;

            }
            else
            {
                progress_count = progress_count + 10;
            }
        }

        private void btn_Poll_all_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
    }
}

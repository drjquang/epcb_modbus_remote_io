namespace modbus_remote_io
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_parity = new System.Windows.Forms.ComboBox();
            this.cbo_data_bits = new System.Windows.Forms.ComboBox();
            this.cbo_stop_bits = new System.Windows.Forms.ComboBox();
            this.cbo_baudrate = new System.Windows.Forms.ComboBox();
            this.cbo_port_no = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Set_address = new System.Windows.Forms.TextBox();
            this.btn_Set_address = new System.Windows.Forms.Button();
            this.btn_Get_address = new System.Windows.Forms.Button();
            this.lbl_address = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Off_RL4 = new System.Windows.Forms.Button();
            this.btn_On_RL4 = new System.Windows.Forms.Button();
            this.btn_Off_RL3 = new System.Windows.Forms.Button();
            this.btn_On_RL3 = new System.Windows.Forms.Button();
            this.btn_Off_RL2 = new System.Windows.Forms.Button();
            this.btn_On_RL2 = new System.Windows.Forms.Button();
            this.btn_Off_RL1 = new System.Windows.Forms.Button();
            this.btn_On_RL1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_RL4_status = new System.Windows.Forms.Label();
            this.lbl_RL3_status = new System.Windows.Forms.Label();
            this.lbl_RL2_status = new System.Windows.Forms.Label();
            this.lbl_RL1_status = new System.Windows.Forms.Label();
            this.btn_Poll_RLstatus = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_Poll_INstatus = new System.Windows.Forms.Button();
            this.lbl_IN1_status = new System.Windows.Forms.Label();
            this.lbl_IN2_status = new System.Windows.Forms.Label();
            this.lbl_IN3_status = new System.Windows.Forms.Label();
            this.lbl_IN4_status = new System.Windows.Forms.Label();
            this.btn_Poll_all = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_parity);
            this.groupBox1.Controls.Add(this.cbo_data_bits);
            this.groupBox1.Controls.Add(this.cbo_stop_bits);
            this.groupBox1.Controls.Add(this.cbo_baudrate);
            this.groupBox1.Controls.Add(this.cbo_port_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port parameters";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Parity";
            // 
            // cbo_parity
            // 
            this.cbo_parity.FormattingEnabled = true;
            this.cbo_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbo_parity.Location = new System.Drawing.Point(120, 147);
            this.cbo_parity.Name = "cbo_parity";
            this.cbo_parity.Size = new System.Drawing.Size(120, 28);
            this.cbo_parity.TabIndex = 2;
            // 
            // cbo_data_bits
            // 
            this.cbo_data_bits.FormattingEnabled = true;
            this.cbo_data_bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbo_data_bits.Location = new System.Drawing.Point(120, 87);
            this.cbo_data_bits.Name = "cbo_data_bits";
            this.cbo_data_bits.Size = new System.Drawing.Size(120, 28);
            this.cbo_data_bits.TabIndex = 2;
            // 
            // cbo_stop_bits
            // 
            this.cbo_stop_bits.FormattingEnabled = true;
            this.cbo_stop_bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbo_stop_bits.Location = new System.Drawing.Point(120, 117);
            this.cbo_stop_bits.Name = "cbo_stop_bits";
            this.cbo_stop_bits.Size = new System.Drawing.Size(120, 28);
            this.cbo_stop_bits.TabIndex = 2;
            // 
            // cbo_baudrate
            // 
            this.cbo_baudrate.FormattingEnabled = true;
            this.cbo_baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbo_baudrate.Location = new System.Drawing.Point(120, 57);
            this.cbo_baudrate.Name = "cbo_baudrate";
            this.cbo_baudrate.Size = new System.Drawing.Size(120, 28);
            this.cbo_baudrate.TabIndex = 2;
            // 
            // cbo_port_no
            // 
            this.cbo_port_no.FormattingEnabled = true;
            this.cbo_port_no.Location = new System.Drawing.Point(120, 27);
            this.cbo_port_no.Name = "cbo_port_no";
            this.cbo_port_no.Size = new System.Drawing.Size(120, 28);
            this.cbo_port_no.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port no";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Connect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(120, 25);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(19, 25);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(80, 30);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Set_address);
            this.groupBox3.Controls.Add(this.btn_Set_address);
            this.groupBox3.Controls.Add(this.btn_Get_address);
            this.groupBox3.Controls.Add(this.lbl_address);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(300, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address GET-SET";
            // 
            // txt_Set_address
            // 
            this.txt_Set_address.Location = new System.Drawing.Point(140, 71);
            this.txt_Set_address.Name = "txt_Set_address";
            this.txt_Set_address.Size = new System.Drawing.Size(66, 26);
            this.txt_Set_address.TabIndex = 2;
            // 
            // btn_Set_address
            // 
            this.btn_Set_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Set_address.Location = new System.Drawing.Point(20, 70);
            this.btn_Set_address.Name = "btn_Set_address";
            this.btn_Set_address.Size = new System.Drawing.Size(80, 30);
            this.btn_Set_address.TabIndex = 0;
            this.btn_Set_address.Text = "Set addr";
            this.btn_Set_address.UseVisualStyleBackColor = true;
            this.btn_Set_address.Click += new System.EventHandler(this.btn_Set_address_Click);
            // 
            // btn_Get_address
            // 
            this.btn_Get_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Get_address.Location = new System.Drawing.Point(20, 30);
            this.btn_Get_address.Name = "btn_Get_address";
            this.btn_Get_address.Size = new System.Drawing.Size(80, 30);
            this.btn_Get_address.TabIndex = 0;
            this.btn_Get_address.Text = "Get addr";
            this.btn_Get_address.UseVisualStyleBackColor = true;
            this.btn_Get_address.Click += new System.EventHandler(this.btn_Get_address_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.Yellow;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Blue;
            this.lbl_address.Location = new System.Drawing.Point(137, 27);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(70, 33);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "255";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Off_RL4);
            this.groupBox4.Controls.Add(this.btn_On_RL4);
            this.groupBox4.Controls.Add(this.btn_Off_RL3);
            this.groupBox4.Controls.Add(this.btn_On_RL3);
            this.groupBox4.Controls.Add(this.btn_Off_RL2);
            this.groupBox4.Controls.Add(this.btn_On_RL2);
            this.groupBox4.Controls.Add(this.btn_Off_RL1);
            this.groupBox4.Controls.Add(this.btn_On_RL1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(300, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 200);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relays control";
            // 
            // btn_Off_RL4
            // 
            this.btn_Off_RL4.Location = new System.Drawing.Point(132, 154);
            this.btn_Off_RL4.Name = "btn_Off_RL4";
            this.btn_Off_RL4.Size = new System.Drawing.Size(80, 30);
            this.btn_Off_RL4.TabIndex = 7;
            this.btn_Off_RL4.Text = "RL4 off";
            this.btn_Off_RL4.UseVisualStyleBackColor = true;
            this.btn_Off_RL4.Click += new System.EventHandler(this.btn_Off_RL4_Click);
            // 
            // btn_On_RL4
            // 
            this.btn_On_RL4.Location = new System.Drawing.Point(20, 153);
            this.btn_On_RL4.Name = "btn_On_RL4";
            this.btn_On_RL4.Size = new System.Drawing.Size(80, 30);
            this.btn_On_RL4.TabIndex = 6;
            this.btn_On_RL4.Text = "RL4 on";
            this.btn_On_RL4.UseVisualStyleBackColor = true;
            this.btn_On_RL4.Click += new System.EventHandler(this.btn_On_RL4_Click);
            // 
            // btn_Off_RL3
            // 
            this.btn_Off_RL3.Location = new System.Drawing.Point(133, 113);
            this.btn_Off_RL3.Name = "btn_Off_RL3";
            this.btn_Off_RL3.Size = new System.Drawing.Size(80, 30);
            this.btn_Off_RL3.TabIndex = 5;
            this.btn_Off_RL3.Text = "RL3 off";
            this.btn_Off_RL3.UseVisualStyleBackColor = true;
            this.btn_Off_RL3.Click += new System.EventHandler(this.btn_Off_RL3_Click);
            // 
            // btn_On_RL3
            // 
            this.btn_On_RL3.Location = new System.Drawing.Point(20, 112);
            this.btn_On_RL3.Name = "btn_On_RL3";
            this.btn_On_RL3.Size = new System.Drawing.Size(80, 30);
            this.btn_On_RL3.TabIndex = 4;
            this.btn_On_RL3.Text = "RL3 on";
            this.btn_On_RL3.UseVisualStyleBackColor = true;
            this.btn_On_RL3.Click += new System.EventHandler(this.btn_On_RL3_Click);
            // 
            // btn_Off_RL2
            // 
            this.btn_Off_RL2.Location = new System.Drawing.Point(132, 72);
            this.btn_Off_RL2.Name = "btn_Off_RL2";
            this.btn_Off_RL2.Size = new System.Drawing.Size(80, 30);
            this.btn_Off_RL2.TabIndex = 3;
            this.btn_Off_RL2.Text = "RL2 off";
            this.btn_Off_RL2.UseVisualStyleBackColor = true;
            this.btn_Off_RL2.Click += new System.EventHandler(this.btn_Off_RL2_Click);
            // 
            // btn_On_RL2
            // 
            this.btn_On_RL2.Location = new System.Drawing.Point(20, 71);
            this.btn_On_RL2.Name = "btn_On_RL2";
            this.btn_On_RL2.Size = new System.Drawing.Size(80, 30);
            this.btn_On_RL2.TabIndex = 2;
            this.btn_On_RL2.Text = "RL2 on";
            this.btn_On_RL2.UseVisualStyleBackColor = true;
            this.btn_On_RL2.Click += new System.EventHandler(this.btn_On_RL2_Click);
            // 
            // btn_Off_RL1
            // 
            this.btn_Off_RL1.Location = new System.Drawing.Point(133, 31);
            this.btn_Off_RL1.Name = "btn_Off_RL1";
            this.btn_Off_RL1.Size = new System.Drawing.Size(80, 30);
            this.btn_Off_RL1.TabIndex = 1;
            this.btn_Off_RL1.Text = "RL1 off";
            this.btn_Off_RL1.UseVisualStyleBackColor = true;
            this.btn_Off_RL1.Click += new System.EventHandler(this.btn_Off_RL1_Click);
            // 
            // btn_On_RL1
            // 
            this.btn_On_RL1.Location = new System.Drawing.Point(20, 30);
            this.btn_On_RL1.Name = "btn_On_RL1";
            this.btn_On_RL1.Size = new System.Drawing.Size(80, 30);
            this.btn_On_RL1.TabIndex = 0;
            this.btn_On_RL1.Text = "RL1 on";
            this.btn_On_RL1.UseVisualStyleBackColor = true;
            this.btn_On_RL1.Click += new System.EventHandler(this.btn_On_RL1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_RL4_status);
            this.groupBox5.Controls.Add(this.lbl_RL3_status);
            this.groupBox5.Controls.Add(this.lbl_RL2_status);
            this.groupBox5.Controls.Add(this.lbl_RL1_status);
            this.groupBox5.Controls.Add(this.btn_Poll_RLstatus);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(560, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 240);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Relays status";
            // 
            // lbl_RL4_status
            // 
            this.lbl_RL4_status.BackColor = System.Drawing.Color.Yellow;
            this.lbl_RL4_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RL4_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_RL4_status.Location = new System.Drawing.Point(31, 194);
            this.lbl_RL4_status.Name = "lbl_RL4_status";
            this.lbl_RL4_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_RL4_status.TabIndex = 1;
            this.lbl_RL4_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RL3_status
            // 
            this.lbl_RL3_status.BackColor = System.Drawing.Color.Yellow;
            this.lbl_RL3_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RL3_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_RL3_status.Location = new System.Drawing.Point(31, 153);
            this.lbl_RL3_status.Name = "lbl_RL3_status";
            this.lbl_RL3_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_RL3_status.TabIndex = 1;
            this.lbl_RL3_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RL2_status
            // 
            this.lbl_RL2_status.BackColor = System.Drawing.Color.Yellow;
            this.lbl_RL2_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RL2_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_RL2_status.Location = new System.Drawing.Point(31, 112);
            this.lbl_RL2_status.Name = "lbl_RL2_status";
            this.lbl_RL2_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_RL2_status.TabIndex = 1;
            this.lbl_RL2_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RL1_status
            // 
            this.lbl_RL1_status.BackColor = System.Drawing.Color.Yellow;
            this.lbl_RL1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RL1_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_RL1_status.Location = new System.Drawing.Point(31, 71);
            this.lbl_RL1_status.Name = "lbl_RL1_status";
            this.lbl_RL1_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_RL1_status.TabIndex = 1;
            this.lbl_RL1_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Poll_RLstatus
            // 
            this.btn_Poll_RLstatus.Location = new System.Drawing.Point(31, 30);
            this.btn_Poll_RLstatus.Name = "btn_Poll_RLstatus";
            this.btn_Poll_RLstatus.Size = new System.Drawing.Size(80, 30);
            this.btn_Poll_RLstatus.TabIndex = 0;
            this.btn_Poll_RLstatus.Text = "Poll RL";
            this.btn_Poll_RLstatus.UseVisualStyleBackColor = true;
            this.btn_Poll_RLstatus.Click += new System.EventHandler(this.btn_Poll_RLstatus_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_IN4_status);
            this.groupBox6.Controls.Add(this.lbl_IN3_status);
            this.groupBox6.Controls.Add(this.lbl_IN2_status);
            this.groupBox6.Controls.Add(this.lbl_IN1_status);
            this.groupBox6.Controls.Add(this.btn_Poll_INstatus);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(720, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 240);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inputs status";
            // 
            // btn_Poll_INstatus
            // 
            this.btn_Poll_INstatus.Location = new System.Drawing.Point(30, 30);
            this.btn_Poll_INstatus.Name = "btn_Poll_INstatus";
            this.btn_Poll_INstatus.Size = new System.Drawing.Size(80, 30);
            this.btn_Poll_INstatus.TabIndex = 0;
            this.btn_Poll_INstatus.Text = "Poll IN";
            this.btn_Poll_INstatus.UseVisualStyleBackColor = true;
            this.btn_Poll_INstatus.Click += new System.EventHandler(this.btn_Poll_INstatus_Click);
            // 
            // lbl_IN1_status
            // 
            this.lbl_IN1_status.BackColor = System.Drawing.Color.Lime;
            this.lbl_IN1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IN1_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_IN1_status.Location = new System.Drawing.Point(30, 71);
            this.lbl_IN1_status.Name = "lbl_IN1_status";
            this.lbl_IN1_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_IN1_status.TabIndex = 1;
            this.lbl_IN1_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IN2_status
            // 
            this.lbl_IN2_status.BackColor = System.Drawing.Color.Lime;
            this.lbl_IN2_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IN2_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_IN2_status.Location = new System.Drawing.Point(30, 113);
            this.lbl_IN2_status.Name = "lbl_IN2_status";
            this.lbl_IN2_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_IN2_status.TabIndex = 1;
            this.lbl_IN2_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IN3_status
            // 
            this.lbl_IN3_status.BackColor = System.Drawing.Color.Lime;
            this.lbl_IN3_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IN3_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_IN3_status.Location = new System.Drawing.Point(30, 154);
            this.lbl_IN3_status.Name = "lbl_IN3_status";
            this.lbl_IN3_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_IN3_status.TabIndex = 1;
            this.lbl_IN3_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IN4_status
            // 
            this.lbl_IN4_status.BackColor = System.Drawing.Color.Lime;
            this.lbl_IN4_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IN4_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_IN4_status.Location = new System.Drawing.Point(30, 196);
            this.lbl_IN4_status.Name = "lbl_IN4_status";
            this.lbl_IN4_status.Size = new System.Drawing.Size(80, 30);
            this.lbl_IN4_status.TabIndex = 1;
            this.lbl_IN4_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Poll_all
            // 
            this.btn_Poll_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Poll_all.Location = new System.Drawing.Point(560, 20);
            this.btn_Poll_all.Name = "btn_Poll_all";
            this.btn_Poll_all.Size = new System.Drawing.Size(100, 30);
            this.btn_Poll_all.TabIndex = 6;
            this.btn_Poll_all.Text = "Polling all";
            this.btn_Poll_all.UseVisualStyleBackColor = true;
            this.btn_Poll_all.Click += new System.EventHandler(this.btn_Poll_all_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.Location = new System.Drawing.Point(680, 20);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(180, 30);
            this.progressBar2.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 371);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btn_Poll_all);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_parity;
        private System.Windows.Forms.ComboBox cbo_stop_bits;
        private System.Windows.Forms.ComboBox cbo_baudrate;
        private System.Windows.Forms.ComboBox cbo_port_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_data_bits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Set_address;
        private System.Windows.Forms.Button btn_Get_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_On_RL1;
        private System.Windows.Forms.Button btn_Off_RL1;
        private System.Windows.Forms.Button btn_Off_RL4;
        private System.Windows.Forms.Button btn_On_RL4;
        private System.Windows.Forms.Button btn_Off_RL3;
        private System.Windows.Forms.Button btn_On_RL3;
        private System.Windows.Forms.Button btn_Off_RL2;
        private System.Windows.Forms.Button btn_On_RL2;
        private System.Windows.Forms.TextBox txt_Set_address;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Poll_RLstatus;
        private System.Windows.Forms.Label lbl_RL4_status;
        private System.Windows.Forms.Label lbl_RL3_status;
        private System.Windows.Forms.Label lbl_RL2_status;
        private System.Windows.Forms.Label lbl_RL1_status;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_Poll_INstatus;
        private System.Windows.Forms.Label lbl_IN4_status;
        private System.Windows.Forms.Label lbl_IN3_status;
        private System.Windows.Forms.Label lbl_IN2_status;
        private System.Windows.Forms.Label lbl_IN1_status;
        private System.Windows.Forms.Button btn_Poll_all;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer2;
    }
}


namespace Gateway
{
    partial class Cloud
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UDP = new System.Windows.Forms.RadioButton();
            this.ModbusTCPClient = new System.Windows.Forms.RadioButton();
            this.TCPClient = new System.Windows.Forms.RadioButton();
            this.fire = new System.Windows.Forms.RadioButton();
            this.ModbusRTUClient = new System.Windows.Forms.RadioButton();
            this.Wifi = new System.Windows.Forms.RadioButton();
            this.CANopen = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1590, 758);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Wifi);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.ModbusRTUClient);
            this.groupBox1.Controls.Add(this.CANopen);
            this.groupBox1.Controls.Add(this.ModbusTCPClient);
            this.groupBox1.Controls.Add(this.fire);
            this.groupBox1.Controls.Add(this.UDP);
            this.groupBox1.Controls.Add(this.TCPClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1988, 948);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  云端连接  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "协议";
            // 
            // UDP
            // 
            this.UDP.AutoSize = true;
            this.UDP.Location = new System.Drawing.Point(647, 161);
            this.UDP.Name = "UDP";
            this.UDP.Size = new System.Drawing.Size(105, 44);
            this.UDP.TabIndex = 1;
            this.UDP.TabStop = true;
            this.UDP.Text = "UDP";
            this.UDP.UseVisualStyleBackColor = true;
            // 
            // ModbusTCPClient
            // 
            this.ModbusTCPClient.AutoSize = true;
            this.ModbusTCPClient.Location = new System.Drawing.Point(1013, 161);
            this.ModbusTCPClient.Name = "ModbusTCPClient";
            this.ModbusTCPClient.Size = new System.Drawing.Size(317, 44);
            this.ModbusTCPClient.TabIndex = 1;
            this.ModbusTCPClient.TabStop = true;
            this.ModbusTCPClient.Text = "Modbus TCPClient";
            this.ModbusTCPClient.UseVisualStyleBackColor = true;
            // 
            // TCPClient
            // 
            this.TCPClient.AutoSize = true;
            this.TCPClient.Location = new System.Drawing.Point(309, 161);
            this.TCPClient.Name = "TCPClient";
            this.TCPClient.Size = new System.Drawing.Size(183, 44);
            this.TCPClient.TabIndex = 1;
            this.TCPClient.TabStop = true;
            this.TCPClient.Text = "TCPClient";
            this.TCPClient.UseVisualStyleBackColor = true;
            // 
            // fire
            // 
            this.fire.AutoSize = true;
            this.fire.Location = new System.Drawing.Point(309, 270);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(95, 44);
            this.fire.TabIndex = 1;
            this.fire.TabStop = true;
            this.fire.Text = "485";
            this.fire.UseVisualStyleBackColor = true;
            // 
            // ModbusRTUClient
            // 
            this.ModbusRTUClient.AutoSize = true;
            this.ModbusRTUClient.Location = new System.Drawing.Point(647, 270);
            this.ModbusRTUClient.Name = "ModbusRTUClient";
            this.ModbusRTUClient.Size = new System.Drawing.Size(330, 44);
            this.ModbusRTUClient.TabIndex = 1;
            this.ModbusRTUClient.TabStop = true;
            this.ModbusRTUClient.Text = "Modbus RTU Client";
            this.ModbusRTUClient.UseVisualStyleBackColor = true;
            // 
            // Wifi
            // 
            this.Wifi.AutoSize = true;
            this.Wifi.Location = new System.Drawing.Point(1013, 270);
            this.Wifi.Name = "Wifi";
            this.Wifi.Size = new System.Drawing.Size(100, 44);
            this.Wifi.TabIndex = 1;
            this.Wifi.TabStop = true;
            this.Wifi.Text = "Wifi";
            this.Wifi.UseVisualStyleBackColor = true;
            // 
            // CANopen
            // 
            this.CANopen.AutoSize = true;
            this.CANopen.Location = new System.Drawing.Point(309, 382);
            this.CANopen.Name = "CANopen";
            this.CANopen.Size = new System.Drawing.Size(325, 44);
            this.CANopen.TabIndex = 1;
            this.CANopen.TabStop = true;
            this.CANopen.Text = "CANopen Manager";
            this.CANopen.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(647, 384);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(330, 44);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Modbus RTU Client";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Cloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1590, 758);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cloud";
            this.Text = "Cloud";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Wifi;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton ModbusRTUClient;
        private System.Windows.Forms.RadioButton CANopen;
        private System.Windows.Forms.RadioButton ModbusTCPClient;
        private System.Windows.Forms.RadioButton fire;
        private System.Windows.Forms.RadioButton UDP;
        private System.Windows.Forms.RadioButton TCPClient;
        private System.Windows.Forms.Label label1;
    }
}
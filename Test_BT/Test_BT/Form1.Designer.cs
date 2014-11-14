namespace Test_BT
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnAlive = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnCloseCOM = new System.Windows.Forms.Button();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.ReadTimeout = 5000;
            this.serialPort.WriteTimeout = 5000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnAlive
            // 
            this.btnAlive.Location = new System.Drawing.Point(101, 12);
            this.btnAlive.Name = "btnAlive";
            this.btnAlive.Size = new System.Drawing.Size(86, 32);
            this.btnAlive.TabIndex = 0;
            this.btnAlive.Text = "Alive";
            this.btnAlive.UseVisualStyleBackColor = true;
            this.btnAlive.Click += new System.EventHandler(this.btnAlive_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 50);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(265, 200);
            this.txtLog.TabIndex = 1;
            // 
            // btnCloseCOM
            // 
            this.btnCloseCOM.Location = new System.Drawing.Point(190, 12);
            this.btnCloseCOM.Name = "btnCloseCOM";
            this.btnCloseCOM.Size = new System.Drawing.Size(86, 32);
            this.btnCloseCOM.TabIndex = 2;
            this.btnCloseCOM.Text = "Close COM";
            this.btnCloseCOM.UseVisualStyleBackColor = true;
            this.btnCloseCOM.Click += new System.EventHandler(this.btnCloseCOM_Click);
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.Location = new System.Drawing.Point(12, 12);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(86, 32);
            this.btnOpenCOM.TabIndex = 3;
            this.btnOpenCOM.Text = "Open COM";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.btnOpenCOM);
            this.Controls.Add(this.btnCloseCOM);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAlive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnAlive;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCloseCOM;
        private System.Windows.Forms.Button btnOpenCOM;
    }
}


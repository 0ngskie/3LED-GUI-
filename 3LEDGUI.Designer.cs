namespace ArduinoActivity01
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
            this.redLEDButton = new System.Windows.Forms.Button();
            this.blueLEDButton = new System.Windows.Forms.Button();
            this.yellowLEDButton = new System.Windows.Forms.Button();
            this.redOFF = new System.Windows.Forms.Button();
            this.blueOFF = new System.Windows.Forms.Button();
            this.yellowOFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // redLEDButton
            // 
            this.redLEDButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.redLEDButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redLEDButton.Location = new System.Drawing.Point(114, 177);
            this.redLEDButton.Name = "redLEDButton";
            this.redLEDButton.Size = new System.Drawing.Size(113, 56);
            this.redLEDButton.TabIndex = 0;
            this.redLEDButton.Text = "Red";
            this.redLEDButton.UseVisualStyleBackColor = false;
            this.redLEDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // blueLEDButton
            // 
            this.blueLEDButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blueLEDButton.Location = new System.Drawing.Point(586, 177);
            this.blueLEDButton.Name = "blueLEDButton";
            this.blueLEDButton.Size = new System.Drawing.Size(113, 56);
            this.blueLEDButton.TabIndex = 1;
            this.blueLEDButton.Text = "Blue";
            this.blueLEDButton.UseVisualStyleBackColor = true;
            this.blueLEDButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // yellowLEDButton
            // 
            this.yellowLEDButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yellowLEDButton.Location = new System.Drawing.Point(357, 177);
            this.yellowLEDButton.Name = "yellowLEDButton";
            this.yellowLEDButton.Size = new System.Drawing.Size(113, 56);
            this.yellowLEDButton.TabIndex = 2;
            this.yellowLEDButton.Text = "Yellow";
            this.yellowLEDButton.UseVisualStyleBackColor = true;
            this.yellowLEDButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // redOFF
            // 
            this.redOFF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redOFF.Location = new System.Drawing.Point(114, 263);
            this.redOFF.Name = "redOFF";
            this.redOFF.Size = new System.Drawing.Size(113, 56);
            this.redOFF.TabIndex = 3;
            this.redOFF.Text = "OFF";
            this.redOFF.UseVisualStyleBackColor = true;
            this.redOFF.Click += new System.EventHandler(this.button4_Click);
            // 
            // blueOFF
            // 
            this.blueOFF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blueOFF.Location = new System.Drawing.Point(357, 263);
            this.blueOFF.Name = "blueOFF";
            this.blueOFF.Size = new System.Drawing.Size(113, 56);
            this.blueOFF.TabIndex = 4;
            this.blueOFF.Text = "OFF";
            this.blueOFF.UseVisualStyleBackColor = true;
            this.blueOFF.Click += new System.EventHandler(this.button5_Click);
            // 
            // yellowOFF
            // 
            this.yellowOFF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yellowOFF.Location = new System.Drawing.Point(586, 263);
            this.yellowOFF.Name = "yellowOFF";
            this.yellowOFF.Size = new System.Drawing.Size(113, 56);
            this.yellowOFF.TabIndex = 5;
            this.yellowOFF.Text = "OFF";
            this.yellowOFF.UseVisualStyleBackColor = true;
            this.yellowOFF.Click += new System.EventHandler(this.button6_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yellowOFF);
            this.Controls.Add(this.blueOFF);
            this.Controls.Add(this.redOFF);
            this.Controls.Add(this.yellowLEDButton);
            this.Controls.Add(this.blueLEDButton);
            this.Controls.Add(this.redLEDButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redLEDButton;
        private System.Windows.Forms.Button blueLEDButton;
        private System.Windows.Forms.Button yellowLEDButton;
        private System.Windows.Forms.Button redOFF;
        private System.Windows.Forms.Button blueOFF;
        private System.Windows.Forms.Button yellowOFF;
        private System.IO.Ports.SerialPort serialPort1;
    }
}


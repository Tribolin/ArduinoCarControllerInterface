namespace Arduino_Auto_ControllerBluet
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Supmit = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.schneller = new System.Windows.Forms.Button();
            this.langsamer = new System.Windows.Forms.Button();
            this.Horn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "forward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 116);
            this.button2.TabIndex = 2;
            this.button2.Text = "backward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 128);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 114);
            this.button3.TabIndex = 3;
            this.button3.Text = "left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 114);
            this.button4.TabIndex = 4;
            this.button4.Text = "right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // PortNameInput
            // 
            this.PortNameInput.Location = new System.Drawing.Point(16, 404);
            this.PortNameInput.Name = "PortNameInput";
            this.PortNameInput.Size = new System.Drawing.Size(196, 22);
            this.PortNameInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // Supmit
            // 
            this.Supmit.Location = new System.Drawing.Point(16, 432);
            this.Supmit.Name = "Supmit";
            this.Supmit.Size = new System.Drawing.Size(94, 23);
            this.Supmit.TabIndex = 8;
            this.Supmit.Text = "change Port";
            this.Supmit.UseVisualStyleBackColor = true;
            this.Supmit.Click += new System.EventHandler(this.Supmit_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(117, 431);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(95, 23);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            // 
            // schneller
            // 
            this.schneller.Location = new System.Drawing.Point(19, 13);
            this.schneller.Name = "schneller";
            this.schneller.Size = new System.Drawing.Size(99, 23);
            this.schneller.TabIndex = 10;
            this.schneller.Text = "schneller";
            this.schneller.UseVisualStyleBackColor = true;
            this.schneller.Click += new System.EventHandler(this.schneller_Click);
            // 
            // langsamer
            // 
            this.langsamer.Location = new System.Drawing.Point(19, 43);
            this.langsamer.Name = "langsamer";
            this.langsamer.Size = new System.Drawing.Size(99, 23);
            this.langsamer.TabIndex = 11;
            this.langsamer.Text = "langsamer";
            this.langsamer.UseVisualStyleBackColor = true;
            this.langsamer.Click += new System.EventHandler(this.langsamer_Click);
            // 
            // Horn
            // 
            this.Horn.Location = new System.Drawing.Point(468, 12);
            this.Horn.Name = "Horn";
            this.Horn.Size = new System.Drawing.Size(89, 23);
            this.Horn.TabIndex = 12;
            this.Horn.Text = "Horn";
            this.Horn.UseVisualStyleBackColor = true;
            this.Horn.Click += new System.EventHandler(this.Horn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 554);
            this.Controls.Add(this.Horn);
            this.Controls.Add(this.langsamer);
            this.Controls.Add(this.schneller);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Supmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortNameInput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox PortNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Supmit;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button schneller;
        private System.Windows.Forms.Button langsamer;
        private System.Windows.Forms.Button Horn;
    }
}


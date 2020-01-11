namespace ArmFrontEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.opCodeTB = new System.Windows.Forms.TextBox();
            this.dataLengthTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parametersTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendB = new System.Windows.Forms.Button();
            this.consoleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rawCommandTB = new System.Windows.Forms.TextBox();
            this.rawSendB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.echoTB = new System.Windows.Forms.TextBox();
            this.echoB = new System.Windows.Forms.Button();
            this.Servo = new System.Windows.Forms.Label();
            this.servoNumTB = new System.Windows.Forms.TextBox();
            this.servoPosTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.servoB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Op Code";
            // 
            // opCodeTB
            // 
            this.opCodeTB.Location = new System.Drawing.Point(16, 30);
            this.opCodeTB.Name = "opCodeTB";
            this.opCodeTB.Size = new System.Drawing.Size(64, 20);
            this.opCodeTB.TabIndex = 1;
            // 
            // dataLengthTB
            // 
            this.dataLengthTB.Enabled = false;
            this.dataLengthTB.Location = new System.Drawing.Point(105, 30);
            this.dataLengthTB.Name = "dataLengthTB";
            this.dataLengthTB.ReadOnly = true;
            this.dataLengthTB.Size = new System.Drawing.Size(82, 20);
            this.dataLengthTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Length";
            // 
            // parametersTB
            // 
            this.parametersTB.Location = new System.Drawing.Point(208, 30);
            this.parametersTB.Name = "parametersTB";
            this.parametersTB.Size = new System.Drawing.Size(417, 20);
            this.parametersTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parameters";
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(631, 30);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(98, 20);
            this.sendB.TabIndex = 6;
            this.sendB.Text = "Send";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // consoleTB
            // 
            this.consoleTB.Location = new System.Drawing.Point(16, 374);
            this.consoleTB.Multiline = true;
            this.consoleTB.Name = "consoleTB";
            this.consoleTB.ReadOnly = true;
            this.consoleTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTB.Size = new System.Drawing.Size(713, 187);
            this.consoleTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Console";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Raw Command";
            // 
            // rawCommandTB
            // 
            this.rawCommandTB.Location = new System.Drawing.Point(16, 73);
            this.rawCommandTB.Name = "rawCommandTB";
            this.rawCommandTB.Size = new System.Drawing.Size(609, 20);
            this.rawCommandTB.TabIndex = 10;
            // 
            // rawSendB
            // 
            this.rawSendB.Location = new System.Drawing.Point(631, 73);
            this.rawSendB.Name = "rawSendB";
            this.rawSendB.Size = new System.Drawing.Size(98, 20);
            this.rawSendB.TabIndex = 11;
            this.rawSendB.Text = "Send";
            this.rawSendB.UseVisualStyleBackColor = true;
            this.rawSendB.Click += new System.EventHandler(this.Send_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Echo";
            // 
            // echoTB
            // 
            this.echoTB.Location = new System.Drawing.Point(16, 117);
            this.echoTB.Name = "echoTB";
            this.echoTB.Size = new System.Drawing.Size(609, 20);
            this.echoTB.TabIndex = 13;
            // 
            // echoB
            // 
            this.echoB.Location = new System.Drawing.Point(632, 117);
            this.echoB.Name = "echoB";
            this.echoB.Size = new System.Drawing.Size(97, 20);
            this.echoB.TabIndex = 14;
            this.echoB.Text = "Send";
            this.echoB.UseVisualStyleBackColor = true;
            this.echoB.Click += new System.EventHandler(this.echoB_Click);
            // 
            // Servo
            // 
            this.Servo.AutoSize = true;
            this.Servo.Location = new System.Drawing.Point(16, 144);
            this.Servo.Name = "Servo";
            this.Servo.Size = new System.Drawing.Size(35, 13);
            this.Servo.TabIndex = 15;
            this.Servo.Text = "Servo";
            // 
            // servoNumTB
            // 
            this.servoNumTB.Location = new System.Drawing.Point(16, 161);
            this.servoNumTB.Name = "servoNumTB";
            this.servoNumTB.Size = new System.Drawing.Size(100, 20);
            this.servoNumTB.TabIndex = 16;
            // 
            // servoPosTB
            // 
            this.servoPosTB.Location = new System.Drawing.Point(123, 161);
            this.servoPosTB.Name = "servoPosTB";
            this.servoPosTB.Size = new System.Drawing.Size(100, 20);
            this.servoPosTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Position";
            // 
            // servoB
            // 
            this.servoB.Location = new System.Drawing.Point(230, 161);
            this.servoB.Name = "servoB";
            this.servoB.Size = new System.Drawing.Size(75, 20);
            this.servoB.TabIndex = 19;
            this.servoB.Text = "Send";
            this.servoB.UseVisualStyleBackColor = true;
            this.servoB.Click += new System.EventHandler(this.servoB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 573);
            this.Controls.Add(this.servoB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.servoPosTB);
            this.Controls.Add(this.servoNumTB);
            this.Controls.Add(this.Servo);
            this.Controls.Add(this.echoB);
            this.Controls.Add(this.echoTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rawSendB);
            this.Controls.Add(this.rawCommandTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.consoleTB);
            this.Controls.Add(this.sendB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parametersTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataLengthTB);
            this.Controls.Add(this.opCodeTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opCodeTB;
        private System.Windows.Forms.TextBox dataLengthTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parametersTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendB;
        private System.Windows.Forms.TextBox consoleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rawCommandTB;
        private System.Windows.Forms.Button rawSendB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox echoTB;
        private System.Windows.Forms.Button echoB;
        private System.Windows.Forms.Label Servo;
        private System.Windows.Forms.TextBox servoNumTB;
        private System.Windows.Forms.TextBox servoPosTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button servoB;
    }
}


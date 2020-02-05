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
			this.label8 = new System.Windows.Forms.Label();
			this.ledModeCB = new System.Windows.Forms.ComboBox();
			this.ledPaletteCB = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ledB = new System.Windows.Forms.Button();
			this.ledOnB = new System.Windows.Forms.Button();
			this.ledOffB = new System.Windows.Forms.Button();
			this.pNameTB = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.paletteEntriesLB = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.addColorB = new System.Windows.Forms.Button();
			this.pStepUD = new System.Windows.Forms.NumericUpDown();
			this.pRUD = new System.Windows.Forms.NumericUpDown();
			this.pGUD = new System.Windows.Forms.NumericUpDown();
			this.pBUD = new System.Windows.Forms.NumericUpDown();
			this.newPaletteB = new System.Windows.Forms.Button();
			this.currentColorP = new System.Windows.Forms.Panel();
			this.ledSpeedUD = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.ledColorPicker = new System.Windows.Forms.ColorDialog();
			this.ledColorSelectB = new System.Windows.Forms.Button();
			this.gradientP = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pStepUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pGUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledSpeedUD)).BeginInit();
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
			this.consoleTB.Location = new System.Drawing.Point(12, 418);
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
			this.label4.Location = new System.Drawing.Point(12, 402);
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
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(19, 188);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "LED Mode";
			// 
			// ledModeCB
			// 
			this.ledModeCB.FormattingEnabled = true;
			this.ledModeCB.Items.AddRange(new object[] {
            "Spin",
            "Ico Rainbow",
            "Ico Palette",
            "Juggle",
            "Juggle Palette",
            "Juggle Up and Down",
            "Confetti",
            "Confetti Palette",
            "Debug"});
			this.ledModeCB.Location = new System.Drawing.Point(16, 204);
			this.ledModeCB.Name = "ledModeCB";
			this.ledModeCB.Size = new System.Drawing.Size(100, 21);
			this.ledModeCB.TabIndex = 21;
			// 
			// ledPaletteCB
			// 
			this.ledPaletteCB.DisplayMember = "Name";
			this.ledPaletteCB.FormattingEnabled = true;
			this.ledPaletteCB.Location = new System.Drawing.Point(126, 204);
			this.ledPaletteCB.Name = "ledPaletteCB";
			this.ledPaletteCB.Size = new System.Drawing.Size(121, 21);
			this.ledPaletteCB.TabIndex = 22;
			this.ledPaletteCB.ValueMember = "Name";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(123, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Palette";
			// 
			// ledB
			// 
			this.ledB.Location = new System.Drawing.Point(388, 204);
			this.ledB.Name = "ledB";
			this.ledB.Size = new System.Drawing.Size(75, 23);
			this.ledB.TabIndex = 24;
			this.ledB.Text = "Send";
			this.ledB.UseVisualStyleBackColor = true;
			this.ledB.Click += new System.EventHandler(this.ledB_Click);
			// 
			// ledOnB
			// 
			this.ledOnB.Location = new System.Drawing.Point(572, 202);
			this.ledOnB.Name = "ledOnB";
			this.ledOnB.Size = new System.Drawing.Size(75, 23);
			this.ledOnB.TabIndex = 25;
			this.ledOnB.Text = "On";
			this.ledOnB.UseVisualStyleBackColor = true;
			this.ledOnB.Click += new System.EventHandler(this.ledOnB_Click);
			// 
			// ledOffB
			// 
			this.ledOffB.Location = new System.Drawing.Point(654, 202);
			this.ledOffB.Name = "ledOffB";
			this.ledOffB.Size = new System.Drawing.Size(75, 23);
			this.ledOffB.TabIndex = 26;
			this.ledOffB.Text = "Off";
			this.ledOffB.UseVisualStyleBackColor = true;
			this.ledOffB.Click += new System.EventHandler(this.ledOffB_Click);
			// 
			// pNameTB
			// 
			this.pNameTB.Location = new System.Drawing.Point(57, 263);
			this.pNameTB.Name = "pNameTB";
			this.pNameTB.Size = new System.Drawing.Size(190, 20);
			this.pNameTB.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 266);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 28;
			this.label10.Text = "Name";
			// 
			// paletteEntriesLB
			// 
			this.paletteEntriesLB.DisplayMember = "Name";
			this.paletteEntriesLB.FormattingEnabled = true;
			this.paletteEntriesLB.Location = new System.Drawing.Point(254, 289);
			this.paletteEntriesLB.Name = "paletteEntriesLB";
			this.paletteEntriesLB.Size = new System.Drawing.Size(177, 95);
			this.paletteEntriesLB.TabIndex = 29;
			this.paletteEntriesLB.ValueMember = "Name";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(19, 293);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 33;
			this.label11.Text = "Step";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(33, 320);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(15, 13);
			this.label12.TabIndex = 34;
			this.label12.Text = "R";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(33, 347);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(15, 13);
			this.label13.TabIndex = 36;
			this.label13.Text = "G";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(33, 374);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(14, 13);
			this.label14.TabIndex = 37;
			this.label14.Text = "B";
			// 
			// addColorB
			// 
			this.addColorB.Location = new System.Drawing.Point(172, 289);
			this.addColorB.Name = "addColorB";
			this.addColorB.Size = new System.Drawing.Size(75, 23);
			this.addColorB.TabIndex = 38;
			this.addColorB.Text = "Add";
			this.addColorB.UseVisualStyleBackColor = true;
			this.addColorB.Click += new System.EventHandler(this.addColorB_Click);
			// 
			// pStepUD
			// 
			this.pStepUD.Location = new System.Drawing.Point(57, 291);
			this.pStepUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.pStepUD.Name = "pStepUD";
			this.pStepUD.Size = new System.Drawing.Size(88, 20);
			this.pStepUD.TabIndex = 39;
			// 
			// pRUD
			// 
			this.pRUD.Location = new System.Drawing.Point(57, 318);
			this.pRUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.pRUD.Name = "pRUD";
			this.pRUD.Size = new System.Drawing.Size(88, 20);
			this.pRUD.TabIndex = 40;
			// 
			// pGUD
			// 
			this.pGUD.Location = new System.Drawing.Point(57, 345);
			this.pGUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.pGUD.Name = "pGUD";
			this.pGUD.Size = new System.Drawing.Size(88, 20);
			this.pGUD.TabIndex = 41;
			// 
			// pBUD
			// 
			this.pBUD.Location = new System.Drawing.Point(57, 372);
			this.pBUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.pBUD.Name = "pBUD";
			this.pBUD.Size = new System.Drawing.Size(88, 20);
			this.pBUD.TabIndex = 42;
			// 
			// newPaletteB
			// 
			this.newPaletteB.Location = new System.Drawing.Point(254, 261);
			this.newPaletteB.Name = "newPaletteB";
			this.newPaletteB.Size = new System.Drawing.Size(75, 23);
			this.newPaletteB.TabIndex = 43;
			this.newPaletteB.Text = "New";
			this.newPaletteB.UseVisualStyleBackColor = true;
			this.newPaletteB.Click += new System.EventHandler(this.savePaletteB_Click);
			// 
			// currentColorP
			// 
			this.currentColorP.Location = new System.Drawing.Point(172, 318);
			this.currentColorP.Name = "currentColorP";
			this.currentColorP.Size = new System.Drawing.Size(75, 59);
			this.currentColorP.TabIndex = 44;
			// 
			// ledSpeedUD
			// 
			this.ledSpeedUD.Location = new System.Drawing.Point(254, 204);
			this.ledSpeedUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.ledSpeedUD.Name = "ledSpeedUD";
			this.ledSpeedUD.Size = new System.Drawing.Size(75, 20);
			this.ledSpeedUD.TabIndex = 45;
			this.ledSpeedUD.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(254, 188);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(38, 13);
			this.label15.TabIndex = 46;
			this.label15.Text = "Speed";
			// 
			// ledColorSelectB
			// 
			this.ledColorSelectB.Location = new System.Drawing.Point(172, 384);
			this.ledColorSelectB.Name = "ledColorSelectB";
			this.ledColorSelectB.Size = new System.Drawing.Size(75, 23);
			this.ledColorSelectB.TabIndex = 47;
			this.ledColorSelectB.Text = "Color";
			this.ledColorSelectB.UseVisualStyleBackColor = true;
			this.ledColorSelectB.Click += new System.EventHandler(this.ledColorSelectB_Click);
			// 
			// gradientP
			// 
			this.gradientP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradientP.Location = new System.Drawing.Point(447, 289);
			this.gradientP.Name = "gradientP";
			this.gradientP.Size = new System.Drawing.Size(633, 103);
			this.gradientP.TabIndex = 48;
			this.gradientP.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientP_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 812);
			this.Controls.Add(this.gradientP);
			this.Controls.Add(this.ledColorSelectB);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.ledSpeedUD);
			this.Controls.Add(this.currentColorP);
			this.Controls.Add(this.newPaletteB);
			this.Controls.Add(this.pBUD);
			this.Controls.Add(this.pGUD);
			this.Controls.Add(this.pRUD);
			this.Controls.Add(this.pStepUD);
			this.Controls.Add(this.addColorB);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.paletteEntriesLB);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.pNameTB);
			this.Controls.Add(this.ledOffB);
			this.Controls.Add(this.ledOnB);
			this.Controls.Add(this.ledB);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ledPaletteCB);
			this.Controls.Add(this.ledModeCB);
			this.Controls.Add(this.label8);
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
			((System.ComponentModel.ISupportInitialize)(this.pStepUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pGUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledSpeedUD)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ledModeCB;
        private System.Windows.Forms.ComboBox ledPaletteCB;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button ledB;
		private System.Windows.Forms.Button ledOnB;
		private System.Windows.Forms.Button ledOffB;
		private System.Windows.Forms.TextBox pNameTB;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListBox paletteEntriesLB;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button addColorB;
		private System.Windows.Forms.NumericUpDown pStepUD;
		private System.Windows.Forms.NumericUpDown pRUD;
		private System.Windows.Forms.NumericUpDown pGUD;
		private System.Windows.Forms.NumericUpDown pBUD;
		private System.Windows.Forms.Button newPaletteB;
		private System.Windows.Forms.Panel currentColorP;
		private System.Windows.Forms.NumericUpDown ledSpeedUD;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ColorDialog ledColorPicker;
		private System.Windows.Forms.Button ledColorSelectB;
		private System.Windows.Forms.Panel gradientP;
	}
}


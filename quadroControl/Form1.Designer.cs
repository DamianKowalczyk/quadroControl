namespace quadroControl
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
            this.dataForSendingTxtBox = new System.Windows.Forms.TextBox();
            this.sentDataTextBox = new System.Windows.Forms.TextBox();
            this.offset1TrackBar = new System.Windows.Forms.TrackBar();
            this.EngineOffsetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offset1TextBox = new System.Windows.Forms.TextBox();
            this.offset2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.offset2TrackBar = new System.Windows.Forms.TrackBar();
            this.offset3TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.offset3TrackBar = new System.Windows.Forms.TrackBar();
            this.offset4TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.offset4TrackBar = new System.Windows.Forms.TrackBar();
            this.setOffsetButton = new System.Windows.Forms.Button();
            this.setPowerTrackBar = new System.Windows.Forms.TrackBar();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.setPowerButton = new System.Windows.Forms.Button();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.offset1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset3TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset4TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPowerTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataForSendingTxtBox
            // 
            this.dataForSendingTxtBox.Location = new System.Drawing.Point(16, 122);
            this.dataForSendingTxtBox.Name = "dataForSendingTxtBox";
            this.dataForSendingTxtBox.Size = new System.Drawing.Size(148, 20);
            this.dataForSendingTxtBox.TabIndex = 0;
            this.dataForSendingTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sentDataTextBox
            // 
            this.sentDataTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.sentDataTextBox.Location = new System.Drawing.Point(16, 148);
            this.sentDataTextBox.Multiline = true;
            this.sentDataTextBox.Name = "sentDataTextBox";
            this.sentDataTextBox.Size = new System.Drawing.Size(148, 43);
            this.sentDataTextBox.TabIndex = 1;
            // 
            // offset1TrackBar
            // 
            this.offset1TrackBar.Location = new System.Drawing.Point(16, 247);
            this.offset1TrackBar.Maximum = 100;
            this.offset1TrackBar.Name = "offset1TrackBar";
            this.offset1TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offset1TrackBar.Size = new System.Drawing.Size(45, 224);
            this.offset1TrackBar.TabIndex = 2;
            // 
            // EngineOffsetLabel
            // 
            this.EngineOffsetLabel.AutoSize = true;
            this.EngineOffsetLabel.Location = new System.Drawing.Point(13, 205);
            this.EngineOffsetLabel.Name = "EngineOffsetLabel";
            this.EngineOffsetLabel.Size = new System.Drawing.Size(69, 13);
            this.EngineOffsetLabel.TabIndex = 3;
            this.EngineOffsetLabel.Text = "Engine offset";
            this.EngineOffsetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // offset1TextBox
            // 
            this.offset1TextBox.Location = new System.Drawing.Point(16, 477);
            this.offset1TextBox.Name = "offset1TextBox";
            this.offset1TextBox.Size = new System.Drawing.Size(45, 20);
            this.offset1TextBox.TabIndex = 5;
            this.offset1TextBox.Text = "0,00%";
            this.offset1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // offset2TextBox
            // 
            this.offset2TextBox.Location = new System.Drawing.Point(67, 477);
            this.offset2TextBox.Name = "offset2TextBox";
            this.offset2TextBox.Size = new System.Drawing.Size(45, 20);
            this.offset2TextBox.TabIndex = 8;
            this.offset2TextBox.Text = "0,00%";
            this.offset2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "2";
            // 
            // offset2TrackBar
            // 
            this.offset2TrackBar.Location = new System.Drawing.Point(67, 247);
            this.offset2TrackBar.Maximum = 100;
            this.offset2TrackBar.Name = "offset2TrackBar";
            this.offset2TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offset2TrackBar.Size = new System.Drawing.Size(45, 224);
            this.offset2TrackBar.TabIndex = 6;
            // 
            // offset3TextBox
            // 
            this.offset3TextBox.Location = new System.Drawing.Point(118, 477);
            this.offset3TextBox.Name = "offset3TextBox";
            this.offset3TextBox.Size = new System.Drawing.Size(45, 20);
            this.offset3TextBox.TabIndex = 11;
            this.offset3TextBox.Text = "0,00%";
            this.offset3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "3";
            // 
            // offset3TrackBar
            // 
            this.offset3TrackBar.Location = new System.Drawing.Point(118, 247);
            this.offset3TrackBar.Maximum = 100;
            this.offset3TrackBar.Name = "offset3TrackBar";
            this.offset3TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offset3TrackBar.Size = new System.Drawing.Size(45, 224);
            this.offset3TrackBar.TabIndex = 9;
            // 
            // offset4TextBox
            // 
            this.offset4TextBox.Location = new System.Drawing.Point(169, 477);
            this.offset4TextBox.Name = "offset4TextBox";
            this.offset4TextBox.Size = new System.Drawing.Size(45, 20);
            this.offset4TextBox.TabIndex = 14;
            this.offset4TextBox.Text = "0,00%";
            this.offset4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "4";
            // 
            // offset4TrackBar
            // 
            this.offset4TrackBar.Location = new System.Drawing.Point(169, 247);
            this.offset4TrackBar.Maximum = 100;
            this.offset4TrackBar.Name = "offset4TrackBar";
            this.offset4TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offset4TrackBar.Size = new System.Drawing.Size(45, 224);
            this.offset4TrackBar.TabIndex = 12;
            // 
            // setOffsetButton
            // 
            this.setOffsetButton.Location = new System.Drawing.Point(139, 503);
            this.setOffsetButton.Name = "setOffsetButton";
            this.setOffsetButton.Size = new System.Drawing.Size(75, 23);
            this.setOffsetButton.TabIndex = 15;
            this.setOffsetButton.Text = "set";
            this.setOffsetButton.UseVisualStyleBackColor = true;
            // 
            // setPowerTrackBar
            // 
            this.setPowerTrackBar.Location = new System.Drawing.Point(16, 576);
            this.setPowerTrackBar.Maximum = 100;
            this.setPowerTrackBar.Name = "setPowerTrackBar";
            this.setPowerTrackBar.Size = new System.Drawing.Size(293, 45);
            this.setPowerTrackBar.TabIndex = 16;
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(16, 542);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(37, 13);
            this.PowerLabel.TabIndex = 17;
            this.PowerLabel.Text = "Power";
            // 
            // setPowerButton
            // 
            this.setPowerButton.Location = new System.Drawing.Point(234, 627);
            this.setPowerButton.Name = "setPowerButton";
            this.setPowerButton.Size = new System.Drawing.Size(75, 23);
            this.setPowerButton.TabIndex = 18;
            this.setPowerButton.Text = "set";
            this.setPowerButton.UseVisualStyleBackColor = true;
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(159, 627);
            this.powerTextBox.Multiline = true;
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(55, 23);
            this.powerTextBox.TabIndex = 19;
            this.powerTextBox.Text = "0,00%";
            this.powerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(196, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(93, 27);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(196, 45);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(93, 27);
            this.stopButton.TabIndex = 21;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(196, 119);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 22;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(283, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(283, 201);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(283, 224);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(283, 247);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(283, 270);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 27;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(283, 293);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 28;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 676);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.setPowerButton);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.setPowerTrackBar);
            this.Controls.Add(this.setOffsetButton);
            this.Controls.Add(this.offset4TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.offset4TrackBar);
            this.Controls.Add(this.offset3TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.offset3TrackBar);
            this.Controls.Add(this.offset2TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offset2TrackBar);
            this.Controls.Add(this.offset1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngineOffsetLabel);
            this.Controls.Add(this.offset1TrackBar);
            this.Controls.Add(this.sentDataTextBox);
            this.Controls.Add(this.dataForSendingTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offset1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset3TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset4TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPowerTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataForSendingTxtBox;
        private System.Windows.Forms.TextBox sentDataTextBox;
        private System.Windows.Forms.TrackBar offset1TrackBar;
        private System.Windows.Forms.Label EngineOffsetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offset1TextBox;
        private System.Windows.Forms.TextBox offset2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar offset2TrackBar;
        private System.Windows.Forms.TextBox offset3TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar offset3TrackBar;
        private System.Windows.Forms.TextBox offset4TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar offset4TrackBar;
        private System.Windows.Forms.Button setOffsetButton;
        private System.Windows.Forms.TrackBar setPowerTrackBar;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Button setPowerButton;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}


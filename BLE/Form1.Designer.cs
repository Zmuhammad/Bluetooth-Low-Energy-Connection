namespace BLE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lboxpaired = new ListBox();
            lblMessageBox = new Label();
            sbtnSend = new Button();
            btnStart = new Button();
            stxtStatus = new TextBox();
            label1 = new Label();
            label3 = new Label();
            stxtMessageBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stxtMessageBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lboxpaired);
            groupBox1.Controls.Add(lblMessageBox);
            groupBox1.Controls.Add(sbtnSend);
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(stxtStatus);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bluetooth Server";
            // 
            // lboxpaired
            // 
            lboxpaired.FormattingEnabled = true;
            lboxpaired.ItemHeight = 20;
            lboxpaired.Location = new Point(457, 47);
            lboxpaired.Name = "lboxpaired";
            lboxpaired.ScrollAlwaysVisible = true;
            lboxpaired.Size = new Size(174, 304);
            lboxpaired.TabIndex = 6;
            // 
            // lblMessageBox
            // 
            lblMessageBox.AutoSize = true;
            lblMessageBox.Location = new Point(6, 148);
            lblMessageBox.Name = "lblMessageBox";
            lblMessageBox.Size = new Size(96, 20);
            lblMessageBox.TabIndex = 5;
            lblMessageBox.Text = "Message box";
            // 
            // sbtnSend
            // 
            sbtnSend.Location = new Point(307, 338);
            sbtnSend.Name = "sbtnSend";
            sbtnSend.Size = new Size(94, 29);
            sbtnSend.TabIndex = 4;
            sbtnSend.Text = " Send ";
            sbtnSend.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(271, 26);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // stxtStatus
            // 
            stxtStatus.Location = new Point(25, 80);
            stxtStatus.Name = "stxtStatus";
            stxtStatus.Size = new Size(376, 27);
            stxtStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Status : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 23);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 1;
            label3.Text = "Paired Devices";
            // 
            // stxtMessageBox
            // 
            stxtMessageBox.Location = new Point(36, 181);
            stxtMessageBox.Multiline = true;
            stxtMessageBox.Name = "stxtMessageBox";
            stxtMessageBox.ScrollBars = ScrollBars.Vertical;
            stxtMessageBox.Size = new Size(365, 151);
            stxtMessageBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Server";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lboxpaired;
        private Label lblMessageBox;
        private Button sbtnSend;
        private Button btnStart;
        private TextBox stxtStatus;
        private Label label1;
        private Label label3;
        private TextBox stxtMessageBox;
    }
}

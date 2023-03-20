namespace Client
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
            lboxAvailabe = new ListBox();
            groupBox1 = new GroupBox();
            btnPair = new Button();
            ctxtMessageBox = new TextBox();
            label3 = new Label();
            lblMessageBox = new Label();
            cbtnSend = new Button();
            btnSearch = new Button();
            ctxtStatus = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lboxAvailabe
            // 
            lboxAvailabe.FormattingEnabled = true;
            lboxAvailabe.ItemHeight = 20;
            lboxAvailabe.Location = new Point(457, 47);
            lboxAvailabe.Name = "lboxAvailabe";
            lboxAvailabe.ScrollAlwaysVisible = true;
            lboxAvailabe.Size = new Size(174, 244);
            lboxAvailabe.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPair);
            groupBox1.Controls.Add(ctxtMessageBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lboxAvailabe);
            groupBox1.Controls.Add(lblMessageBox);
            groupBox1.Controls.Add(cbtnSend);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ctxtStatus);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 373);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bluetooth Client";
            // 
            // btnPair
            // 
            btnPair.Location = new Point(501, 312);
            btnPair.Name = "btnPair";
            btnPair.Size = new Size(130, 29);
            btnPair.TabIndex = 8;
            btnPair.Text = "Pair";
            btnPair.UseVisualStyleBackColor = true;
            btnPair.Click += btnPair_Click;
            // 
            // ctxtMessageBox
            // 
            ctxtMessageBox.Location = new Point(36, 181);
            ctxtMessageBox.Multiline = true;
            ctxtMessageBox.Name = "ctxtMessageBox";
            ctxtMessageBox.ScrollBars = ScrollBars.Vertical;
            ctxtMessageBox.Size = new Size(380, 151);
            ctxtMessageBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 23);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 1;
            label3.Text = "Available Devices";
            // 
            // lblMessageBox
            // 
            lblMessageBox.AutoSize = true;
            lblMessageBox.Location = new Point(6, 148);
            lblMessageBox.Name = "lblMessageBox";
            lblMessageBox.Size = new Size(103, 20);
            lblMessageBox.TabIndex = 5;
            lblMessageBox.Text = "Message box :";
            // 
            // cbtnSend
            // 
            cbtnSend.Location = new Point(322, 338);
            cbtnSend.Name = "cbtnSend";
            cbtnSend.Size = new Size(94, 29);
            cbtnSend.TabIndex = 4;
            cbtnSend.Text = "Send";
            cbtnSend.UseVisualStyleBackColor = true;
            cbtnSend.Click += cbtnSend_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(150, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search For Devices";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ctxtStatus
            // 
            ctxtStatus.Location = new Point(36, 80);
            ctxtStatus.Multiline = true;
            ctxtStatus.Name = "ctxtStatus";
            ctxtStatus.Size = new Size(380, 52);
            ctxtStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Status : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Client";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lboxAvailabe;
        private GroupBox groupBox1;
        private Button btnPair;
        private TextBox ctxtMessageBox;
        private Label label3;
        private Label lblMessageBox;
        private Button cbtnSend;
        private Button btnSearch;
        private TextBox ctxtStatus;
        private Label label1;
    }
}
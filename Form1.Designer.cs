namespace IBMGRX_Terminal
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
            this.OpenClose = new System.Windows.Forms.Button();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.BaudrateSelect = new System.Windows.Forms.ComboBox();
            this.textBox_rec = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenClose
            // 
            this.OpenClose.BackColor = System.Drawing.Color.DarkGray;
            this.OpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenClose.Location = new System.Drawing.Point(12, 114);
            this.OpenClose.Name = "OpenClose";
            this.OpenClose.Size = new System.Drawing.Size(132, 30);
            this.OpenClose.TabIndex = 0;
            this.OpenClose.Text = "CONNECT";
            this.OpenClose.UseVisualStyleBackColor = false;
            this.OpenClose.Click += new System.EventHandler(this.OpenClose_Click);
            // 
            // PortSelect
            // 
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.Location = new System.Drawing.Point(12, 56);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(132, 23);
            this.PortSelect.TabIndex = 1;
            this.PortSelect.Text = "SELECT PORT";
            this.PortSelect.Click += new System.EventHandler(this.PortSelect_Click);
            // 
            // BaudrateSelect
            // 
            this.BaudrateSelect.FormattingEnabled = true;
            this.BaudrateSelect.Items.AddRange(new object[] {
            "1200",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.BaudrateSelect.Location = new System.Drawing.Point(12, 85);
            this.BaudrateSelect.Name = "BaudrateSelect";
            this.BaudrateSelect.Size = new System.Drawing.Size(132, 23);
            this.BaudrateSelect.TabIndex = 2;
            this.BaudrateSelect.Text = "SELECT BAUDRATE";
            // 
            // textBox_rec
            // 
            this.textBox_rec.BackColor = System.Drawing.Color.Black;
            this.textBox_rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_rec.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_rec.ForeColor = System.Drawing.Color.White;
            this.textBox_rec.Location = new System.Drawing.Point(150, 35);
            this.textBox_rec.Multiline = true;
            this.textBox_rec.Name = "textBox_rec";
            this.textBox_rec.ReadOnly = true;
            this.textBox_rec.Size = new System.Drawing.Size(638, 345);
            this.textBox_rec.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "SAVE TO .TXT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox_send
            // 
            this.textBox_send.BackColor = System.Drawing.Color.Black;
            this.textBox_send.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_send.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_send.ForeColor = System.Drawing.Color.White;
            this.textBox_send.Location = new System.Drawing.Point(150, 388);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(557, 50);
            this.textBox_send.TabIndex = 6;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Location = new System.Drawing.Point(713, 386);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 52);
            this.SendBtn.TabIndex = 7;
            this.SendBtn.Text = "SEND";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(81, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "JUST A SERIAL TERMINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(661, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "DATETIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "-CHOOSE COMM-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_rec);
            this.Controls.Add(this.BaudrateSelect);
            this.Controls.Add(this.PortSelect);
            this.Controls.Add(this.OpenClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RND.11 TERMINAL";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenClose;
        private ComboBox PortSelect;
        private ComboBox BaudrateSelect;
        private TextBox textBox_rec;
        private Button button3;
        private TextBox textBox_send;
        private Button SendBtn;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
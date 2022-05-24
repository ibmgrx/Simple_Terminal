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
            this.components = new System.ComponentModel.Container();
            this.OpenClose = new System.Windows.Forms.Button();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.BaudrateSelect = new System.Windows.Forms.ComboBox();
            this.textBox_rec = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            "19200",
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
            this.textBox_rec.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_rec.ForeColor = System.Drawing.Color.White;
            this.textBox_rec.Location = new System.Drawing.Point(150, 35);
            this.textBox_rec.Multiline = true;
            this.textBox_rec.Name = "textBox_rec";
            this.textBox_rec.ReadOnly = true;
            this.textBox_rec.Size = new System.Drawing.Size(638, 345);
            this.textBox_rec.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(12, 150);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(63, 52);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "SAVE TO .TXT";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(81, 150);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(63, 52);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
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
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(615, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(43, 18);
            this.date.TabIndex = 10;
            this.date.Text = "DATE";
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(713, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(43, 18);
            this.time.TabIndex = 12;
            this.time.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "© RND.11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "v0.1.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox_rec);
            this.Controls.Add(this.BaudrateSelect);
            this.Controls.Add(this.PortSelect);
            this.Controls.Add(this.OpenClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "[ALWAYS ON TOP TERMINAL]";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenClose;
        private ComboBox PortSelect;
        private ComboBox BaudrateSelect;
        private TextBox textBox_rec;
        private Button SaveBtn;
        private TextBox textBox_send;
        private Button SendBtn;
        private Button ClearBtn;
        private Label label1;
        private Label date;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label time;
        private Label label2;
        private Label label4;
    }
}
namespace Kelime_Oyunu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.lblLetter8 = new System.Windows.Forms.Label();
            this.lblLetter9 = new System.Windows.Forms.Label();
            this.lblLetter10 = new System.Windows.Forms.Label();
            this.lblLetter11 = new System.Windows.Forms.Label();
            this.lblLetter12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLetter13 = new System.Windows.Forms.Label();
            this.lblLetter14 = new System.Windows.Forms.Label();
            this.lblLetter15 = new System.Windows.Forms.Label();
            this.lblLetter16 = new System.Windows.Forms.Label();
            this.lblLetter17 = new System.Windows.Forms.Label();
            this.lblLetter18 = new System.Windows.Forms.Label();
            this.lblLetter19 = new System.Windows.Forms.Label();
            this.lblLetter20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-316, -17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 68);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelime Oyunu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kelime_Oyunu.Properties.Resources.icons8_macos_minimize_30;
            this.pictureBox2.Location = new System.Drawing.Point(1251, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelime_Oyunu.Properties.Resources.icons8_cancel_32;
            this.pictureBox1.Location = new System.Drawing.Point(1292, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(75, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Oyunu Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(75, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Oyunu Bitir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(820, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(888, 604);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(888, 637);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(20, 23);
            this.lblSkor.TabIndex = 7;
            this.lblSkor.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(820, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Skor: ";
            // 
            // lblLetter1
            // 
            this.lblLetter1.AutoSize = true;
            this.lblLetter1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter1.ForeColor = System.Drawing.Color.Red;
            this.lblLetter1.Location = new System.Drawing.Point(499, 226);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(49, 45);
            this.lblLetter1.TabIndex = 8;
            this.lblLetter1.Text = "A";
            // 
            // lblLetter2
            // 
            this.lblLetter2.AutoSize = true;
            this.lblLetter2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter2.ForeColor = System.Drawing.Color.Blue;
            this.lblLetter2.Location = new System.Drawing.Point(562, 226);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(49, 45);
            this.lblLetter2.TabIndex = 9;
            this.lblLetter2.Text = "A";
            // 
            // lblLetter3
            // 
            this.lblLetter3.AutoSize = true;
            this.lblLetter3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLetter3.Location = new System.Drawing.Point(625, 226);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(49, 45);
            this.lblLetter3.TabIndex = 10;
            this.lblLetter3.Text = "A";
            // 
            // lblLetter4
            // 
            this.lblLetter4.AutoSize = true;
            this.lblLetter4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter4.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblLetter4.Location = new System.Drawing.Point(680, 226);
            this.lblLetter4.Name = "lblLetter4";
            this.lblLetter4.Size = new System.Drawing.Size(49, 45);
            this.lblLetter4.TabIndex = 11;
            this.lblLetter4.Text = "A";
            // 
            // lblLetter5
            // 
            this.lblLetter5.AutoSize = true;
            this.lblLetter5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter5.ForeColor = System.Drawing.Color.Olive;
            this.lblLetter5.Location = new System.Drawing.Point(735, 226);
            this.lblLetter5.Name = "lblLetter5";
            this.lblLetter5.Size = new System.Drawing.Size(49, 45);
            this.lblLetter5.TabIndex = 12;
            this.lblLetter5.Text = "A";
            // 
            // lblLetter6
            // 
            this.lblLetter6.AutoSize = true;
            this.lblLetter6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLetter6.Location = new System.Drawing.Point(499, 295);
            this.lblLetter6.Name = "lblLetter6";
            this.lblLetter6.Size = new System.Drawing.Size(49, 45);
            this.lblLetter6.TabIndex = 13;
            this.lblLetter6.Text = "A";
            // 
            // lblLetter7
            // 
            this.lblLetter7.AutoSize = true;
            this.lblLetter7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLetter7.Location = new System.Drawing.Point(562, 295);
            this.lblLetter7.Name = "lblLetter7";
            this.lblLetter7.Size = new System.Drawing.Size(49, 45);
            this.lblLetter7.TabIndex = 14;
            this.lblLetter7.Text = "A";
            // 
            // lblLetter8
            // 
            this.lblLetter8.AutoSize = true;
            this.lblLetter8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLetter8.Location = new System.Drawing.Point(625, 295);
            this.lblLetter8.Name = "lblLetter8";
            this.lblLetter8.Size = new System.Drawing.Size(49, 45);
            this.lblLetter8.TabIndex = 15;
            this.lblLetter8.Text = "A";
            // 
            // lblLetter9
            // 
            this.lblLetter9.AutoSize = true;
            this.lblLetter9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLetter9.Location = new System.Drawing.Point(680, 295);
            this.lblLetter9.Name = "lblLetter9";
            this.lblLetter9.Size = new System.Drawing.Size(49, 45);
            this.lblLetter9.TabIndex = 16;
            this.lblLetter9.Text = "A";
            // 
            // lblLetter10
            // 
            this.lblLetter10.AutoSize = true;
            this.lblLetter10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter10.ForeColor = System.Drawing.Color.Purple;
            this.lblLetter10.Location = new System.Drawing.Point(735, 295);
            this.lblLetter10.Name = "lblLetter10";
            this.lblLetter10.Size = new System.Drawing.Size(49, 45);
            this.lblLetter10.TabIndex = 17;
            this.lblLetter10.Text = "A";
            // 
            // lblLetter11
            // 
            this.lblLetter11.AutoSize = true;
            this.lblLetter11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter11.ForeColor = System.Drawing.Color.Blue;
            this.lblLetter11.Location = new System.Drawing.Point(499, 361);
            this.lblLetter11.Name = "lblLetter11";
            this.lblLetter11.Size = new System.Drawing.Size(49, 45);
            this.lblLetter11.TabIndex = 18;
            this.lblLetter11.Text = "A";
            // 
            // lblLetter12
            // 
            this.lblLetter12.AutoSize = true;
            this.lblLetter12.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter12.ForeColor = System.Drawing.Color.Maroon;
            this.lblLetter12.Location = new System.Drawing.Point(562, 361);
            this.lblLetter12.Name = "lblLetter12";
            this.lblLetter12.Size = new System.Drawing.Size(49, 45);
            this.lblLetter12.TabIndex = 19;
            this.lblLetter12.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tahmininiz: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(210, 518);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 36);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(155, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 74);
            this.button3.TabIndex = 22;
            this.button3.Text = "Kontrol Et";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(75, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 74);
            this.button4.TabIndex = 23;
            this.button4.Text = "Hakkımızda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kelime_Oyunu.Properties.Resources.cooltext417116825554531;
            this.pictureBox3.Location = new System.Drawing.Point(415, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(479, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // lblLetter13
            // 
            this.lblLetter13.AutoSize = true;
            this.lblLetter13.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter13.ForeColor = System.Drawing.Color.Black;
            this.lblLetter13.Location = new System.Drawing.Point(625, 358);
            this.lblLetter13.Name = "lblLetter13";
            this.lblLetter13.Size = new System.Drawing.Size(49, 45);
            this.lblLetter13.TabIndex = 25;
            this.lblLetter13.Text = "A";
            // 
            // lblLetter14
            // 
            this.lblLetter14.AutoSize = true;
            this.lblLetter14.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter14.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLetter14.Location = new System.Drawing.Point(680, 358);
            this.lblLetter14.Name = "lblLetter14";
            this.lblLetter14.Size = new System.Drawing.Size(49, 45);
            this.lblLetter14.TabIndex = 26;
            this.lblLetter14.Text = "A";
            // 
            // lblLetter15
            // 
            this.lblLetter15.AutoSize = true;
            this.lblLetter15.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter15.ForeColor = System.Drawing.Color.Peru;
            this.lblLetter15.Location = new System.Drawing.Point(735, 358);
            this.lblLetter15.Name = "lblLetter15";
            this.lblLetter15.Size = new System.Drawing.Size(49, 45);
            this.lblLetter15.TabIndex = 27;
            this.lblLetter15.Text = "A";
            // 
            // lblLetter16
            // 
            this.lblLetter16.AutoSize = true;
            this.lblLetter16.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter16.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblLetter16.Location = new System.Drawing.Point(499, 423);
            this.lblLetter16.Name = "lblLetter16";
            this.lblLetter16.Size = new System.Drawing.Size(49, 45);
            this.lblLetter16.TabIndex = 28;
            this.lblLetter16.Text = "A";
            // 
            // lblLetter17
            // 
            this.lblLetter17.AutoSize = true;
            this.lblLetter17.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter17.ForeColor = System.Drawing.Color.Cyan;
            this.lblLetter17.Location = new System.Drawing.Point(562, 423);
            this.lblLetter17.Name = "lblLetter17";
            this.lblLetter17.Size = new System.Drawing.Size(49, 45);
            this.lblLetter17.TabIndex = 29;
            this.lblLetter17.Text = "A";
            // 
            // lblLetter18
            // 
            this.lblLetter18.AutoSize = true;
            this.lblLetter18.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter18.ForeColor = System.Drawing.Color.Tomato;
            this.lblLetter18.Location = new System.Drawing.Point(625, 423);
            this.lblLetter18.Name = "lblLetter18";
            this.lblLetter18.Size = new System.Drawing.Size(49, 45);
            this.lblLetter18.TabIndex = 30;
            this.lblLetter18.Text = "A";
            // 
            // lblLetter19
            // 
            this.lblLetter19.AutoSize = true;
            this.lblLetter19.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter19.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLetter19.Location = new System.Drawing.Point(680, 423);
            this.lblLetter19.Name = "lblLetter19";
            this.lblLetter19.Size = new System.Drawing.Size(49, 45);
            this.lblLetter19.TabIndex = 31;
            this.lblLetter19.Text = "A";
            // 
            // lblLetter20
            // 
            this.lblLetter20.AutoSize = true;
            this.lblLetter20.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter20.ForeColor = System.Drawing.Color.Sienna;
            this.lblLetter20.Location = new System.Drawing.Point(735, 423);
            this.lblLetter20.Name = "lblLetter20";
            this.lblLetter20.Size = new System.Drawing.Size(49, 45);
            this.lblLetter20.TabIndex = 32;
            this.lblLetter20.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 700);
            this.Controls.Add(this.lblLetter20);
            this.Controls.Add(this.lblLetter19);
            this.Controls.Add(this.lblLetter18);
            this.Controls.Add(this.lblLetter17);
            this.Controls.Add(this.lblLetter16);
            this.Controls.Add(this.lblLetter15);
            this.Controls.Add(this.lblLetter14);
            this.Controls.Add(this.lblLetter13);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLetter12);
            this.Controls.Add(this.lblLetter11);
            this.Controls.Add(this.lblLetter10);
            this.Controls.Add(this.lblLetter9);
            this.Controls.Add(this.lblLetter8);
            this.Controls.Add(this.lblLetter7);
            this.Controls.Add(this.lblLetter6);
            this.Controls.Add(this.lblLetter5);
            this.Controls.Add(this.lblLetter4);
            this.Controls.Add(this.lblLetter3);
            this.Controls.Add(this.lblLetter2);
            this.Controls.Add(this.lblLetter1);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter4;
        private System.Windows.Forms.Label lblLetter5;
        private System.Windows.Forms.Label lblLetter6;
        private System.Windows.Forms.Label lblLetter7;
        private System.Windows.Forms.Label lblLetter8;
        private System.Windows.Forms.Label lblLetter9;
        private System.Windows.Forms.Label lblLetter10;
        private System.Windows.Forms.Label lblLetter11;
        private System.Windows.Forms.Label lblLetter12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblLetter13;
        private System.Windows.Forms.Label lblLetter14;
        private System.Windows.Forms.Label lblLetter15;
        private System.Windows.Forms.Label lblLetter16;
        private System.Windows.Forms.Label lblLetter17;
        private System.Windows.Forms.Label lblLetter18;
        private System.Windows.Forms.Label lblLetter19;
        private System.Windows.Forms.Label lblLetter20;
    }
}


namespace BookStoxkForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            ใส่ชื่อหนังสือ = new Label();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            หนัง = new Label();
            label6 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            label7 = new Label();
            label8 = new Label();
            button6 = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 69);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "ชื่อหนังสือ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(301, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // ใส่ชื่อหนังสือ
            // 
            ใส่ชื่อหนังสือ.AutoSize = true;
            ใส่ชื่อหนังสือ.Location = new Point(301, 57);
            ใส่ชื่อหนังสือ.Name = "ใส่ชื่อหนังสือ";
            ใส่ชื่อหนังสือ.Size = new Size(62, 15);
            ใส่ชื่อหนังสือ.TabIndex = 7;
            ใส่ชื่อหนังสือ.Text = "ใส่ชื่อหนังสือ";
            // 
            // button1
            // 
            button1.Location = new Point(418, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "ค้นหา";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 86);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "ลบ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(42, 212);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(281, 143);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // หนัง
            // 
            หนัง.AutoSize = true;
            หนัง.Location = new Point(42, 167);
            หนัง.Name = "หนัง";
            หนัง.Size = new Size(71, 15);
            หนัง.TabIndex = 11;
            หนัง.Text = "หนังสือทั้งหมด";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 27);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "เพิ่มหนังสือ";
            // 
            // button3
            // 
            button3.Location = new Point(188, 86);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 13;
            button3.Text = "เพิ่มข้อมูลหนังสือ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 340);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "จำนวนหนังสือ 0 เล่ม";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(348, 249);
            button4.Name = "button4";
            button4.Size = new Size(156, 73);
            button4.TabIndex = 15;
            button4.Text = "แสดงข้อมูลทั้งหมด";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(234, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(46, 23);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(399, 183);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(65, 23);
            textBox6.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 157);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 18;
            label5.Text = "ค้นหาจากลำดับในตาราง";
            // 
            // button5
            // 
            button5.Location = new Point(484, 183);
            button5.Name = "button5";
            button5.Size = new Size(114, 23);
            button5.TabIndex = 19;
            button5.Text = "แก้ไขข้อความในลำดับ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 130);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 20;
            label7.Text = "แก้ไขข้อมูล";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 157);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 21;
            label8.Text = "แก้ไขชื่อหนังสือ";
            // 
            // button6
            // 
            button6.Location = new Point(301, 183);
            button6.Name = "button6";
            button6.Size = new Size(92, 23);
            button6.TabIndex = 22;
            button6.Text = "ค้นหาในตาราง";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // timer
            // 
            timer.Interval = 60000;
            timer.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 375);
            Controls.Add(button6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(หนัง);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ใส่ชื่อหนังสือ);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BookStock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label ใส่ชื่อหนังสือ;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label หนัง;
        private Label label6;
        private Button button3;
        private Label label4;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Button button5;
        private Label label7;
        private Label label8;
        private Button button6;
        public System.Windows.Forms.Timer timer;
    }
}
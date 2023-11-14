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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            ใส่ชื่อหนังสือ = new Label();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            หนัง = new Label();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(313, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "ชื่อหนังสือ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 57);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 57);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "จำนวนหนังสือ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(534, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // ใส่ชื่อหนังสือ
            // 
            ใส่ชื่อหนังสือ.AutoSize = true;
            ใส่ชื่อหนังสือ.Location = new Point(534, 57);
            ใส่ชื่อหนังสือ.Name = "ใส่ชื่อหนังสือ";
            ใส่ชื่อหนังสือ.Size = new Size(62, 15);
            ใส่ชื่อหนังสือ.TabIndex = 7;
            ใส่ชื่อหนังสือ.Text = "ใส่ชื่อหนังสือ";
            // 
            // button1
            // 
            button1.Location = new Point(497, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "ค้นหา";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(591, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "ลบ";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 268);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(143, 192);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // หนัง
            // 
            หนัง.AutoSize = true;
            หนัง.Location = new Point(57, 223);
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
            button3.Location = new Point(172, 128);
            button3.Name = "button3";
            button3.Size = new Size(126, 23);
            button3.TabIndex = 13;
            button3.Text = "เพิ่มข้อมูลหนังสือ";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(หนัง);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ใส่ชื่อหนังสือ);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label ใส่ชื่อหนังสือ;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label หนัง;
        private Label label6;
        private Button button3;
    }
}
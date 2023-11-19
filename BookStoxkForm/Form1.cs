using BookStock;
using System.Windows.Forms;

namespace BookStoxkForm
{
    public partial class Form1 : Form
    {
        DoublyLinkedList y = new DoublyLinkedList();
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // Set the interval to 60 seconds (60,000 milliseconds)
            timer.Tick += timer1_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//name book
        {
        }

        private void button3_Click(object sender, EventArgs e)//button to Add data
        {
            y.add(textBox1.Text);
            label4.Text = "จำนวนหนังสือ " + y.size() + " เล่ม";
            timer.Start();
        }

        private void label4_Click(object sender, EventArgs e)//this must show how many data in list
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//text box to search
        {
        }

        private void button1_Click(object sender, EventArgs e)//button to search data only book name use conatains not math a textbox but use data memory
        {
            if (y.contains(textBox4.Text))
            {
                MessageBox.Show("มีหนังสือชื่อนี้อยู่ในระบบ");
            }
            else
            {
                MessageBox.Show("ไม่มีหนังสือชื่อนี้อยู่ในระบบ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y.remove(textBox4.Text);
            MessageBox.Show("ลบหนังสือชื่อ " + textBox4.Text + " แล้ว");
            label4.Text = "จำนวนหนังสือ " + y.size() + " เล่ม";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < y.size(); i++)
            {
                richTextBox1.Text += (i + 1) + " . " + y.get(i) + "\n";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox5.Text);
            textBox6.Text = "" + y.get(i - 1);
            //use Time to watch data
        }

        private void button5_Click(object sender, EventArgs e)
        {
            y.set(int.Parse(textBox5.Text) - 1, textBox6.Text);
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("ข้อมูลหนังสือที่เก่าที่สุดควรนำมาจำหน่าย คือ " + y.get(0));
        }
    }
}
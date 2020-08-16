using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text.Trim();
            string PassWord = textBox2.Text.Trim();

            if (UserName == "Lgx" && PassWord == "18552188755")
            {
                textBox3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                //密码或用户名错误
                MessageBox.Show("密码或用户名错误");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "自动换行")
            {
                textBox3.WordWrap = true;
                button3.Text = "取消自动换行";
            }
            else 
            {
                textBox3.WordWrap = false;
                button3.Text = "自动换行";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(@".\Note.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = textBox3.Text.Trim();
                byte[] buf = Encoding.Default.GetBytes(str);
                fileStream.Write(buf, 0, buf.Length);
            }
            MessageBox.Show("Save success!!!");
        }
    }
}

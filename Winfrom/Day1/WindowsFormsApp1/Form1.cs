using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you love me? memeda~ ");
            this.Close();   //关闭主窗体
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        /// 鼠标移进来时发生一个事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width; //获取当前活动窗体的边框值
            int y = this.ClientSize.Height; //获取当前活动窗体的高度值

            int XButton = x - button2.Width;    //button2活动的最大宽度值
            int YButton = y - button2.Height;   //button2活动的最大高度值

            Random random = new Random();
            /* 随机给button2 一个坐标，但是不能操主框体的范围 */
            button2.Location = new Point(random.Next(0, XButton), random.Next(0, YButton));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are fuck");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1); //跑马灯
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();  //获取当前时间

              //定时播放音乐
            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute == 5 && DateTime.Now.Second == 00)
            {
                //播放音乐
                SoundPlayer Music = new SoundPlayer();
                Music.SoundLocation = @".\姑娘我爱你.wav"; //加载播放路径
                Music.Play();   //开始播放
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();  //获取当前时间
        }
    }
}

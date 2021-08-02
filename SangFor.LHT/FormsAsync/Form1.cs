using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 多线程
        /// 多线程写法不难，用起来非常难，多年老司机，也经常掉坑。
        ///  多线程场景：用户注册发短信，发邮箱，写日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("同步单线程开始。。。");
            for (int i = 0; i < 5; i++)
            {
                this.DoSomething("单线程");
            }
            Console.WriteLine("同步单线程结束。。。");
        }

        private void DoSomething(string name)
        {
            int sum = 0;
            Console.WriteLine($"{name} 时间开始：{DateTime.Now}");
            for (int i = 0; i < 100000000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{name} 总和：{sum}");
        }

        /// <summary>
        /// 多线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("多线程开始");
            Action<string> action = new Action<string>(this.DoSomething);
            for (int i = 0; i < 5; i++)
            {
                action.BeginInvoke("多线程", null, null);
            }
            Console.WriteLine("多线程结束");
        }
    }
}

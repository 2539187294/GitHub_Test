using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.窗体应用.Model
{
    public class Dog
    {
        //狗的名字
        private string name;
        //位置
        private int position;
        //比赛的跑道长度，距离
        private readonly int distance;
        public Dog(string name , int distance)
        {
            this.name = name;
            this.distance = distance;
            this.position = 0;
        }

        public void Reset()
        {
            this.position = 0;
        }

        //3.事件

    }
}

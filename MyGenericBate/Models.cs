using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericBate
{
    public interface ISports
    {
        void Pingpang();
    }
    public interface IWork
    {
        void Work();
    }
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Hi()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Chinese : People, ISports, IWork
    {
        public void Pingpang()
        {
            Console.WriteLine("打乒乓球");
        }

        public void Work()
        {
            Console.WriteLine("正在工作");
        }
        public void SayHi()
        {
            Console.WriteLine("吃了么？");
        }
    }
    public class HuNan : Chinese
    {
        public string? ChangSa { get; set; }

        public void Play()
        {
            Console.WriteLine("出来耍啦");
        }
    }

    public class Japanese :  ISports
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Pingpang()
        {
            Console.WriteLine("打乒乓球");
        }
    }
}

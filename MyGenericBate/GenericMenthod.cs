using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericBate
{
    public static class GenericMenthod
    {
        /// 泛型方法；泛型是一种语法，就是在需要的地方使用；声明前使用<>包裹一个字符，字符标识着传进来类
        /// !T (R O U D)都可以
        public static void Show<T>(this T Value)//调用的时候确定传进来的参数类型,dll IL文件里(int )
        {
            Console.WriteLine($"这是老板的任务：{Value.GetType()}");
        }

        public static void ShowPeopleInfo(People people)
        {
            Console.WriteLine($"这是老板的任务:{people.Name}_{people.Id}");
            people.Hi();
            //people.Pingpang();
        }

        public static void ShowPeopleInfoObj(object people)
        {
            Console.WriteLine($"这是老板的任务:{((People)people).Name}_{((People)people).Id}");
        }
        /// <summary>
        /// where T class 基类约束=》约束T类型必须为一个类,限定为具体某一个类或者该类的子类
        /// 接口约束
        /// 构造约束 new()
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void ShowPeopleInfoGenericMenthod<T>(T people) where T : People, ISports, IWork, new()
        {
            Console.WriteLine($"这是老板的任务:{people.Name}_{people.Id}");
            people.Pingpang();
            people.Work();
        }
    }
    public class GenericClass<T> : IGenericInterface<T>
    {
        public T _T { get; set; }

        public T Get(T t)
        {
            return t;
        }
    }

    public interface IGenericInterface<T>
    {
        T Get(T t);
    }

    delegate void GenericDelegate<T>(T t);

    public class Foods : IGenericInterface<string>
    {
        public string Name { get; set; }

        public string Get(string t)
        {
            Console.WriteLine($"Get{t.GetType()}");
            return t;
        }
    }
}

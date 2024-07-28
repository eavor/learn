// See https://aka.ms/new-console-template for more information
using MyGenericBate;

Console.WriteLine("Hello, World!");


//1.引入泛型(原理) 泛型是一种"语法",.net 2.0 =》框架升级=》1.优化中间件(IL文件)编译生成-机器码； 

//2.泛型好处同一个方法，不同类型参数 使用同一套方法代码处理=》好几个方法=》代码重复=》 泛型


//4.泛型类,泛型方法，泛型接口，泛型委托 ？作用？=》代码重复
//5.泛型约束
//6.协变,逆变

void ShowInt(int Value)
{
    Console.WriteLine($"这是老板的任务：{Value.GetType()}");
}
void ShowString(string Value)
{
    Console.WriteLine($"这是老板的任务：{Value.GetType()}");
}
void ShowIntArr(int[] Values)
{
    Console.WriteLine($"这是老板的任务：{Values.GetType()}");
}
void ShowObj(object Obj)//小缺陷：转换(装箱和拆箱)=》耗费性能 很小很小(忽略)
{
    Console.WriteLine($"这是老板的任务：{Obj.GetType()}");
}


#region 
//ShowString("上班");
//ShowString(".......");

//int[] ints = new int[] { 1, 2, 3 };
//ShowIntArr(ints);
////"上班",数组

//ShowObj(ints);
//ShowObj(1);
//ShowObj("上班");

//{
//    Console.WriteLine("********泛型********");
//    ints.Show();
//    1.Show();
//    "上班".Show();
//}
#endregion


GenericClass<int> genericClassInt = new GenericClass<int>()
{
    _T = 1
};
GenericClass<string> genericClassString = new GenericClass<string>()
{
    _T = "stirng"
};

HuNan people = new HuNan()
{
    Name = "张三",
    Id = 1
};

Chinese chinesePeople = new Chinese()
{
    Name = "李四",
    Id = 1
};

HuNan people1 = new HuNan()
{
    Name = "王五",
    Id = 1
};
HuNan people2 = new HuNan()
{
    Name = "赵六",
    Id = 1
};
Japanese japanese = new Japanese() { Name = "小苍", Id = 1 };
Console.WriteLine("********ShowObj*******");
ShowObj(people);
ShowObj(chinesePeople);
ShowObj(people1);
ShowObj(japanese);
ShowObj(people2);

Console.WriteLine("********T_ShowObj*******");
people.Show();
chinesePeople.Show();
people1.Show();
japanese.Show();
people2.Show();

//1
GenericMenthod.ShowPeopleInfo(people);
GenericMenthod.ShowPeopleInfo(chinesePeople);
GenericMenthod.ShowPeopleInfo(people1);
GenericMenthod.ShowPeopleInfo(people2);
//GenericMenthod.ShowPeopleInfo(japanese);

Console.WriteLine("********泛型约束*******");
GenericMenthod.ShowPeopleInfoGenericMenthod(people);
GenericMenthod.ShowPeopleInfoGenericMenthod(chinesePeople);
GenericMenthod.ShowPeopleInfoGenericMenthod(people1);
GenericMenthod.ShowPeopleInfoGenericMenthod(people2);

Console.Read();




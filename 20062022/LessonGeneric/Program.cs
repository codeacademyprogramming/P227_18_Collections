using System;

namespace LessonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[3];

            MyStringList stringList = new MyStringList();

            stringList.Add("Abbas");
            stringList.Add("Akif");
            stringList.Add("Nezrin");
            stringList.Add("Nigar");


            Console.WriteLine(stringList.Count);

            stringList.Remove("Nezrin");

            Console.WriteLine(stringList.Count);



            MyIntList numbers = new MyIntList();

            numbers.Add(34);
            numbers.Add(14);
            numbers.Add(44);
            numbers.Add(54);

            numbers.Remove(44);
            Console.WriteLine(numbers.GetValue(2));

            MyHumanList myHumanList = new MyHumanList();
            myHumanList.Add(new Human { Name = "Akif" });
            myHumanList.Add(new Human { Name = "Abbas" });
            myHumanList.Add(new Human { Name = "Nezrin" });
            myHumanList.Add(new Human { Name = "Gulnar" });



            MyList<int> nums = new MyList<int>();

            nums.Add(10);
            MyList<string> names = new MyList<string>();
            MyList<Human> humans = new MyList<Human>();

            MyKeyValues<string, double> products = new MyKeyValues<string, double>();
            products.Add("Alma", 2.5);
            products.Add("Armud", 3.5);
            products.Add("Erik", 5.5);
            products.Add("Alca", 6.5);

            Console.WriteLine(products.GetValue("Alma"));





        }
    }
}

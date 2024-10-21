using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Dogクラスのインスタンス hachi 生成する
            //Dog hachi = new Dog();
            
            // Dogクラスのインスタンス pochi 生成する
            Dog pochi = new Dog();

            //最初の空腹状態を表示してみる
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            //pochiに餌を食べさせる
            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}",pochi.IsHungry());

            //pochiを走らせる
            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());


            //一時停止
            Console.ReadLine();
        }
    }
}

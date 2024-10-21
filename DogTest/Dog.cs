using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Dog
    {
        //状態や属性「データ」
        private bool hungryState;

        //コンストラクタ
        public Dog()
        {
            hungryState = true;
        }

        //振る舞い「操作」

        //食べる→満腹になる

        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false;
        }

        //走る！→腹ペコ状態にする
        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState |= true;
        }

        //おなかが空いてる状態か調べる
        public bool IsHungry()
        {
            return hungryState;
        }
    }
}

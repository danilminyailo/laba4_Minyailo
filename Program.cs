using System;

namespace Animals
{
    class Program
    {/*Створити суперклас Птах і підкласи Орел, Папуга, Нелітаючий птах, Страус, Пінгвін. 
        За допомогою конструктора задати вік кожного птаха. 
        Визначити максимальну висоту польоту літаючих птахів та швидкість бігу нелітаючих.*/
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle(100,10,true);
            Parrot parrot = new Parrot(40, 4, true);
            Pinguin pinguin = new Pinguin(60, 30, false);
            Straus straus = new Straus(120, 42, false);
            eagle.Born();
            eagle.Move();
            eagle.StopMoving();
            eagle.Die();
            Console.WriteLine(eagle.GetInfo());
            Console.WriteLine(new string('-',30));
            parrot.Born();
            parrot.Move();
            parrot.StopMoving();
            parrot.Die();
            Console.WriteLine(parrot.GetInfo());
            Console.WriteLine(new string('-', 30));
            pinguin.Born();
            pinguin.Move();
            pinguin.StopMoving();
            pinguin.Die();
            Console.WriteLine(pinguin.GetInfo());
            Console.WriteLine(new string('-', 30));
            straus.Born();
            straus.Move();
            straus.StopMoving();
            straus.Die();
            Console.WriteLine(straus.GetInfo());
            Console.WriteLine(new string('-', 30));
        }
    }
}

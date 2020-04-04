using System;

namespace Task_3
{
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        //------------------------------------------------

        public Cat(string _name, string _color)
        {
            this.Name = _name;
            this.Color = _color;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + this.Name);
            Console.WriteLine("Цвет: " + this.Color);
        }

        public void DoingSomething()
        {
            Console.WriteLine("Иду играть с хозяином!");
        }

        public void GoingForWalk()
        {
            Console.WriteLine("Прогуляюсь!! :)");
        }
        public void StayAlong()
        {
            Console.WriteLine("Сидеть весь день под печкой так хорошо!!!");
        }
    }
    class Cat_1
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Django", "Серый");
            cat.ShowInfo();
            cat.GoingForWalk();
            cat.StayAlong();
            cat.DoingSomething();
        }
    }
}

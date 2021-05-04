using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Age = 39;
            parent.Name = "Адам";
            parent.Job = "Инженер";

            void informationParent()
            {
                Console.WriteLine(parent.Age);
                Console.WriteLine(parent.Name);
                Console.WriteLine(parent.Job);
            }

            informationParent();
            parent.actions();
            parent.eat();
            parent.leisure();
            parent.sleep();

            Child child = new Child();
            child.Age = 12;
            child.Name = "Джек";
            child.Hobby = "Играть в футбол";

            void informationChild()
            {
                Console.WriteLine(child.Age);
                Console.WriteLine(child.Name);
                Console.WriteLine(child.Hobby);
            }

            informationChild();
            child.actions();
            child.eat();
            child.leisure();
            child.sleep();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parent> p = new List<Parent>
            {
                new Parent() {Age=39, Name="Адам", Job="Инженер"},
                new Parent() {Age=33, Name="Сэм", Job="Менеджер"},
                new Parent() {Age=27, Name="Сьюзен", Job="Водитель"},
                new Parent() {Age=38, Name="Саид", Job="Художник"},
                new Parent() {Age=27, Name="Сандра", Job="Преподаватель"},
                new Parent() {Age=27, Name="Бри", Job="Продавец"},
            };

            try
            {
                foreach (var temp in p)
                {
                    if (temp.Age == 0)
                    {
                        throw new Exception("Ошибка");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Возраст не может быть равен нулю");
            }

            foreach (var temp in p)
            {
                Console.WriteLine("Возраст: " + temp.Age +  "\nИмя: " + temp.Name + "\nРабота: " + temp.Job);
                temp.actions();
                temp.eat();
                temp.leisure();
                temp.sleep();

            };

            List<Parent> p1 = p.Where(x => x.Age == 27).ToList();
            Console.WriteLine("Возраст равен 27:");
            foreach (var temp in p1)
            {
                Console.WriteLine("Имя: " + temp.Name);
            }
            Console.WriteLine("\n");

            List<Child> c = new List<Child>
            {
                new Child() {Age=12, Name="Джек", Hobby="Футбол"},
                new Child() {Age=13, Name="Том", Hobby="Рисование"},
                new Child() {Age=11, Name="Джулиа", Hobby="Танцы"},
                new Child() {Age=14, Name="Саймон", Hobby="Бейсбол"},
                new Child() {Age=13, Name="Люси", Hobby="Пение"},
                new Child() {Age=15, Name="Кэти", Hobby="Чтение"},
            };

            try
            {
                foreach (var temp in c)
                {
                    if (temp.Age == 0)
                    {
                        throw new Exception("Ошибка");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Возраст не может быть равен нулю");
            }

            foreach (var temp in c)
            {
                Console.WriteLine("Возраст: " + temp.Age + "\nИмя: " + temp.Name + "\nХобби: " + temp.Hobby);
                temp.actions();
                temp.eat();
                temp.leisure();
                temp.sleep();

            };

            List<Child> c1 = c.Where(y => y.Age == 13).ToList();
            Console.WriteLine("Возраст равен 13:");
            foreach (var temp in c1)
            {
                Console.WriteLine("Имя: " + temp.Name);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 0;
            int price2 = 0;
            int price3 = 0;
            int procent = 10;
            int income = 0;
            int choosen = 0;
            Random rand = new Random();
            Person person = new Person();
            Forex forex = new Forex();
            string surnameOfPerson = " ";
            string nameOfPerson = " ";          
            WriteLine("Введите свое имя");
            nameOfPerson = ReadLine();
            person.Name = nameOfPerson;
            WriteLine("Введите свою фамилия");
            surnameOfPerson = ReadLine();
            person.SurName = surnameOfPerson;
            price=rand.Next(100000);
            price2 = rand.Next(100000);
            price3 = rand.Next(100000);
            //forex.Price = price;
            forex.RandAndShowOblegation(price,price2,price3);
            WriteLine("Выберите акцию");
            while (!int.TryParse(ReadLine(), out choosen))
            {
                Clear();
                Write("Ошибка, введите целое число: ");
            }
            if(choosen==0)
            {
                forex.TaxFromIncome(procent, price);
            }
            else if (choosen == 1)
            {
                forex.TaxFromIncome(procent, price2);
            }
            else if (choosen == 2)
            {
                forex.TaxFromIncome(procent, price3);
            }
            ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp23
{
   public  class Forex
   {
        public string Oblegation { get;  set; }
        public int Price { get; set; }
        public int Income { get; set; }
        public int tax;
        public string[] mas = new string[3];
        Random rand = new Random();
        public Forex()
        {
            Price = 0;
            mas[0] = "Tele 2";
            mas[1] = "KazKom";
            mas[2] = "Beeline";
        }
        public void TaxFromIncome(int procent,int price)
        {
            
            Income = price - (price / 100) * procent;
            WriteLine(Income);
            WriteLine(procent);
            WriteLine(price);

        }
        public void RandAndShowOblegation(int Price1, int Price2, int Price3)
        {
            Dictionary<string, int> oblegation = new Dictionary<string, int>();
           oblegation.Add(mas[0],Price1);
            oblegation.Add(mas[1],Price2);
            oblegation.Add(mas[2],Price3);
            int i = 0;
            foreach (var os in oblegation)
            {
               
                Write(i+" ");
                WriteLine(os.Key + " - " + os.Value);
                i++;
            }
        }
   }
}

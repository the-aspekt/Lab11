using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k, b;
            Console.WriteLine("Введите параметры линейного уравнения типа kx+b=0. \n Данная программа найдет решение этого уравнения");
            try
            {
                Console.WriteLine("Введите параметр k");
                k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите параметр b");
                b = Convert.ToDouble(Console.ReadLine());
                LinearEquation linearEquation= new LinearEquation(k,b);
                linearEquation.Root();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();  
        }
    }
}

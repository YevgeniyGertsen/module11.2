using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace module11._2
{
    public class MyClass
    {
        public void GetMas()
        {
            string len = Console.ReadLine();
            int[] mas = new int[Int32.Parse(len)];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }
            
           
                Mas(mas);           
           
        }
        public void Mas(int[] mas)
        {
            Console.WriteLine("Введите номер элемента массива");
            string num = Console.ReadLine();
            int el = Int32.Parse(num);
            Console.WriteLine("Вы выбрали {0} элемент и его значение равно {1}", el, mas[el]);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();

            try
            {
                m.GetMas();
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("Такого лемента в массиве нет");
            }
            catch (Exception e)
            {
                Console.WriteLine("Входная строка имеет неверный формат");
            }
          

        }
        void getURI()
        {
            Console.WriteLine(" Введите ресурс");

            string res = Console.ReadLine();

            try
            {
                WebRequest WR = WebRequest.Create(res);
                WebResponse resp = WR.GetResponse();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

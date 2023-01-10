using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_module_3
{
    internal class HW_module_3
    {
        static int[] BirthArr()
        {
            var a = new int[3];
            for (int i = 0; i < a.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Введите число месяца рождения: ");
                        a[0] = Convert.ToByte(Console.ReadLine());
                        break;
                    case 1:
                        Console.Write("Введите месяц рождения (числом): ");
                        a[1] = Convert.ToByte(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Введите год рождения (числом): ");
                        a[2] = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****User DATA*****");
            (string Name, byte Age, int[] B) userMain;
            Console.Write("Введите своё имя: ");
            userMain.Name = Console.ReadLine();

            Console.Write("Сколько полных годиков?: ");
            userMain.Age = Convert.ToByte(Console.ReadLine());

            userMain.B = BirthArr();
            /*
            userMain.Birthday = new int[3];
            Console.Write("Введите число месяца рождения: ");
            userMain.Birthday[0] = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите месяц рождения (числом): ");
            userMain.Birthday[1] = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите год рождения (числом): ");
            userMain.Birthday[2] = Convert.ToInt32(Console.ReadLine());
            */
            Console.WriteLine("\tИтак:");

            Console.WriteLine("\t\tИмя: {0}", userMain.Name);
            Console.WriteLine("\t\tВозраст: {0}", userMain.Age);
            DateTime dt = new DateTime(userMain.B[2], userMain.B[1], userMain.B[0]);
            Console.Write("\t\tДата рождения: {0}.{1}.{2}", userMain.B[0], userMain.B[1], userMain.B[2]);
            Console.WriteLine(" и это был день недели {0}", dt.ToString("dddd"));


            Console.ReadLine();
        
        }
    }
}

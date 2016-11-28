using SmartHouse.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Illuminator ill = new Illuminator(false, BrightnessLevel.Medium);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(ill.Info() + "\n");
                Console.WriteLine("Нажмите клавишу для выполнения действия:");
                Console.WriteLine("1 - Включить светильник");
                Console.WriteLine("2 - Выключить светильник");
                Console.WriteLine("3 - Установить слабую яркость");
                Console.WriteLine("4 - Установить среднюю яркость");
                Console.WriteLine("5 - Установить высокую яркость");
                Console.WriteLine("e - Выйти");

                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        ill.On();
                        break;
                    case '2':
                        ill.Off();
                        break;
                    case '3':
                        ill.SetLowBrightness();
                        break;
                    case '4':
                        ill.SetMediumBrightness();
                        break;
                    case '5':
                        ill.SetHighBrightness();
                        break;
                    case 'e':
                        return;
                }
            }
        }
    }
}

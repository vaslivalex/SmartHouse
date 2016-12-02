using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHouse.Enums;

namespace SmartHouse.Menu
{
    class Menu
    {
        public void Show()
        {
            IDictionary<string, Illuminator> illDictionary = new Dictionary<string, Illuminator>();
            illDictionary.Add("Lamp", new Illuminator(false, BrightnessLevel.Medium));
            illDictionary.Add("TV", new TV(false, BrightnessLevel.Medium, 50));

            while (true)
            {
                Console.Clear();
                foreach (var ill in illDictionary)
                {
                    Console.WriteLine("Название: " + ill.Key + ", " + ill.Value.ToString());
                }
                Console.WriteLine();
                Console.Write("Введите команду: ");

                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                {
                    return;
                }
                if (commands.Length != 2)
                {
                    Help();
                    continue;
                }
                if (commands[0].ToLower() == "add" && !illDictionary.ContainsKey(commands[1]))
                {
                    illDictionary.Add(commands[1], new Illuminator(false, BrightnessLevel.Medium));
                    continue;
                }
                if (commands[0].ToLower() == "add" && illDictionary.ContainsKey(commands[1]))
                {
                    Console.WriteLine("Устройство с таким именем уже существует");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    continue;
                }
                if (!illDictionary.ContainsKey(commands[1]))
                {
                    Help();
                    continue;
                }
                switch (commands[0].ToLower())
                {
                    case "del":
                        illDictionary.Remove(commands[1]);
                        break;
                    case "on":
                        illDictionary[commands[1]].On();
                        break;
                    case "off":
                        illDictionary[commands[1]].Off();
                        break;
                    case "brightlow":
                        illDictionary[commands[1]].SetLowBrightness();
                        break;
                    case "brightmedium":
                        illDictionary[commands[1]].SetMediumBrightness();
                        break;
                    case "brighthigh":
                        illDictionary[commands[1]].SetHighBrightness();
                        break;
                    default:
                        Help();
                        break;
                }
            }
        }

        private static void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("\tadd nameIlluminator");
            Console.WriteLine("\tdel nameIlluminator");
            Console.WriteLine("\ton nameIlluminator");
            Console.WriteLine("\toff nameIlluminator");
            Console.WriteLine("\tbrightlow nameIlluminator");
            Console.WriteLine("\tbrightmedium nameIlluminator");
            Console.WriteLine("\tbrighthigh nameIlluminator");
            Console.WriteLine("\texit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
    }
}

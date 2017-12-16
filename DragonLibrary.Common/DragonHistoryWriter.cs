using System;
using System.Collections.Generic;
using DragonLibrary.Common.Domain;
using DragonLibrary.Common.Domain.Models;

namespace DragonLibrary.Common
{
    public class DragonHistoryWriter : IDragonHistoryWriter
    {
        public void ColorfulStoryOnMyScreen(IList<IDragon> dragons)
        {
            foreach (var item in dragons)
            {
                if (item.GetDragonType() == "Ice")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                string value = item.GetDragonType();
                switch (value)
                {
                    case "Ice":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(item.GetFullInfo());
                        break;
                    }
                    case "Fire":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(item.GetFullInfo());
                        break;
                    }
                    case "MagicForce":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(item.GetFullInfo());
                        break;
                    }
                    default:
                    Console.WriteLine(item.GetFullInfo());
                    break;
                }
            }
        }
    }
}

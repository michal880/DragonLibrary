using DragonLibrary.Common;
using DragonLibrary.Common.Domain;
using DragonLibrary.Core;
using System;

namespace DragonLibrary.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// You cannot change what's in here.
        /// </summary>
        static void Main(string[] args)
        {
            var dragonFileGenerator = new DragonFileGenerator();
            dragonFileGenerator.HereBeDragons();

            IDragonParser parser = new DragonParser();
            var dragons = parser.Parse();

            IDragonHistoryWriter historyWriter = new DragonHistoryWriter();
            historyWriter.ColorfulStoryOnMyScreen(dragons);

            Console.ReadKey();
        }
    }
}

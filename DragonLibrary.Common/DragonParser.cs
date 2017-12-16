using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DragonLibrary.Common.Domain;
using DragonLibrary.Common.Domain.Models;

namespace DragonLibrary.Common
{
    public class DragonParser : IDragonParser
    {
        public IList<IDragon> Parse()
        {
            string decodedString = "";
            IList<IDragon> dragonList = new List<IDragon>();
            using (StreamReader sr = new StreamReader("dragons.eht"))
            {
                
                String encodedString = sr.ReadLine();
                while (encodedString != null)
                {
                    byte[] data = Convert.FromBase64String(encodedString);
                    decodedString = Encoding.UTF8.GetString(data);
                    Dragon dragon = new Dragon();
                    Char separator = ';';
                    string[] DragonInfo = decodedString.Split(separator);
                    dragon.Name = DragonInfo[0];
                    dragon.Age = Int32.Parse(DragonInfo[1]);
                    dragon.DragonDesc = DragonInfo[2];
                    dragon.DragonType = DragonInfo[3];
                    dragonList.Add(dragon);
                    encodedString = sr.ReadLine();
                }
            }



            

            return dragonList;
        }
    }
}

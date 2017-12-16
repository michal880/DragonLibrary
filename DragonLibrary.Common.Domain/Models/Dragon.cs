using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonLibrary.Common.Domain.Models
{
    public class Dragon : IDragon
    {
        public string Name;
        public int Age;
        public string DragonDesc;
        public string DragonType;

        public string GetDragonType()
        {
            return this.DragonType;
        }

        public string GetFullInfo()
        {
            string fullInfo = "Name:"+Name + "; Age:" + Age+"; Description:"+DragonDesc + "; DragonType:" +DragonType;
            return fullInfo;
        }

       
    }
}

using DragonLibrary.Common.Domain.Models;
using System.Collections.Generic;

namespace DragonLibrary.Common.Domain
{
    public interface IDragonParser
    {
        /// <summary>
        /// Look for dragons.eht it holds dragons secrets.
        /// Every line of the story is written in some ancient language called Base64. 
        /// Let's translate it into something we do understand.
        /// </summary>
        /// <returns>Dragons!</returns>
        IList<IDragon> Parse();
    }
}

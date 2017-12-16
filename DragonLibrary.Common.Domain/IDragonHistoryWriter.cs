using DragonLibrary.Common.Domain.Models;
using System.Collections.Generic;

namespace DragonLibrary.Common.Domain
{
    public interface IDragonHistoryWriter
    {
        /// <summary>
        /// When you open the book you will see, that unknown writer discovered that 
        /// Ice Dragons were LightBlue, Fire Dragons were Red and Dragons with magic force were green.
        /// </summary>
        void ColorfulStoryOnMyScreen(IList<IDragon> dragons);
    }
}

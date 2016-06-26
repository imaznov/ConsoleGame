namespace TeamJaxConsoleGame.Lib.Interfaces
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IMap
    {
        int Rows { get; }
        int Cols { get; }

        void AddHero(Hero hero);


    }
}

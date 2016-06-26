namespace TeamJaxConsoleGame.Lib.Entities
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Map : IMap
    {
        public Map(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Cols { get; private set; }
        public int Rows { get; private set; }

        //Add Hero Method - Random?
        public void AddHero(Hero hero)
        {

        }
    }
}

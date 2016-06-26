namespace TeamJaxConsoleGame.Lib.Entities
{
    using Constants;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Map : IMap
    {
        private Hero[,] map;

        public Map(int rows = GlobalConstants.StandardMapRow, int cols = GlobalConstants.StandardMapCol)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.map = new Hero[rows, cols];
        }

        public int Cols { get; private set; }
        public int Rows { get; private set; }

        //Add Hero Method - Random?
        public void AddHero(Hero hero)
        {
            //Add validation for overlapping heroes
            Random rnd = new Random();
            int AddHeroRow = rnd.Next(0, this.Rows);
            int AddHeroCol = rnd.Next(0, this.Cols);
            this.map[AddHeroRow, AddHeroCol] = hero;
        }

        public void RemoveHero(Hero hero)
        {

        }
    }
}

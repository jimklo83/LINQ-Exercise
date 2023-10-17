using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ParadoxGame
    {
        public string Name { get; set; }
        public bool IsSequel { get; set; }

        public ParadoxGame() 
        {
            
        }

        public ParadoxGame(string name, bool isSequel) 
        {
            Name = name;
            IsSequel = isSequel;
        }
    }
}

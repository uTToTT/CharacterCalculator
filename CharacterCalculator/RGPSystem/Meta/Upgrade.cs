using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCalculator.RGPSystem.Meta
{
    internal class Upgrade
    {
        public int EveryLevel { get; set; }

        public List<Buff> Buffs { get; set; }


        public Upgrade()
        {
            Buffs = new List<Buff>();
            EveryLevel = 1;
        }
    }
}

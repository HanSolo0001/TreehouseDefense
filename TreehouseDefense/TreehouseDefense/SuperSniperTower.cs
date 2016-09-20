using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SuperSniperTower : Tower
    {
        protected override int Range { get; } = 3;
        protected override int Power { get; } = 2;
        protected override double Accuracy { get; } = .90;

        public SuperSniperTower(MapLocation location) : base(location)
        { }
    }
}

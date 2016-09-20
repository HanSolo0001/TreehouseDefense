using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SuperInvader : Invader
    {
        public override int Health { get; protected set; } = 4;

        protected override int StepSize { get; } = 2;

        public SuperInvader(Path path) : base(path)
        { }
    }
}

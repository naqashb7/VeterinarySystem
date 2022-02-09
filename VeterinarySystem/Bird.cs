using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarySystem
{
    public abstract class Bird :Animal
    {
        public override void Breathe()
        {
            //implement a breathe method
        }

        public override Bird Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}

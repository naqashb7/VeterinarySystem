using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarySystem
{
    public abstract class Fish: Animal
    {

        public override void Breathe()
        {
            //implement a breathe method
        }

        public override Fish Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CHito : CIkimono
    {
        private static int count = 0;

        public CHito(string nm) : base(nm)
        {
            count++;
        }

        public static int getCount()
        {
            return count;
        }

        public override string action()
        {
            return "テクテク";
        }
    }
}

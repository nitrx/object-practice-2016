using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CHito
    {
        private int count = 0;
        private string name = "";

        public CHito(string nm)
        {
            name = nm;
            count++;
        }

        public int getCount()
        {
            return count;
        }

        public string hello()
        {
            return "私は" + name + "です";
        }

        public string action()
        {
            return "テクテク";
        }
    }
}

﻿namespace object_practice_2016
{
    class CSakana : CIkimono
    {
        private static int count = 0;

        public CSakana(string nm) : base(nm)
        {
            count++;
        }
        public static int getCount()
        {
            return count;
        }
        public override string action()
        {
            return "スイスイ";
        }
    }
}
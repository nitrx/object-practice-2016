using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CIkimono
    {
        //生き物の数
        private static int ikimonoCount = 0;
        //名前
        private string name = "";

        //生き物を数える
        public CIkimono(string nm)
        {
            name = nm;　//名前を記録
            ikimonoCount++; //生き物を数える
        }

        //生き物の数を返す
        public static int getIkimonoCount()
        {
            return ikimonoCount;
        }
        
        //挨拶
        public string hello()
        {
            return "私は" + name + "です。";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        private readonly string Info;
        private static Singleton TheOne = null;
        private Singleton(string info)
        {
            Info = info;
            //TheOne = null;
        }
        public static Singleton GetInstance(string info)
        {
            if (TheOne is null)
            {
                TheOne = new Singleton(info);
            }
            return TheOne;
        }
        public string Access()
        {
            return Info;
        }
    }
}

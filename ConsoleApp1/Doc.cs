using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Doc
    {
        protected string FIO;
        
        public Doc(string newFIO)
        {
            FIO = newFIO;
        }

        public void setFIO(string newFIO)
        {
            FIO = newFIO;
        }

        public string getFIO()
        {
            return FIO;
        }
        public abstract string print();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Priem : Doc
    {
        protected string Doljnost;
        public Priem(string FIO, string newDolj) : base(FIO)
        {
            Priem Priem = this;
            Priem.FIO = FIO;
            Doljnost = newDolj; 
        }

        public void setDolj(string newDolj)
        {
            Doljnost = newDolj;
        }

        public string getDolj()
        {
            return Doljnost;
        }

        public override string print()
        {
            return("FIO - " + getFIO() + " Dolnoct - " + getDolj());
        }
    }
}

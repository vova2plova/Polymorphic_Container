using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Yvolit : Doc
    {
        protected string Prichina;
        public Yvolit(string FIO, string newPrich) : base(FIO)
        {
            Yvolit yvolit = this;
            yvolit.FIO = FIO;
            Prichina = newPrich;
        }

        public void setPrich(string newPrich)
        {
            Prichina = newPrich;
        }

        public string getPrich()
        {
            return Prichina;
        }

        public override string print()
        {
            return("FIO - " + getFIO() + " Prichina - " + getPrich());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Conteiner
    {
        private Doc [] Docs = new Doc[5];
        private int length;
        private int count;

        public Conteiner()
        {
            count = 0;
            length = 5;
        }

        public int getCount()
        {
            return count;
        }

        public void add(Doc aDoc)
        {
            if (count == length)
            {
                Array.Resize(ref Docs, length * 2);
                length *= 2;
            }
            Docs[count++] = aDoc;

        }

        public void delete()
        {
            Docs[count--] = null;
        }

        public Doc getDocs(int nom)
        {
            if (nom-1 < count)
                return (Docs[nom - 1]);
            return null;
        }



        public string getAllData()
        {
            string result = "";
            int i = 0;
            while (Docs[i] != null)
            {
                result = result + Docs[i].print() + "\n";
                i++;
            }
            return(result);
        }
    }
}

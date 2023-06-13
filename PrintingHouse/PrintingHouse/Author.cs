using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouse
{
    public abstract class Author : IPrint
    {
        private int nomenclatNum;
        private string name;

        public int NomenclatNum
        {
            get { return nomenclatNum; }
            set { nomenclatNum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Author(string name, int nomenclatNum)
        {
            this.name = name;
            this.nomenclatNum = nomenclatNum;
        }

        public virtual void Print() { }

    }
}

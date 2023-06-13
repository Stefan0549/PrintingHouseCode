using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrintingHouse
{
    public class Books : Author
    {
        public Books(string title, string name, int circulation, int issueNum, double price, int year, int nomenclatNum) : base(name, nomenclatNum)
        {
            this.Title = title;
            this.Circulation = circulation;
            this.IssueNum = issueNum;
            this.Price = price;
            this.Year = year;
        }

        private int circulation;
        private double price;
        private string title;
        private int year;
        private int issueNum;

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Title should be atleast 3 symbols");
                }
                title = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price should be positive number");
                }
                price = value;
            }
        }

        public int Circulation
        {
            get { return circulation; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Circulation should be positive number");
                }
                circulation = value;
            }
        }

        public int IssueNum
        {
            get { return issueNum; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Issue number should be positive number");
                }
                issueNum = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 100)
                {
                    throw new Exception("You should be death");
                }
                year = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Numeber is : {NomenclatNum}");
            Console.WriteLine($"Name of the author : {Name}");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Circulation : {Circulation}");
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Issue number : {IssueNum}");
        }
    }
}


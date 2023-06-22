using System;

namespace ConsoleApp1
{
    class Card
    {

        public Card(string number, string cvv, string expdate, string name, string bank, decimal balance)
        {
            this.number = number;
            this.cvv = cvv;
            this.expdate = expdate;
            this.name = name;
            this.bank = bank;
            this.balance = balance;

        }

        public string number { get; set; }
        public string cvv { get; set; }
        public string expdate { get; set; }
        public string name { get; set; }
        public string bank { get; set; }
        public decimal balance { get; set; }

    }

    public class Program
    {
        public static void Main(string[] args)

        {
            {
                Card card = new Card("4098525465233332", "452", "05/25", "Azad", "Unibank", 5654m);

                Console.WriteLine(card.number + "  " + card.cvv + "  " + card.expdate + "  " + card.name + "  " + card.bank + "  " + card.balance + "AZN");
            }
        }
    }
}



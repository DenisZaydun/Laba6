using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Client : Person, IAccount
    {
        public string TypeOfBankCard { get; set; }
        public Client(string name, string typeOfBankCard) : base(name)
        {
            TypeOfBankCard = typeOfBankCard;
        }

        int _sum;

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum) { _sum += sum; }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Клієнт:");
            Console.WriteLine($"Ім'я: {Name};");
            Console.WriteLine($"Карта: {TypeOfBankCard}");
            Console.WriteLine($"Сума на рахунку: {CurrentSum} грн.");
        }
    }
}

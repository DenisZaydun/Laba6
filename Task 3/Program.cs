using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
                    Console.OutputEncoding =
                        System.Text.Encoding.Unicode;

            Employee employee = new Employee("Тарас", "Бог");
            employee.Display();

            Console.WriteLine();

            Client client = new Client("Остап", "Розрахункова карта");
            client.Put(600000);
            client.Withdraw(100);
            client.Display();

            Console.ReadLine();
        }
    }
}

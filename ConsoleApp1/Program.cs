using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Phone
    {
        public int number;
        public string model;
        public int weight;
        public Phone(int number, string model, int weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
            
        }
        public Phone(int number, string model) 
        {
            this.number = number;
            this.model = model;
        }
        public Phone()  { }
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(123, "A50", 125);
            phone1.number = 123;
            phone1.model = "A50";
            phone1.weight = 125;
            Console.WriteLine($"Number: {phone1.number}, Model: {phone1.model}, Weight: {phone1.weight}");
            phone1.receiveCall("Oleg");
            phone1.getNumber();

            Phone phone2 = new Phone(345, "B40", 123);
            phone2.number = 345;
            phone2.model = "B40";
            phone2.weight = 123;
            Console.WriteLine($"Number: {phone2.number}, Model: {phone2.model}, Weight: {phone2.weight}");
            phone2.receiveCall("Mihail");
            phone2.getNumber();

            Phone phone3 = new Phone(567, "C30", 121);
            phone3.number = 567;
            phone3.model = "C30";
            phone3.weight = 121;
            Console.WriteLine($"Number: {phone3.number}, Model: {phone3.model}, Weight: {phone3.weight}");
            phone3.receiveCall("Sasha");
            phone3.getNumber();
            phone1.receiveCall("", 0);
        }
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public void receiveCall(string name, int number)
        {
            name = Console.ReadLine();
            number = Console.Read();
            Console.WriteLine($"Name: {name}, Number: {number}");
        }
        public void getNumber()
        {
            return;
        }
        public void sendMessage(int number)
        {
            number = Console.Read();
            Console.Write("Number of receiver", number);
        }
    }
}
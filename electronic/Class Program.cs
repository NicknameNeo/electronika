using System;
using electronic;
class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone();
        Console.WriteLine(phone.GetBrand);
        phone.Charge();
        phone.TurnOff();
        Console.WriteLine();
        Laptop laptop = new Laptop();
        Console.WriteLine(laptop.GetBrand);
        laptop.Charge();
        laptop.TurnOff();
        Phone phone2 = new Phone("Samsung", 91 );
        Console.WriteLine(phone2.GetBrand);
        Console.WriteLine(phone2.GetBatteryLevel);
        phone2.AddBatteryLevel(30);
        
        
            

    }
}
using System;

namespace electronic
{
    class E_Device
    {
        private string Brand;
        protected int BatteryLevel;
        private bool IsOn;

        public string GetBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public int GetBatteryLevel
        {
            get { return BatteryLevel; }
            set { BatteryLevel = value; }
        }
        
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} is turned off");
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} is turned on");
        }

        public void Charge()
        {
            BatteryLevel++;
            Console.WriteLine($"{Brand} is charged on {BatteryLevel}% Battery");
        }

        public void AddBatteryLevel(int level)
        {
            BatteryLevel += level;
            if (BatteryLevel > 100) BatteryLevel = 100;
            Console.WriteLine($"{Brand} is charged on {BatteryLevel}% Battery");
        }
        
    }
    
   
}
using System;
using electronic;
class  Phone : E_Device
{
    public Phone()
    {
        GetBrand = "Iphone";
        BatteryLevel = 19;
        TurnOn();
    }

    public Phone(string brand, int batteryLevel)
    {
        GetBrand = brand;
        GetBatteryLevel = batteryLevel;
        
    }

   


}

using System;
using electronic;

class Laptop : E_Device
{
    public Laptop()
    {
        GetBrand = "MSI";
        BatteryLevel = 90;
        TurnOn();
            
    }
}   
using System;
using System.Collections.Generic;
using System.Linq;

class GSM
{
    private string model;   //mandatory
    private string manufacturer;    //mandatory
    private double? price;
    private string owner;
    private Battery battery = new Battery();
    private Display display = new Display();
    private List<Call> callHistory = new List<Call>();
    public static GSM IPhone4S = new GSM("Iphone 4S", "Apple", 999, "Pesho", "special", 350, 20, BatteryType.LiPol, 4, 16000000);
    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null, null, default(BatteryType), null, null)
    {
    }
    public GSM(string model, string manufacturer, double? price, string owner, string batteryModel, int? batteryIdleTime, int? batteryTalkTime, BatteryType batteryType, double? displaySize, int? displayColors)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.battery.Model = batteryModel;
        this.battery.HoursIdle = batteryIdleTime;
        this.battery.HoursTalk = batteryTalkTime;
        this.battery.BatteryType = batteryType;
        this.display.Size = displaySize;
        this.display.NumberOfColors = displayColors;
    }

    private List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
        set
        {
            this.callHistory = value;
        }
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Length<2)
            {
                throw new ArgumentException("Invalid Model!!!");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Invalid Manufacturer!!!");
            }
            this.manufacturer = value;
        }
    }

    public double? Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price should be a positive integer number!!!");
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public void AddCall(string number, int duration)
    {
        Call newCall = new Call(number, duration);
        this.callHistory.Add(newCall);
    }
    public void RemoveCall()
    {
        int longestDuration = 0;
        foreach (var item in this.callHistory)
        {
            if (item.Duration > longestDuration)
            {
                longestDuration = item.Duration;
            }
        }
        this.callHistory.Remove(this.callHistory.First(x => x.Duration == longestDuration));
    }
    public void ClearCallHistory()
    {
        this.callHistory.Clear();
    }
    public decimal GetCallsPrice(decimal pricePerMinute)
    {
        decimal callPrice = 0.0m;
        foreach (var item in this.callHistory)
        {
            callPrice += item.Duration/60 * pricePerMinute;
        }
        return callPrice;
    }
    public void DisplayCallInformation()
    {
        if (this.callHistory.Count > 0)
        {
            foreach (var item in this.callHistory)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Current calls history is empty.\n");
        }
    }

    public override string ToString()
    {
        return string.Format("GSM Info: \nModel:{0} \nManufacturer:{1} \nPrice:{2} \nOwner:{3} \nBattery Model:{4} \nTalk time in hours:{5} \nIdle time in hours:{6} \nBattery Type:{7} \nDisplay size in inches:{8} \nNumber of Colors:{9} \n", this.Model, this.Manufacturer, this.Price, this.Owner, battery.Model, battery.HoursIdle, battery.HoursTalk, battery.BatteryType, display.Size, display.NumberOfColors);
    }
}


using System;
public enum BatteryType
{
    unknown, LiIon, LiPol, NiMH, NiCd
}
class Battery
{
    private string model;
    private int? hoursIdle;
    private int? hoursTalk;
    private BatteryType batteryType;
    public Battery()
        : this(null, null, null, default(BatteryType))
    {
    }
    public Battery(string model)
        : this(model, null, null, default(BatteryType))
    {
    }
    public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType batteryType)
    {
        this.model = Model;
        this.hoursIdle = HoursIdle;
        this.hoursTalk = HoursTalk;
        this.batteryType = batteryType;
    }
    public string Model
    {
        get { return this.model; }
        set
        {
            if (value!=null&&value.Length<2)
            {
                throw new ArgumentException("Invalid battery model!!!");
            }
            this.model = value;
        }
    }
    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException("The hours idle should be a positive integer number!!!");
            }
            this.hoursIdle = value;
        }
    }
    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException("The hours talk should be a positive integer number!!!");
            }
            this.hoursTalk = value;
        }
    }
    public BatteryType BatteryType
    {
        get { return this.batteryType; }
        set
        {
            bool isDefined = BatteryType.IsDefined(typeof(BatteryType), value);
            if (isDefined)
            {
                this.batteryType = value;
            }
        }
    }
}

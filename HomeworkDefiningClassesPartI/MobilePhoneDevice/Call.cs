using System;

class Call
{
    private DateTime date;
    private DateTime time;
    private string phoneNumber;
    private int duration;

    public Call(string phoneNumber, int duration)
    {
        this.date = DateTime.Now;
        this.time = DateTime.Now;
        this.PhoneNumber = phoneNumber;
        this.Duration = duration;
    }
    public DateTime Date
    {
        get
        {
            return this.date;
        }
    }
    public DateTime Time
    {
        get
        {
            return this.time;
        }
    }
    public int Duration
    {
        get
        {
            return this.duration;
        }
        private set
        {
            if (value<1)
            {
                throw new ArgumentException("Invalid duration!!!");
            }
            this.duration = value;
        }
    }
    private string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }
        set
        {
            if (value.Length!=10)
            {
                throw new ArgumentException("Invalid phone number!!!");
            }
            this.phoneNumber = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Date:{0} Time:{1} Phone number:{2} Duration:{3}", this.Date.ToString("dd.MM.yyyy"), this.Date.ToString("hh:mm tt"), this.PhoneNumber, this.Duration);

    }
}
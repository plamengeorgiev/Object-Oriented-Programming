using System;

class Display
{
    private double? size;
    private int? numberOfColors;

    public double? Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The size of the display should be a positive integer number!");

            }
            this.size = value;
        }
    }
    public int? NumberOfColors
    {
        get { return this.numberOfColors; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The number of colors should be a positive integer number!");
            }
            this.numberOfColors = value;
        }
    }
}

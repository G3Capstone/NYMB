using System;

public class Binder : Item
{
    private string size, color, manufacturer;

	public Binder()
        : base ("Item")
	{
        
	}

    public Binder(string n, string s, string c, string m, double p)
        : base ("Item")
    {
        name = n;
        size = s;
        color = c;
        manufacturer = m;
        price = p;
    }

    
    public string Size
    {
        get { return size; }
        set { size = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }
}

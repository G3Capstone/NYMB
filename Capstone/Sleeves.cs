using System;

public class Sleeves : Item
{
    private string _type, _size, _color, _manufacturer;

	public Sleeves()
        : base ("Item")
	{
	}

    public Sleeves(string t, string s, string c, string m)
        : base ("Item")
    {
        _type = t;
        _size = s;
        _color = c;
        _manufacturer = m;
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public string Size
    {
        get { return _size; }
        set { _size = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public string Manufacturer
    {
        get { return _manufacturer;}
        set { _manufacturer = value; }
    }
}

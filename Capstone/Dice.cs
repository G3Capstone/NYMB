using System;

public class Dice : Item
{
    private string _color, _manufacturer, _description;

	public Dice()
        : base ("Item")
	{
	}

    public Dice(string c, string m, string d)
        :base ("Item")
    {
        _color = c;
        _manufacturer = m;
        _description = d;
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public string Manufaturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
}

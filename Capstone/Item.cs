using System;

public class Item
{

    private string _name;
    private double _price;

	public Item()
	{
        _name = null;
        _price = null;
	}

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
}

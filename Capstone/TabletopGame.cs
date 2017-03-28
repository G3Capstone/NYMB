using System;

public class TabletopGame : Item
{
    private string _game, _publisher;
    private int _game_id;

	public TabletopGame()
        : base ("Item")
	{
	}

    public TabletopGame(string g, string p, int g)
        : base ("Item")
    {
        _game = g;
        _publisher = p;
        _game = g;
    }

    public string Game
    {
        get { return _game; }
        set { _game = value; }
    }

    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }
}

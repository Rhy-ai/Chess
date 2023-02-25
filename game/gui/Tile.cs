public class Tile
{
    public int x;
    public int y;

    const int size = 100;
    Rectangle square;
    Color colour;

    

    private Tile currentTile;
    public Tile(int x, int y, Color colour, Graphics g)
    {
        this.x = x;
        this.y = y;
        this.colour = colour;
        square = new Rectangle(x * size, y * size, size, size); // (x, y, width, height)
        g.FillRectangle(new SolidBrush(colour), square);
    }

    public static void HighlightTiles(List<Tile> tiles, Graphics g)
    {
        foreach(Tile tile in tiles)
        {
            g.FillRectangle(new SolidBrush(Color.Pink), tile.square);
            g.DrawRectangle(new Pen(Color.Black, 2), tile.square);
        }
    }
    public void highlight(Graphics g)
    {
        g.DrawRectangle(new Pen(Color.Black, 3), square);

    }

    public void unHighlight(Graphics g)
    {
        g.DrawRectangle(new Pen(colour, 3), square);
    }

    public bool isInAreaOfTile(int x, int y)
    {
        if (x > this.x * size && x < this.x * size + 100 && y > this.y * size && y < this.y * size + 100)
        {
            return true;
        }
        return false;
    }


    
    
}
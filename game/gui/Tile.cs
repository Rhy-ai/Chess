public class Tile
{
    int x;
    int y;

    const int size = 100;
    Rectangle square;
    Color colour;

    ChessPiece? piece = null;

    private Tile currentTile;
    public Tile(int x, int y, Color colour, Graphics g)
    {
        this.x = x;
        this.y = y;
        this.colour = colour;
        square = new Rectangle(x * size, y * size, size, size); // (x, y, width, height)
        g.FillRectangle(new SolidBrush(colour), square);
    }

    public void highlightAvailableMoves(Graphics g)
    {
        square.Y += 100;
        g.FillRectangle(new SolidBrush(Color.Pink), square);
        g.DrawRectangle(new Pen(Color.Black, 2), square);

        square.Y += 100;
        g.FillRectangle(new SolidBrush(Color.Pink), square);
        g.DrawRectangle(new Pen(Color.Black, 2), square);
    }
    public void highlightThis(Graphics g)
    {
        g.DrawRectangle(new Pen(Color.Yellow, 4), square);

    }

    public bool isInAreaOfTile(int x, int y)
    {
        if (x > this.x * size && x < this.x * size + 100 && y > this.y * size && y < this.y * size + 100)
        {
            return true;
        }
        return false;
    }

    public void setPieceOnTile(ChessPiece piece)
    {
        this.piece = piece;
    }

    public ChessPiece? getPieceOnTile()
    {
        return piece;
    }
    
    
}
public abstract class ChessPiece
{
    int x;
    int y;
    char team;

    

    public ChessPiece(int x, int y, char team, Graphics g)
    {
        this.x = x;
        this.y = y;
        this.team = team;
    }

    public abstract List<Tile> getAvailableMoves();
    

    

}
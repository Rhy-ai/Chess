public abstract class ChessPiece
{

    char team;
    public Tile tile;   
    public static List<ChessPiece> allPieces = new List<ChessPiece>(); 

    public ChessPiece(char team, Tile tile, Graphics g)
    {
        this.team = team;
        this.tile = tile;
        allPieces.Add(this);
    }

    public abstract List<Tile> getAvailableMoves(List<Tile> tiles);

    

}
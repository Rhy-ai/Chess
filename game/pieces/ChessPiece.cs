public abstract class ChessPiece
{

    char team;
    public Tile currentTile;   
    public static List<ChessPiece> allPieces = new List<ChessPiece>(); 
    protected  List<Tile> availableTiles = new List<Tile>(); 

    public ChessPiece(char team, int currentTile, List<Tile> tiles, Graphics g)
    {
        this.team = team;
        this.currentTile = tiles[currentTile];
        allPieces.Add(this);
        setAvailableMoves(tiles);
    }

    public abstract void setAvailableMoves(List<Tile> tiles);

    public List<Tile> getAvailableMoves(){
        return availableTiles;
    }
    
    public void clearAvailableMoves(){
        availableTiles.Clear();
    }

    public abstract void movePiece(Tile selectedTile, Graphics g);
    

}
public class Pawn : ChessPiece
{
    public Pawn(char team, int currentTile, List<Tile> tiles, Graphics g): base(team, currentTile, tiles, g)
    {
        try
        {
            // Retrieve the image.
            Bitmap image1 = new Bitmap(@"game\images\w_pawn_1x_ns.png", true);                
            image1.SetResolution(370f, 370f);
          

          //Small adjustments to make to pawn centre of the tile
            int pawnX = (tiles[currentTile].x * 100) + 15;
            int pawnY = (tiles[currentTile].y * 100) + 15;

            //Render Image
            g.DrawImage(image1, new Point(pawnX, pawnY));

        }
        catch (ArgumentException)
        {
            // If file path in inccorrect. this error will display
            MessageBox.Show("There was an error." +
                "Check the path to the image file.");
        }
    }

    bool firstMove = true;  

    public override void setAvailableMoves(List<Tile> tiles)
    {      
        for (int i = 0; i < tiles.Count; i++)
        {
            if (this.currentTile == tiles[i])
            {
                availableTiles.Add(tiles[i + 8]);
                availableTiles.Add(tiles[i + 16]);
            }
        }        
    }

    public override void movePiece(Tile selectedTile, Graphics g)
    {
        // Retrieve the image.
        Bitmap image1 = new Bitmap(@"game\images\w_pawn_1x_ns.png", true);                
        image1.SetResolution(370f, 370f);
          

        //Small adjustments to make to pawn centre of the tile
        int pawnX = (selectedTile.x * 100) + 15;
        int pawnY = (selectedTile.y * 100) + 15;

        g.DrawImage(image1, new Point(pawnX, pawnY));
    }
}


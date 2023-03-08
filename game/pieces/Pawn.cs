public class Pawn : ChessPiece
{
    public Pawn(char team, Tile tile,Graphics g): base(team, tile, g)
    {
        float width = 1024;
        float height = 768;

        try
        {
            // Retrieve the image.
            Bitmap image1 = new Bitmap(@"game\images\w_pawn_1x_ns.png", true);   
            Bitmap resizedImage1 = new Bitmap(image1, new Size(image1.Width/4, image1.Height/4));   
            resizedImage1.SetResolution(110f, 110f);
          

          //Small adjustments to make to pawn centre of the tile
            int pawnX = (tile.x * 100) + 15;
            int pawnY = (tile.y * 100) + 15;

            //Render Image
            g.DrawImage(resizedImage1, new Point(pawnX, pawnY));

        }
        catch (ArgumentException)
        {
            // If file path in inccorrect. this error will display
            MessageBox.Show("There was an error." +
                "Check the path to the image file.");
        }
    }

    bool firstMove = true;  

    public override List<Tile> getAvailableMoves(List<Tile> tiles)
    {
        List<Tile> availableMoves = new List<Tile>();
        for (int i = 0; i < tiles.Count; i++)
        {
            if (this.tile == tiles[i])
            {
                availableMoves.Add(tiles[i + 8]);
                availableMoves.Add(tiles[i + 16]);
            }
        }

        return availableMoves;
    }
}


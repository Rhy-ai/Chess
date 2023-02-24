public class Pawn : ChessPiece
{
    public Pawn(int x, int y, char team, Graphics g): base(x, y, team, g)
    {
        try
        {
            // Retrieve the image.
            Bitmap image1 = new Bitmap(@"game\images\w_pawn_1x_ns.png", true);                
          
            image1.SetResolution(370f, 370f);
            //Render Image
            g.DrawImage(image1, new Point(x, y));

        }
        catch (ArgumentException)
        {
            // If file path in inccorrect. this error will display
            MessageBox.Show("There was an error." +
                "Check the path to the image file.");
        }
    }

    bool firstMove = true;  

    public override List<Tile> getAvailableMoves()
    {
        throw new NotImplementedException();
    }
}
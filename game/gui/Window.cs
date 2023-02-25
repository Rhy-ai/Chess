public class Window
{
    Canvas canvas;
    public static List<Tile> tiles = new List<Tile>();

    ChessPiece? selectedPiece = null;

    public Window()
    {
        // --- boilerplate bullshit ---
        ApplicationConfiguration.Initialize();
        this.canvas = new Canvas();
        canvas.MouseClick += mouse_click;
        canvas.Paint += renderer;
        Application.Run(canvas);
    }

    //            --------------------- RENDERING ---------------------
    private void renderer(object sender, PaintEventArgs e)
    {
        drawChessBoard(e.Graphics);
        drawAsset(e.Graphics);
    }

    public void drawChessBoard(Graphics g)
    {
        int x = 0;
        int y = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                x = j;
                y = i;
                //Rectangle square = new Rectangle(x, y, 100, 100); // (x, y, width, height)

                if (i % 2 == 0)
                {
                    if (j % 2 == 0) tiles.Add(new Tile(x, y, Color.Chocolate, g));
                    else if (j % 2 == 1) tiles.Add(new Tile(x, y, Color.Brown, g));
                }
                else if (i % 2 == 1)
                {
                    if (j % 2 == 1) tiles.Add(new Tile(x, y, Color.Chocolate, g));
                    else if (j % 2 == 0) tiles.Add(new Tile(x, y, Color.Brown, g));
                }
            }
        }
    }

    public void drawText(Graphics g, String text)
    {

        // Create font and brush.
        Font drawFont = new Font("Arial", 16);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        // Create point for upper-left corner of drawing.
        float x = 900.0F;
        float y = 50.0F;

        // Set format of string.
        StringFormat drawFormat = new StringFormat();
        drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

        // Draw string to screen.
        g.DrawString(text, drawFont, drawBrush, x, y, drawFormat);
    }

    public void drawAsset(Graphics g)
    {
        Pawn pawn1 = new Pawn('w', tiles[10], g);       

        Pawn pawn2 = new Pawn('w', tiles[11], g);   
    }


    //            --------------------- EVENTS ---------------------
    public void mouse_click(object sender, MouseEventArgs e)
    {
        Graphics g = canvas.CreateGraphics();

        foreach (Tile tile in tiles)
        {
            if (tile.isInAreaOfTile(e.X, e.Y))
            {
                
                foreach(ChessPiece piece in ChessPiece.allPieces)
                {
                    if (piece.tile == tile)
                    {
                        if (selectedPiece != null) selectedPiece.tile.unHighlight(g);                       
                        selectedPiece = piece;
                        selectedPiece.tile.highlight(g);
                        Tile.HighlightTiles(selectedPiece.getAvailableMoves(tiles), g);
                    }
                }
                
            }
            
        }
    }


}
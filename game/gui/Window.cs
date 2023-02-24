public class Window
{
    Canvas canvas;
    static List<Tile> tiles = new List<Tile>();

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
        Pawn pawn1 = new Pawn(220, 120, 'w', g);
        tiles[10].setPieceOnTile(pawn1);

        Pawn pawn2 = new Pawn(320, 120, 'w', g);
        tiles[11].setPieceOnTile(pawn2);



    }


    //            --------------------- EVENTS ---------------------
    public void mouse_click(object sender, MouseEventArgs e)
    {
        Graphics g = canvas.CreateGraphics();

        foreach (Tile tile in tiles)
        {
            if (tile.isInAreaOfTile(e.X, e.Y))
            {
                if (tile.getPieceOnTile() != null)
                {
                    tile.highlightThis(g);    
                    tile.highlightAvailableMoves(g);                
                }
                else 
                {
                    
                }
                
            }
            
        }
    }


}
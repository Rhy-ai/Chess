public class Window
{
    Canvas canvas;
    public Window()
    {
        // --- boilerplate bullshit ---
        ApplicationConfiguration.Initialize();
        this.canvas = new Canvas();
        canvas.Paint += renderer;
        Application.Run(canvas);
    }

    // -------------------- THIS IS WHERE WE WILL DRAW STUFF --------------------------
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
                x = j * 100;
                y = i * 100;
                Rectangle square = new Rectangle(x, y, 100, 100); // (x, y, width, height)

                if (i % 2 == 0)
                {
                    if (j % 2 == 0) g.FillRectangle(new SolidBrush(Color.Chocolate), square);
                    else if (j % 2 == 1) g.FillRectangle(new SolidBrush(Color.Brown), square);
                }
                if (i % 2 == 1)
                {
                    if (j % 2 == 1) g.FillRectangle(new SolidBrush(Color.Chocolate), square);
                    else if (j % 2 == 0) g.FillRectangle(new SolidBrush(Color.Brown), square);
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
        try
        {
            // Retrieve the image.
            Bitmap image1 = new Bitmap(@"game\images\b_bishop_1x_ns.png", true);                
            
            image1.SetResolution(370f, 370f);
            //Render Image
            g.DrawImage(image1, new Point(205, 5));

        }
        catch (ArgumentException)
        {
            // If file path in inccorrect. this error will display
            MessageBox.Show("There was an error." +
                "Check the path to the image file.");
        }



    }



}
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
        Graphics graphics = e.Graphics;
        Rectangle rectangle = new Rectangle(100, 50, 200, 300);
        graphics.FillRectangle(new SolidBrush(Color.Red), rectangle);
       
    }

}
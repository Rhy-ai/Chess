public class Window
{
    Canvas canvas;
    public Window()
    {
        ApplicationConfiguration.Initialize();

        this.canvas = new Canvas();
        canvas.Paint += renderer;
        Application.Run(canvas);        
    }

    private void renderer(object sender, PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        Rectangle rectangle = new Rectangle(100, 50, 200, 300);
        graphics.FillRectangle(new SolidBrush(Color.Red), rectangle);
       
    }

}
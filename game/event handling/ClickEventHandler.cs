public class ClickEventHandler
{
    public EventHandler ClickEvent;
    public void onClick()
    {
        ClickEvent.Invoke(this, EventArgs.Empty);
    }
}
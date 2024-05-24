public class Program
{
    public static void PaintButton(IButtonFactory factory)
    {
        var button = factory.CreateButton();
        button.Paint();
    }

    public static void Main()
    {
        IButtonFactory macFactory = new MacFactory();
        IButtonFactory linuxFactory = new LinuxFactory();
        IButtonFactory winFactory = new WinFactory();        

        // mac
        PaintButton(macFactory);

        // linux
        PaintButton(linuxFactory);

        // windows
        PaintButton(winFactory);

        
    }
}
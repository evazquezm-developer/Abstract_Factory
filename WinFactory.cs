class WinFactory : IButtonFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }
}
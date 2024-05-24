class MacFactory : IButtonFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }    
}
class LinuxFactory : IButtonFactory
{
    public IButton CreateButton()
    {
        return new LinuxButton();
    }
}
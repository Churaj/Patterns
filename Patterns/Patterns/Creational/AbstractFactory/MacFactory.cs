namespace Patterns.Creational.AbstractFactory
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton() => new MacButton();

        public ICheckbox CreateCheckbox() => new MacCheckbox();

        public ITextbox CreateTextbox() => new MacTextbox();
    }
}

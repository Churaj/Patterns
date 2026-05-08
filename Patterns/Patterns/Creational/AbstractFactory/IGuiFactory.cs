namespace Patterns.Creational.AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();

        ICheckbox CreateCheckbox();

        ITextbox CreateTextbox();
    }
}

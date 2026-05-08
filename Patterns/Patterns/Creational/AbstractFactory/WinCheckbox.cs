namespace Patterns.Creational.AbstractFactory
{
    public class WinCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Windows Checkbox Rendered";
        }

        public string Toggle()
        {
            return "Windows Checkbox Toggled";
        }
    }
}

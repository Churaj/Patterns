namespace Patterns.Creational.AbstractFactory
{
    public class MacCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Mac OS Checkbox Rendered";
        }

        public string Toggle()
        {
            return "Mac OS Checkbox Toggled";
        }
    }
}

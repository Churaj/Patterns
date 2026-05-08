namespace Patterns.Creational.AbstractFactory
{
    public class WinTextbox : ITextbox
    {
        public string Render()
        {
            return "Windows Textbox Rendered";
        }

        public string SetText(string text)
        {
            return $"Windows Textbox Text Set: {text}";
        }
    }
}

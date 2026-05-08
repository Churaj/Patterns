namespace Patterns.Creational.AbstractFactory
{
    public class MacTextbox : ITextbox
    {
        public string Render()
        {
            return "Mac OS Textbox Rendered";
        }

        public string SetText(string text)
        {
            return $"Mac OS Textbox Text Set: {text}";
        }
    }
}

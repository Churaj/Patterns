using System;

namespace Patterns.Creational.AbstractFactory
{
    public class RenderingService : IRenderingService
    {
        private readonly IGuiFactory _guiFactory;

        public RenderingService(IGuiFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void Render()
        {
            var button = _guiFactory.CreateButton();
            var checkbox = _guiFactory.CreateCheckbox();
            var textbox = _guiFactory.CreateTextbox();

            var buttonRenderResult = button.Render();
            var checkboxRenderResult = checkbox.Render();
            var textboxRenderResult = textbox.Render();

            checkbox.Toggle();
            textbox.SetText("Hello, World!");

            Console.WriteLine(buttonRenderResult);
            Console.WriteLine(checkboxRenderResult);
            Console.WriteLine(textboxRenderResult);
        }
    }
}

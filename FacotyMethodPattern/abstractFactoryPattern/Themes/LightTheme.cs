namespace FacotyMethodPattern.abstractFactoryPattern.Themes
{
    public class LightTheme : ITheme
    {
        public Button ApplyTheme(Button button)
        {
            button.Type += " Light theme";
            return button;
        }
    }
}

namespace FacotyMethodPattern.abstractFactoryPattern.Themes
{
    public class DarkTheme : ITheme
    {
        public Button ApplyTheme(Button button)
        {
            button.Type += " Dark theme";
            return button;
        }
    }
}

using FacotyMethodPattern.abstractFactoryPattern.Themes;

namespace FacotyMethodPattern.abstractFactoryPattern.UI
{
    public class Apple : UIFactory
    {
        public Apple(ITheme theme)
        {
            _theme = theme;
        }

        public ITheme _theme;

        public override Button CreateButton()
        {
            var button = new Button { Type = "Apple button" };
            return _theme.ApplyTheme(button);
        }
    }
}

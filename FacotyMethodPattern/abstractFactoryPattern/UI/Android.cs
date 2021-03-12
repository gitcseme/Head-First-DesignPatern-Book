using FacotyMethodPattern.abstractFactoryPattern.Themes;

namespace FacotyMethodPattern.abstractFactoryPattern.UI
{
    public class Android : UIFactory
    {
        public Android(ITheme theme)
        {
            _theme = theme;
        }

        public ITheme _theme;

        public override Button CreateButton()
        {
            var button = new Button { Type = "Android button" };
            return _theme.ApplyTheme(button);
        }
    }
}

using CompositePattern.Component;

namespace CompositePattern
{
    public class Waitress
    {
        private readonly MenuComponent allMenus;

        public Waitress(MenuComponent menu)
        {
            allMenus = menu;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}

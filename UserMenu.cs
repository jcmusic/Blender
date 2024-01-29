using Blender.Abstract;

namespace Blender
{
    internal class UserMenu : IMenu
    {
        public List<(int Index, IState stateObject)> MenuTupleList { get; private set; }
            = new List<(int Index, IState stateObject)>();


        public UserMenu()
        {
            SetupMenu();
        }

        ///
        /// Load Menu Items - All classes deriving from State base class.
        ///
        void SetupMenu()
        {
            List<(int Index, IState stateObject)> menuTupleList = new List<(int Index, IState stateObject)>();

            var type = typeof(State);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => !p.IsAbstract)
                .Where(p => type.IsAssignableFrom(p));

            var index = 0;

            foreach (var item in types)
            {
                ++index;
                IState menuItem = (IState)Activator.CreateInstance(item);
                menuTupleList.Add(new(index, menuItem));
            }

            MenuTupleList = menuTupleList.OrderBy(i => i.stateObject.DisplayOrder).ToList();
        }
    }
}

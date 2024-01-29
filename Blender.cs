using Blender.Abstract;
using Blender.States;

namespace Blender
{
    internal class Blender
    {
        private IState _state = new OffState();
        private IMenu _menu;

        /// <summary>
        /// Blender is a class representing a virtual blender. 
        /// </summary>
        /// <param name="menu"> an object that contains a list of tuples : List<(int Index, IState stateObject)> 
        ///     which which be presented to the user as options to select to control the blender </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// Note: this could be improved to take a Menufactory and config for blenders 
        ///         with different options (standard Blender, Deluxe Blender, etc.)
        public Blender(IMenu menu)
        {
            _menu = menu ?? throw new ArgumentNullException(nameof(menu));
        }

        internal void PushButton(IState state)
        {
            _state = state;
            _state.Push();
        }

        ///
        /// display loaded menu to the console
        ///
        public void PresentUserMenu()
        {
            const int StartingState = 0;
            int userSelection = StartingState;

            Console.WriteLine("*** Menu ***");

            foreach (var menuTuple in _menu.MenuTupleList)
            {
                Console.WriteLine($"{menuTuple.Index}. {menuTuple.stateObject.StateName}");
            }
            Console.WriteLine("********** ");

            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Select blender option :");

                var userInput = Console.ReadLine();
                Console.WriteLine("");

                if (!Int32.TryParse(userInput, out userSelection))
                {
                    Console.WriteLine($"\"{userInput}\" is not a valid choice.");
                    continue;
                }

                try
                {
                    PushButton(_menu.MenuTupleList[userSelection - 1].stateObject);
                }
                catch (Exception)
                {
                    Console.WriteLine($"\"{userInput}\" is not a valid choice.");
                }
            }
        }
    }
}

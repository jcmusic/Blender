using Blender.Abstract;

namespace Blender
{
    internal interface IMenu
    {
        /// <summary>
        /// Menu options presented to the user to select from
        /// </summary>
        List<(int Index, IState stateObject)> MenuTupleList { get; }
    }
}
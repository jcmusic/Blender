namespace Blender.Abstract
{
    internal interface IState
    {
        string StateName { get; }
        int DisplayOrder { get; }
        internal void Push();
    }
}

namespace Blender.Abstract
{
    internal abstract class State : IState
    {
        public abstract string StateName { get; }
        public abstract int DisplayOrder { get; }

        public virtual void Push()
        {
            Console.WriteLine($"Blender is {StateName}.");
        }
    }
}


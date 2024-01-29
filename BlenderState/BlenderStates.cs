using Blender.Abstract;

namespace Blender.States
{
    internal class OffState : State
    {
        public override string StateName => "Off";

        public override int DisplayOrder => 1;
    }

    internal class LowState : State
    {
        public override string StateName => "Low";

        public override int DisplayOrder => 2;

        public override void Push()
        {
            Console.WriteLine($"Blender is on {StateName}.");
        }
    }

    internal class MediumState : State
    {
        public override string StateName => "Medium";

        public override int DisplayOrder => 3;

        public override void Push()
        {
            Console.WriteLine("Blender is on Medium.");
        }
    }

    internal class HighState : State
    {
        public override string StateName => "High";

        public override int DisplayOrder => 4;

        public override void Push()
        {
            Console.WriteLine("Blender is on High.");
        }
    }

    internal class TurboState : State
    {
        public override string StateName => "Turbo";

        public override int DisplayOrder => 5;

        public override void Push()
        {
            Console.WriteLine("Blender is on Turbo.");
        }
    }
}

using System.Collections.Generic;

namespace My_Application
{
    public class OOP_02_Inheritance_DependencyInjection
    {
        public void Main()
        {
            var sweeper = new Sweepable();
            var gallery = new ArtExhibit();

            var wallart = new Carpet(sweeper, gallery);

            foreach (var action in wallart.actions)
            {
                action.Action();
            }
        }
        
        public class Carpet
        {
            public int Lenght { get; set; }
            public int Width { get; set; }
            public string Pattern { get; set; }
            public string Origin { get; set; }

            public List<IAction> actions = new List<IAction>();

            public Carpet(params IAction[] actions)
            {
                this.actions.AddRange(actions);
            }
        }

        public interface IAction
        {
            void Action();
        }

        public class Sweepable : IAction
        {
            public void Action()
            {
                Sweep();
            }

            public void Sweep()
            {
                System.Console.WriteLine("Sweep");
            }
        }

        public class ArtExhibit : IAction
        {
            public void Action()
            {
                Exhibit();
            }

            public void Exhibit()
            {
                System.Console.WriteLine("Exhibit");
            }
        }
    }
}
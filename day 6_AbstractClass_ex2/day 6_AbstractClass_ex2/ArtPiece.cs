using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_AbstractClass_ex2
{
    public abstract class ArtPiece
    {
        public string Title;
        public string Artist;
        public int YearCreated;

        public abstract void Describe();
    }

    public class Painting: ArtPiece
    {
        public int CanvasSize;

        public override void Describe()
        {
            Console.WriteLine("Painting: " + Title + " by " + Artist + " created in " + YearCreated + " size: " + CanvasSize);
        }
    }

    public class Sculpture : ArtPiece
    {
        public string Material;

        public override void Describe()
        {
            Console.WriteLine("Sculpture: " + Title + " by " + Artist + " created in " + YearCreated + " made of " +Material);
        }
    }

}

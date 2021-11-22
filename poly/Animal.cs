using System;
using poly.enums;

namespace poly
{

    public abstract class Animal
    {
        protected string CommonName { get; set; }
        protected string ScientificName {get; set; }
        protected string Noise {get; set; }
        protected COLOR[] Colors { get; set; }
        protected string Name {get; set; }

        //Overloading method move.
        protected void Move(int distance, Func<string> wayToRun) {
            string action = $"{Name} is {wayToRun()} {distance} meters.";
            Console.WriteLine(action);
        }
        protected void Move(int from, int to, Func<string> wayToRun) {
            string action = $"{Name} is {wayToRun()} from {from} to {to}.";
            Console.WriteLine(action);
        }

        public abstract void Move(int distance);
        
        public virtual void MakeNoise() {
            string output = $"{Name} say: {Noise}";
            Console.WriteLine(output);
        }

        //Encapsulamiento
        public COLOR[] GetColors()
        {
            return Colors;
        }
        
        

    }
}
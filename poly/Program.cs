using System;
using poly.enums;

namespace poly
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal gatito       =   new Gato("yuuki", new[] {COLOR.White, COLOR.Black});
            Animal gatoVolador  =   new GatoVolador("yuuki volador", new[] {COLOR.White, COLOR.Black});
            Animal donatello    =   new Tortuga("donatello", new[]{COLOR.Green, COLOR.Purplue});
            Pato pato           =   new Pato("juancho", new[] {COLOR.White, COLOR.Green, COLOR.Blue});
            
            
            //Get encapsulated field "Colors"
            foreach (COLOR color in donatello.GetColors())
                Console.Write(color + ", ");
            Console.WriteLine();

            
            //Noises - method inheritance and overriding.
            gatito.MakeNoise();
            donatello.MakeNoise();
            pato.MakeNoise();
            gatoVolador.MakeNoise();
            
            //Calling abstract method Move()
            pato.Move(20);
            gatito.Move(30);
            donatello.Move(100);
            gatoVolador.Move(50);
 
            //Overloaded methods
            pato.Vuela(10);
            pato.Vuela(10, 50);

            //Casting and calling overloaded methods
            ((Tortuga)donatello).Nada(20);
            ((Tortuga)donatello).Nada(0, 100);
            ((Gato)gatito).Corre(10);
            ((Gato)gatito).Corre(0, 20);
            ((GatoVolador)gatoVolador).Vuela(10);
            ((GatoVolador)gatoVolador).Vuela(0, 10);

        }
    }
}
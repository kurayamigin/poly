using System;
using poly.enums;
using poly.interfaces;

namespace poly
{
    public class GatoVolador : Gato, IVolador {
        private const string _commonName = "Gato volador";

        public GatoVolador(string name, COLOR[] colors) 
            : base(name, colors)
        {
            CommonName = _commonName;
        }

        //Sobreescritura de metodos
        public override void Move(int distance) {
            Vuela(distance);
        }

        public override void MakeNoise() {
            string output = $"{Name} say: Metodo virtual sobreescrito :P";
            Console.WriteLine(output);
        }

        //Metodos implementados por interfaz
        public string Volar() {
            return "flying...";
        }

        public void Vuela(int distance) {
            base.Move(distance, Volar);
        }

        public void Vuela(int from, int to) {
            base.Move(from, to, Volar);
        }
    }
}
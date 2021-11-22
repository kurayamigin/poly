using System;
using poly.enums;
using poly.interfaces;

namespace poly
{
    public class Pato : Animal, IVolador, ITerrestre {
        private const string _scientificName = "Anatidae";
        private const string _commonName = "Pato";
        private const string _noise = "quak";

        public Pato(string name, COLOR[] colors)
        {
            ScientificName = _scientificName;
            CommonName = _commonName;
            Noise = _noise;
            Name = name;
            Colors = colors;
        }

        //Metodos heredados por clase abstracta
        public override void Move(int distance) {
            Vuela(distance);
        }

        //Metodos implementados por interfaz
        public string Correr() {
            return "runing...";
        }

        public string Caminar() {
            return "walking...";
        }
    
        public string Volar() {
            return "flying...";
        }

        public void Corre(int distance) {
            base.Move(distance, Correr);
        }
        public void Corre(int from, int to) {
            base.Move(from, to, Correr);
        }

        public void Camina(int distance) {
            base.Move(distance, Caminar);
        }
        public void Camina(int from, int to) {
            base.Move(from, to, Caminar);
        }

        public void Vuela(int distance) {
            base.Move(distance, Volar);
        }

        public void Vuela(int from, int to) {
            base.Move(from, to, Volar);
        }


    }
}